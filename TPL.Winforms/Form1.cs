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

        private void Form1_Load(object sender, EventArgs e)
        {
            this.LoadSites();
        }

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

        private void UpdateLog(string log, string key)
        {
            for (int i = 0; i < this.lstOutput.Items.Count; i++)
            {
                string item = (string)this.lstOutput.Items[i];
                if (item.Contains(key))
                {
                    item = log;
                    break;
                }
            }
        }

        private void ResetLog()
        {
            this.lstOutput.Items.Clear();
        }

        private void btnReadSync_Click(object sender, EventArgs e)
        {
            this.ResetLog();
            foreach (string site in this.lstSites.Items)
            {
                this.WriteLog($"Downloading site {site}");
                string log = TPL.Lib.TplDemo.DownloadSite(site);
                this.UpdateLog(log, site);
            }
            this.WriteLog("Operation Completed");
        }

        private async void btnReadAsync_Click(object sender, EventArgs e)
        {
            this.ResetLog();
            foreach (string site in this.lstSites.Items)
            {
                this.WriteLog($"Downloading site {site}");
                string log = await TPL.Lib.TplDemo.DownloadSiteAsync(site);
                this.UpdateLog(log, site);
            }
            this.WriteLog("Operation Completed");
        }
    }
}
