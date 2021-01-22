using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectRain
{
    public partial class Loading : Form
    {
        public Loading()
        {
            InitializeComponent();
        }

        private void Loading_Load(object sender, EventArgs e)
        {
            cooldown.Start();
            MainTimer.Start();
        }
        private void cooldown_Tick(object sender, EventArgs e)
        {
            if (pic.Visible == true)
            {
                ani.Hide(pic);
                return;
            }
            else
            {
                ani.Show(pic);
                return;
            }
        }

        private void MainTimer_Tick(object sender, EventArgs e)
        {
            cooldown.Stop();
            MainTimer.Stop();
            MainForm main = new MainForm();
            main.Show();
            this.Hide();
        }
    }
}
