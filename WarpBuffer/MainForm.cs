using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Configuration;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Amib.Threading;
using Leaf.xNet;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace WarpBuffer
{
    public partial class MainForm : Form
    {
        private SmartThreadPool _threadPool;
        private SmartThreadPool _threads;
        private CancellationTokenSource _tokenSource;
        private CancellationToken _token;
        private List<string> _proxies;
        private readonly Random _random = new Random();
        private string _proxyPath;
        private int _earned;
        private int _totalDone;
        private readonly object _lock = new object();
        private int _max = 100;
        public MainForm()
        {
            InitializeComponent();
        }

        private void UpdateEarned()
        {
            Invoke(new Action(() => { lbEarned.Text = _earned.ToString(); }));
        }

        private void UpdateTotalDone()
        {
            _totalDone++;
            Invoke(new Action(() => { lbTotalDoneClient.Text = _totalDone.ToString(); }));
        }

        private void DoWork(string clientid, int totalWorker)
        {
            Logs($"ID '{clientid}': Start");
            _max = int.Parse(numMaxGB.Text);
            _earned = 0;
            _totalDone = 0;
            var total = 0;
            _threads = new SmartThreadPool(){Concurrency = totalWorker, MaxThreads = totalWorker, MinThreads = totalWorker};
            for (var i = 0; i < totalWorker; i++)
            {
                _threads.QueueWorkItem(() =>
                {
                    while (true)
                    {
                        lock (_lock)
                        {
                            if (total >= _max)
                            {
                                return;
                            }
                        }

                        if (_token.IsCancellationRequested)
                        {
                            return;
                        }

                        HttpRequest request = null;
                        StringContent body = null;
                        var proxy = RandomProxy();
                        if (proxy == "")
                        {
                            return;
                        }

                        try
                        {
                            var proxyInfo = ProxyClient.Parse(ProxyType.HTTP, proxy);
                            request = new HttpRequest {Proxy = proxyInfo, KeepAlive = false, ConnectTimeout = 2000};
                            request.AddHeader("Content-Type", "application/json");
                            body = new StringContent(JsonConvert.SerializeObject(new
                            {
                                referrer = clientid
                            }));
                            if (total <= _max)
                            {
                                request.Post("https://api.cloudflareclient.com/v0a778/reg", body);
                            }

                            lock (_lock)
                            {
                                total++;
                                _earned++;
                                UpdateEarned();
                            }
                        }
                        catch (ProxyException proxyException)
                        {
                            _proxies.Remove(proxy);
                            Logs($"Proxy Error: {proxy} - {proxyException.Message}");
                        }
                        catch (HttpException httpException)
                        {
                            Logs($"Http Error: {proxy} - {httpException.Message}");
                        }
                        catch (Exception e)
                        {
                            Logs($"Error: {e.Message}");
                        }
                        finally
                        {
                            request?.Dispose();
                            body?.Dispose();
                        }
                    }
                });
            }
            _threads.Start();
            _threads.Join();
            _threads.WaitForIdle();
            _threads.Dispose();
            UpdateTotalDone();
            Logs($"ID {clientid}: Earned {_earned} GB");
        }

        private void Running(bool status)
        {
            Invoke(new Action(() =>
            {
                btnStart.Enabled = !status;
                btnStop.Enabled = status;
            }));
        }

        private void Logs(string message)
        {
            Invoke(new Action(() =>
            {
                if (txtLogs.TextLength == 0)
                {
                    txtLogs.SelectionStart = txtLogs.TextLength;
                    txtLogs.SelectedText = message;
                }
                else
                {
                    txtLogs.SelectionStart = txtLogs.TextLength;
                    txtLogs.SelectedText = Environment.NewLine + message;
                }
            }));
        }

        private string RandomProxy()
        {
            return _proxies.Count > 0 ? _proxies[_random.Next(_proxies.Count)] : "";
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            txtLogs.Clear();
            if (File.Exists(_proxyPath) == false)
            {
                return;
            }
            _proxies = new List<string>();
            var proxies = File.ReadLines(_proxyPath);
            foreach (var proxy in proxies)
            {
                _proxies.Add(proxy.Trim());
            }
            if (_proxies.Count == 0)
            {
                return;
            }
            _tokenSource = new CancellationTokenSource();
            _token = _tokenSource.Token;
            Running(true);
            var listClientId = txtClientIDList.Text.Trim();
            var clients = Regex.Split(listClientId, "\n", RegexOptions.Multiline);
            _threadPool = new SmartThreadPool(){Concurrency = 1, MaxThreads = 1, MinThreads = 1};
            var totalClient = 0;
            foreach (var _ in clients)
            {
                var client = _.Trim();
                if (client.Length <= 0) continue;
                _threadPool.QueueWorkItem(DoWork, client, int.Parse(numThreads.Text));
                totalClient++;
            }
            lbTotalProxy.Text = _proxies.Count.ToString();
            lbTotalClient.Text = totalClient.ToString();
            new Thread(() =>
            {
                _threadPool.Start();
                _threadPool.Join();
                _threadPool.WaitForIdle();
                _threadPool.Dispose();
                _tokenSource.Dispose();
                GC.Collect();
                GC.WaitForPendingFinalizers();
                GC.Collect();
                Running(false);
            })
            { IsBackground = true}.Start();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            if (_tokenSource == null || _tokenSource.IsCancellationRequested) return;
            _tokenSource.Cancel();
            _tokenSource.Dispose();
            btnStop.Enabled = false;
        }

        private void btnLoadProxy_Click(object sender, EventArgs e)
        {
            var dialog = new OpenFileDialog();
            if (dialog.ShowDialog() != DialogResult.OK) return;
            _proxyPath = dialog.FileName;
            txtProxyPath.Text = _proxyPath;
            Properties.Settings.Default.ProxyFilePath = _proxyPath;
            Properties.Settings.Default.Save();
            Properties.Settings.Default.Reload();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            txtProxyPath.Text = Properties.Settings.Default.ProxyFilePath;
            _proxyPath = txtProxyPath.Text;
        }
    }
}
