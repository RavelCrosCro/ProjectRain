using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using ProjectRain;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace ProjectRain
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void HomeBnt_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage1;
        }

        private void StresserHub_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage2;
        }

        private void ExtraTools_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage3;
        }

        private void SettingsBtn_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage4;
        }

        public void ShowMessage(string title, string message)
        {
            Properties.Settings.Default.CustomTitle = title;
            Properties.Settings.Default.CustomMSG = message;
            new CustomMessageForm().ShowDialog();
            return;
        }

        private void ping_Click(object sender, EventArgs e)
        {
            Features.ExtraTools.Ping(host.Text);
        }

        private void tcpping_Click(object sender, EventArgs e)
        {
            Features.ExtraTools.TCPPing(host.Text, port.Text);
        }

        private async void lookup_Click(object sender, EventArgs e)
        {
            lookup.Enabled = false;
            string Text = await Features.ExtraTools.GeoLocation(host.Text);
            lookup.Enabled = true;
            ShowMessage("Geo Location", Text);
        }

        private async void portscan_Click(object sender, EventArgs e)
        {
            portscan.Enabled = false;
            string Text = await Features.ExtraTools.NmapScanner(host.Text);
            portscan.Enabled = true;
            ShowMessage("Port Scanner", Text);
        }

        private async void MainForm_Load(object sender, EventArgs e) //FORM LOAD
        {
            try
            {
                pfp.Image = new Bitmap(Properties.Settings.Default.pfpurl);
            }
            catch
            {

            }
            newstextbox.Text = await Features.Http.NewsText();
            try
            {
                string path = Environment.CurrentDirectory;
                var firname = path + "\\datasaver.txt";
                var content = File.ReadAllText(firname);

                if (string.IsNullOrEmpty(content))
                {
                    logsText.Text = "Your logs are empty";
                }
                else
                {
                    logsText.Text = content;
                }
            }
            catch
            {

            }
            
        }

        private void Settings_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage5;
        }

        private void SendAttackBTN_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(host.Text) || string.IsNullOrWhiteSpace(port.Text) || string.IsNullOrWhiteSpace(time.Text))
            {
                ShowMessage("Attack Error", "You are missing ip, port or time. You must enter all fields to send attack");
                return;
            }
            else
            {
                //code for sending attack - safegaurd
                // Output goes to output (output.Text)
            }
        }

        private void add_Click(object sender, EventArgs e)
        {
            string path = Environment.CurrentDirectory;
            var firname = path + "\\datasaver.txt";
            if (string.IsNullOrWhiteSpace(dataip.Text) || string.IsNullOrWhiteSpace(user.Text))
            {
                ShowMessage("IP Saver Error", "IP And Username Fields Cannot Be Empty");
                return;
            }
            else
            {
                try
                {
                    File.AppendAllText(firname, "IP: " + dataip.Text + "  -  Username: " + user.Text + "  -  Info: " + info.Text + Environment.NewLine);
                    var content = File.ReadAllText(firname);

                    if (logsText.Text == "Hidden...")
                    {

                    }
                    else
                    {
                        logsText.Text = content;
                    }
                    ShowMessage("IP Saver - Info", "Your Input Has Been Successfully Saved");
                }
                catch
                {

                }
            }
        }
        private void editdata_Click_1(object sender, EventArgs e)
        {
            try
            {
                string path = Environment.CurrentDirectory;
                var firname = path + "\\datasaver.txt";
                var process = Process.Start(firname);
                process.WaitForExit();
                var content = File.ReadAllText(firname);

                if (logsText.Text == "Hidden...")
                {

                }
                else
                {
                    logsText.Text = content;
                }
            }
            catch
            {

            }
        }

        private void Chnage_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog() { Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp; *.png)|*.jpg; *.jpeg; *.gif; *.bmp; *.png" })
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    //c# display image in picture box 
                    pfp.Image = new Bitmap(ofd.FileName);
                    //c# image file path 
                    //pfp.Text = ofd.FileName;
                    string pfpurl = ofd.FileName;
                    Properties.Settings.Default.pfpurl = pfpurl;
                    Properties.Settings.Default.Save();
                }
            }
        }

        private void extraToolsShorcut_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage3;
        }

        private async void StartIpTools_Click(object sender, EventArgs e)
        {
            string HOST = ToolsHost.Text;

            if (string.IsNullOrWhiteSpace(type.Text) || type.Text.Contains("-"))
            {
                ShowMessage("ExtraTools Error", "Invaild Action Selected");
                return;
            }
            else
            {
                switch (type.Text)
                {
                    case "ICMP Ping":
                        Features.ExtraTools.Ping(HOST);
                        break;

                    case "DNS Lookup":
                        string Text = await Features.Http.Get($"https://api.hackertarget.com/dnslookup/?q={HOST}");
                        ShowMessage("ExtraTools Output", Text);
                        break;

                    case "Reverse DNS Lookup":
                        string Text1 = await Features.Http.Get($"https://api.hackertarget.com/reversedns/?q={HOST}");
                        ShowMessage("ExtraTools Output", Text1);
                        break;

                    case "Whois Lookup":
                        string Text2 = await Features.Http.Get($"https://api.hackertarget.com/whois/?q={HOST}");
                        ShowMessage("ExtraTools Output", Text2);
                        break;

                    case "Reverse IP Lookup":
                        string Text3 = await Features.Http.Get($"https://api.hackertarget.com/reverseiplookup/?q={HOST}");
                        ShowMessage("ExtraTools Output", Text3);
                        break;

                    case "HTTP Headers":
                        string Text4 = await Features.Http.Get($"https://api.hackertarget.com/httpheaders/?q={HOST}");
                        ShowMessage("ExtraTools Output", Text4);
                        break;

                    case "Page Links":
                        string Text5 = await Features.Http.Get($"https://api.hackertarget.com/pagelinks/?q={HOST}");
                        ShowMessage("ExtraTools Output", Text5);
                        break;
                }
            }
        }

        private void SpamButton_Click(object sender, EventArgs e)
        {
            int spamtime = Convert.ToInt32(SpamMiliseconds.Text);
            if (spamtime < 300 || spamtime > 9000)
            {
                ShowMessage("Text Spammer", "Alert: Minimum spam time is 300 miliseconds and max spam time is 9000 (9sec) miliseconds");
                return;
            }
            else if (string.IsNullOrWhiteSpace(SpamText.Text) || string.IsNullOrWhiteSpace(SpamMiliseconds.Text))
            {
                ShowMessage("Text Spammer", "Error: You must enter text to spam and time");
                return;
            }
            else
            {
                spamTimer.Interval = spamtime;
                if (SpamButton.Text == "Start")
                {
                    SpamButton.Text = "Stop";
                    spamTimer.Start();
                }
                else
                {
                    SpamButton.Text = "Start";
                    spamTimer.Stop();
                }
            }
        }

        private void spamTimer_Tick(object sender, EventArgs e)
        {
            SendKeys.Send(SpamText.Text);
            SendKeys.Send("{ENTER}");
        }
    }
}
