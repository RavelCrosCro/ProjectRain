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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void loginBTN_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage1;
        }

        private void RegisterBTN_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage2;
        }

        private void ShowTokenAndPass_CheckedChanged(object sender, EventArgs e)
        {
            if (ShowTokenAndPass.Checked)
            {
                RegisterPassword.UseSystemPasswordChar = false;
                RegisterToken.UseSystemPasswordChar = false;
            }
            else
            {
                RegisterPassword.UseSystemPasswordChar = true;
                RegisterToken.UseSystemPasswordChar = true;
            }
        }

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(RegisterUser.Text) || string.IsNullOrWhiteSpace(RegisterPassword.Text) || string.IsNullOrWhiteSpace(RegisterEmail.Text) || string.IsNullOrWhiteSpace(RegisterToken.Text))
            {
                MessageBox.Show("Enter all fields to register an account", "Project Rain", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                if (!RegisterEmail.Text.Contains("#"))
                {
                    MessageBox.Show("invaild discord name entered", "Project Rain", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else
                {
                    //safegaurd code here (register)
                }
            }
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(LoginUsername.Text) || string.IsNullOrWhiteSpace(LoginPassword.Text))
            {
                MessageBox.Show("Enter all fields to login", "Project Rain", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                new MainForm().Show();
                this.Hide();
                //safegaurd login code here
            }
        }

        private void LoginSwitch_CheckedChanged(object sender, EventArgs e)
        {
            if (LoginSwitch.Checked == true)
            {
                Properties.Settings.Default.LoginUsername = LoginUsername.Text;
                Properties.Settings.Default.LoginPassword = LoginPassword.Text;
                Properties.Settings.Default.SaveLogin = true;
                Properties.Settings.Default.Save();
            }
            else
            {
                Properties.Settings.Default.LoginUsername = null;
                Properties.Settings.Default.LoginPassword = null;
                Properties.Settings.Default.SaveLogin = false;
                Properties.Settings.Default.Save();
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {
            DiscordRpc.StartDiscordRPC();

            if (Properties.Settings.Default.SaveLogin == true)
            {
                LoginUsername.Text = Properties.Settings.Default.LoginUsername;
                LoginPassword.Text = Properties.Settings.Default.LoginPassword;
                LoginSwitch.Checked = true;
            }
            else { }
        }

        private void LoginUsername_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
