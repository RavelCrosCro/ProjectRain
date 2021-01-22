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
    public partial class CustomMessageForm : Form
    {
        public CustomMessageForm()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CustomMessageForm_Load(object sender, EventArgs e)
        {
            title.Text = Properties.Settings.Default.CustomTitle;
            textbox.Text = Properties.Settings.Default.CustomMSG;
        }
    }
}
