using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TPL.Winforms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        #region "Members"

        private System.Diagnostics.Stopwatch stopwatch = null;

        #endregion

        #region "Private Methods"

        private void LoadSites()
        {
            this.lstSites.Items.Add("https://www.yahoo.com/");
            this.lstSites.Items.Add("https://www.msn.com/");
            this.lstSites.Items.Add("https://www.microsoft.com/");
            this.lstSites.Items.Add("https://www.google.com/");
            this.lstSites.Items.Add("https://www.espncricinfo.com/");
            this.lstSites.Items.Add("https://www.cnn.com/");
            this.lstSites.Items.Add("https://www.bbc.com/");
            this.lstSites.Items.Add("https://www.aljazeera.com/");
            this.lstSites.Items.Add("https://www.facebook.com/");
        }

        private void WriteLog(string log)
        {
            this.lstOutput.Items.Add(log);
        }

        private void UpdateLog(string log, int index)
        {
            this.lstOutput.Items.RemoveAt(index);
            this.lstOutput.Items.Insert(index, log);
        }

        private void UpdateLog(string log, string key)
        {
            for (int index = 0; index < this.lstOutput.Items.Count; index++)
            {
                string item = (string)this.lstOutput.Items[index];
                if (item.Contains(key))
                {
                    this.lstOutput.Items.RemoveAt(index);
                    this.lstOutput.Items.Insert(index, log);
                    break;
                }
            }
        }

        private void ResetLog()
        {
            this.lstOutput.Items.Clear();
        }

        private void StartStopWatch()
        {
            this.stopwatch = System.Diagnostics.Stopwatch.StartNew();
        }

        private long GetStopWatchTime()
        {
            this.stopwatch.Stop();
            return this.stopwatch.ElapsedMilliseconds;
        }

        #endregion

        #region "Events"

        private void Form1_Load(object sender, EventArgs e)
        {
            this.LoadSites();
        }

        private void btnReadSync_Click(object sender, EventArgs e)
        {
            this.ResetLog();
            int index = 0;
            this.StartStopWatch();
            foreach (string site in this.lstSites.Items)
            {
                this.WriteLog($"Downloading site {site}");
                string log = TPL.Lib.TplDemo.DownloadSite(site);
                this.UpdateLog(log, index);
                index++;
            }
            long totalTime = this.GetStopWatchTime();
            this.WriteLog($"Operation Completed in ({totalTime}) ms");
        }

        private async void btnReadAsync_Click(object sender, EventArgs e)
        {
            this.ResetLog();
            int index = 0;
            this.StartStopWatch();
            foreach (string site in this.lstSites.Items)
            {
                this.WriteLog($"Downloading site {site}");
                string log = await TPL.Lib.TplDemo.DownloadSiteAsync(site);
                this.UpdateLog(log, index);
                index++;
            }
            long totalTime = this.GetStopWatchTime();
            this.WriteLog($"Operation Completed in ({totalTime}) ms");
        }

        private async void btnReadAsyncParallal_Click(object sender, EventArgs e)
        {
            this.ResetLog();
            int index = 0;
            List<Task<string>> tasks = new List<Task<string>>();

            this.StartStopWatch();
            foreach (string site in this.lstSites.Items)
            {
                this.WriteLog($"Downloading site {site}");
                tasks.Add(TPL.Lib.TplDemo.DownloadSiteAsync(site));
            }

            var results = await Task.WhenAll(tasks);

            foreach (var log in results)
            {
                this.UpdateLog(log, index);
                index++;
            }

            long totalTime = this.GetStopWatchTime();
            this.WriteLog($"Operation Completed in ({totalTime}) ms");
        }

        private async void btnReadAsyncParallalWithReport_Click(object sender, EventArgs e)
        {
            this.ResetLog();
            int index = 0;
            List<Task<string>> tasks = new List<Task<string>>();
            Progress<TPL.Lib.ProgressReport> progress = new Progress<Lib.ProgressReport>();
            progress.ProgressChanged += Progress_ProgressChanged;

            this.StartStopWatch();
            foreach (string site in this.lstSites.Items)
            {
                this.WriteLog($"Downloading site {site}");
                tasks.Add(TPL.Lib.TplDemo.DownloadSiteAsync(site, progress, new Lib.ProgressReport(index, site)));
                index++;
            }

            await Task.WhenAll(tasks);
            long totalTime = this.GetStopWatchTime();
            this.WriteLog($"Operation Completed in ({totalTime}) ms");
        }

        private void Progress_ProgressChanged(object sender, Lib.ProgressReport e)
        {
            this.UpdateLog(e.LogMessage, e.Index);
        }

        #endregion
    }
}
