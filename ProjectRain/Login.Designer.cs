namespace ProjectRain
{
    partial class Login
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.banner = new System.Windows.Forms.Panel();
            this.title = new System.Windows.Forms.Label();
            this.exit = new Guna.UI2.WinForms.Guna2Button();
            this.buttonPanel = new System.Windows.Forms.Panel();
            this.line = new Guna.UI2.WinForms.Guna2Separator();
            this.loginBTN = new Guna.UI2.WinForms.Guna2Button();
            this.RegisterBTN = new Guna.UI2.WinForms.Guna2Button();
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.remebermelabel = new System.Windows.Forms.Label();
            this.LoginSwitch = new Guna.UI2.WinForms.Guna2ToggleSwitch();
            this.LoginButton = new Guna.UI2.WinForms.Guna2Button();
            this.LoginPassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.LoginUsername = new Guna.UI2.WinForms.Guna2TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.ShowTokenAndPass = new Guna.UI2.WinForms.Guna2ToggleSwitch();
            this.RegisterToken = new Guna.UI2.WinForms.Guna2TextBox();
            this.RegisterEmail = new Guna.UI2.WinForms.Guna2TextBox();
            this.RegisterButton = new Guna.UI2.WinForms.Guna2Button();
            this.RegisterPassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.RegisterUser = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.banner.SuspendLayout();
            this.buttonPanel.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // banner
            // 
            this.banner.Controls.Add(this.title);
            this.banner.Controls.Add(this.exit);
            this.banner.Dock = System.Windows.Forms.DockStyle.Top;
            this.banner.Location = new System.Drawing.Point(0, 0);
            this.banner.Name = "banner";
            this.banner.Size = new System.Drawing.Size(608, 49);
            this.banner.TabIndex = 0;
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.title.ForeColor = System.Drawing.Color.White;
            this.title.Location = new System.Drawing.Point(12, 11);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(119, 25);
            this.title.TabIndex = 2;
            this.title.Text = "Project Rain";
            // 
            // exit
            // 
            this.exit.Animated = true;
            this.exit.CheckedState.Parent = this.exit;
            this.exit.CustomImages.Parent = this.exit;
            this.exit.Dock = System.Windows.Forms.DockStyle.Right;
            this.exit.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(34)))), ((int)(((byte)(79)))));
            this.exit.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.exit.ForeColor = System.Drawing.Color.White;
            this.exit.HoverState.Parent = this.exit;
            this.exit.Image = ((System.Drawing.Image)(resources.GetObject("exit.Image")));
            this.exit.Location = new System.Drawing.Point(556, 0);
            this.exit.Name = "exit";
            this.exit.ShadowDecoration.Parent = this.exit;
            this.exit.Size = new System.Drawing.Size(52, 49);
            this.exit.TabIndex = 1;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // buttonPanel
            // 
            this.buttonPanel.Controls.Add(this.line);
            this.buttonPanel.Controls.Add(this.loginBTN);
            this.buttonPanel.Controls.Add(this.RegisterBTN);
            this.buttonPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonPanel.Location = new System.Drawing.Point(0, 49);
            this.buttonPanel.Name = "buttonPanel";
            this.buttonPanel.Size = new System.Drawing.Size(608, 45);
            this.buttonPanel.TabIndex = 1;
            // 
            // line
            // 
            this.line.Location = new System.Drawing.Point(2, -5);
            this.line.Name = "line";
            this.line.Size = new System.Drawing.Size(619, 10);
            this.line.TabIndex = 3;
            // 
            // loginBTN
            // 
            this.loginBTN.Animated = true;
            this.loginBTN.CheckedState.Parent = this.loginBTN;
            this.loginBTN.CustomImages.Parent = this.loginBTN;
            this.loginBTN.Dock = System.Windows.Forms.DockStyle.Left;
            this.loginBTN.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(34)))), ((int)(((byte)(79)))));
            this.loginBTN.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginBTN.ForeColor = System.Drawing.Color.White;
            this.loginBTN.HoverState.Parent = this.loginBTN;
            this.loginBTN.Image = ((System.Drawing.Image)(resources.GetObject("loginBTN.Image")));
            this.loginBTN.ImageSize = new System.Drawing.Size(25, 25);
            this.loginBTN.Location = new System.Drawing.Point(0, 0);
            this.loginBTN.Name = "loginBTN";
            this.loginBTN.ShadowDecoration.Parent = this.loginBTN;
            this.loginBTN.Size = new System.Drawing.Size(295, 45);
            this.loginBTN.TabIndex = 2;
            this.loginBTN.Text = "Login With Account";
            this.loginBTN.Click += new System.EventHandler(this.loginBTN_Click);
            // 
            // RegisterBTN
            // 
            this.RegisterBTN.Animated = true;
            this.RegisterBTN.CheckedState.Parent = this.RegisterBTN;
            this.RegisterBTN.CustomImages.Parent = this.RegisterBTN;
            this.RegisterBTN.Dock = System.Windows.Forms.DockStyle.Right;
            this.RegisterBTN.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(34)))), ((int)(((byte)(79)))));
            this.RegisterBTN.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegisterBTN.ForeColor = System.Drawing.Color.White;
            this.RegisterBTN.HoverState.Parent = this.RegisterBTN;
            this.RegisterBTN.Image = ((System.Drawing.Image)(resources.GetObject("RegisterBTN.Image")));
            this.RegisterBTN.ImageSize = new System.Drawing.Size(25, 25);
            this.RegisterBTN.Location = new System.Drawing.Point(296, 0);
            this.RegisterBTN.Name = "RegisterBTN";
            this.RegisterBTN.ShadowDecoration.Parent = this.RegisterBTN;
            this.RegisterBTN.Size = new System.Drawing.Size(312, 45);
            this.RegisterBTN.TabIndex = 3;
            this.RegisterBTN.Text = "Register New Account";
            this.RegisterBTN.Click += new System.EventHandler(this.RegisterBTN_Click);
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.ContainerControl = this;
            this.guna2DragControl1.TargetControl = this.banner;
            // 
            // tabControl1
            // 
            this.tabControl1.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(-5, 91);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(618, 267);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(34)))), ((int)(((byte)(79)))));
            this.tabPage1.Controls.Add(this.remebermelabel);
            this.tabPage1.Controls.Add(this.LoginSwitch);
            this.tabPage1.Controls.Add(this.LoginButton);
            this.tabPage1.Controls.Add(this.LoginPassword);
            this.tabPage1.Controls.Add(this.LoginUsername);
            this.tabPage1.Location = new System.Drawing.Point(4, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(610, 241);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            // 
            // remebermelabel
            // 
            this.remebermelabel.AutoSize = true;
            this.remebermelabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.remebermelabel.ForeColor = System.Drawing.Color.White;
            this.remebermelabel.Location = new System.Drawing.Point(113, 142);
            this.remebermelabel.Name = "remebermelabel";
            this.remebermelabel.Size = new System.Drawing.Size(84, 15);
            this.remebermelabel.TabIndex = 4;
            this.remebermelabel.Text = "Save my login";
            // 
            // LoginSwitch
            // 
            this.LoginSwitch.Animated = true;
            this.LoginSwitch.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.LoginSwitch.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.LoginSwitch.CheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.LoginSwitch.CheckedState.InnerColor = System.Drawing.Color.White;
            this.LoginSwitch.CheckedState.Parent = this.LoginSwitch;
            this.LoginSwitch.Location = new System.Drawing.Point(60, 139);
            this.LoginSwitch.Name = "LoginSwitch";
            this.LoginSwitch.ShadowDecoration.Parent = this.LoginSwitch;
            this.LoginSwitch.Size = new System.Drawing.Size(47, 20);
            this.LoginSwitch.TabIndex = 3;
            this.LoginSwitch.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.LoginSwitch.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.LoginSwitch.UncheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.LoginSwitch.UncheckedState.InnerColor = System.Drawing.Color.White;
            this.LoginSwitch.UncheckedState.Parent = this.LoginSwitch;
            this.LoginSwitch.CheckedChanged += new System.EventHandler(this.LoginSwitch_CheckedChanged);
            // 
            // LoginButton
            // 
            this.LoginButton.Animated = true;
            this.LoginButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(200)))), ((int)(((byte)(207)))));
            this.LoginButton.BorderRadius = 5;
            this.LoginButton.CheckedState.Parent = this.LoginButton;
            this.LoginButton.CustomImages.Parent = this.LoginButton;
            this.LoginButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(58)))), ((int)(((byte)(181)))));
            this.LoginButton.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.LoginButton.ForeColor = System.Drawing.Color.White;
            this.LoginButton.HoverState.Parent = this.LoginButton;
            this.LoginButton.Location = new System.Drawing.Point(60, 179);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.ShadowDecoration.Parent = this.LoginButton;
            this.LoginButton.Size = new System.Drawing.Size(475, 35);
            this.LoginButton.TabIndex = 2;
            this.LoginButton.Text = "Login";
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // LoginPassword
            // 
            this.LoginPassword.Animated = true;
            this.LoginPassword.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(200)))), ((int)(((byte)(207)))));
            this.LoginPassword.BorderRadius = 5;
            this.LoginPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.LoginPassword.DefaultText = "";
            this.LoginPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.LoginPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.LoginPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.LoginPassword.DisabledState.Parent = this.LoginPassword;
            this.LoginPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.LoginPassword.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(34)))), ((int)(((byte)(79)))));
            this.LoginPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.LoginPassword.FocusedState.Parent = this.LoginPassword;
            this.LoginPassword.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginPassword.ForeColor = System.Drawing.Color.White;
            this.LoginPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.LoginPassword.HoverState.Parent = this.LoginPassword;
            this.LoginPassword.Location = new System.Drawing.Point(60, 86);
            this.LoginPassword.Name = "LoginPassword";
            this.LoginPassword.PasswordChar = '*';
            this.LoginPassword.PlaceholderText = "Password";
            this.LoginPassword.SelectedText = "";
            this.LoginPassword.ShadowDecoration.Parent = this.LoginPassword;
            this.LoginPassword.Size = new System.Drawing.Size(475, 36);
            this.LoginPassword.TabIndex = 1;
            this.LoginPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // LoginUsername
            // 
            this.LoginUsername.Animated = true;
            this.LoginUsername.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(200)))), ((int)(((byte)(207)))));
            this.LoginUsername.BorderRadius = 5;
            this.LoginUsername.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.LoginUsername.DefaultText = "";
            this.LoginUsername.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.LoginUsername.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.LoginUsername.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.LoginUsername.DisabledState.Parent = this.LoginUsername;
            this.LoginUsername.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.LoginUsername.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(34)))), ((int)(((byte)(79)))));
            this.LoginUsername.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.LoginUsername.FocusedState.Parent = this.LoginUsername;
            this.LoginUsername.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginUsername.ForeColor = System.Drawing.Color.White;
            this.LoginUsername.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.LoginUsername.HoverState.Parent = this.LoginUsername;
            this.LoginUsername.Location = new System.Drawing.Point(60, 29);
            this.LoginUsername.Name = "LoginUsername";
            this.LoginUsername.PasswordChar = '\0';
            this.LoginUsername.PlaceholderText = "Username";
            this.LoginUsername.SelectedText = "";
            this.LoginUsername.ShadowDecoration.Parent = this.LoginUsername;
            this.LoginUsername.Size = new System.Drawing.Size(475, 36);
            this.LoginUsername.TabIndex = 0;
            this.LoginUsername.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.LoginUsername.TextChanged += new System.EventHandler(this.LoginUsername_TextChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(34)))), ((int)(((byte)(79)))));
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.ShowTokenAndPass);
            this.tabPage2.Controls.Add(this.RegisterToken);
            this.tabPage2.Controls.Add(this.RegisterEmail);
            this.tabPage2.Controls.Add(this.RegisterButton);
            this.tabPage2.Controls.Add(this.RegisterPassword);
            this.tabPage2.Controls.Add(this.RegisterUser);
            this.tabPage2.Location = new System.Drawing.Point(4, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(610, 241);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(97, 147);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 15);
            this.label1.TabIndex = 11;
            this.label1.Text = "Show Token and Password";
            // 
            // ShowTokenAndPass
            // 
            this.ShowTokenAndPass.Animated = true;
            this.ShowTokenAndPass.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ShowTokenAndPass.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ShowTokenAndPass.CheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.ShowTokenAndPass.CheckedState.InnerColor = System.Drawing.Color.White;
            this.ShowTokenAndPass.CheckedState.Parent = this.ShowTokenAndPass;
            this.ShowTokenAndPass.Location = new System.Drawing.Point(44, 144);
            this.ShowTokenAndPass.Name = "ShowTokenAndPass";
            this.ShowTokenAndPass.ShadowDecoration.Parent = this.ShowTokenAndPass;
            this.ShowTokenAndPass.Size = new System.Drawing.Size(47, 20);
            this.ShowTokenAndPass.TabIndex = 10;
            this.ShowTokenAndPass.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.ShowTokenAndPass.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.ShowTokenAndPass.UncheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.ShowTokenAndPass.UncheckedState.InnerColor = System.Drawing.Color.White;
            this.ShowTokenAndPass.UncheckedState.Parent = this.ShowTokenAndPass;
            this.ShowTokenAndPass.CheckedChanged += new System.EventHandler(this.ShowTokenAndPass_CheckedChanged);
            // 
            // RegisterToken
            // 
            this.RegisterToken.Animated = true;
            this.RegisterToken.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(200)))), ((int)(((byte)(207)))));
            this.RegisterToken.BorderRadius = 5;
            this.RegisterToken.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.RegisterToken.DefaultText = "";
            this.RegisterToken.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.RegisterToken.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.RegisterToken.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.RegisterToken.DisabledState.Parent = this.RegisterToken;
            this.RegisterToken.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.RegisterToken.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(34)))), ((int)(((byte)(79)))));
            this.RegisterToken.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.RegisterToken.FocusedState.Parent = this.RegisterToken;
            this.RegisterToken.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegisterToken.ForeColor = System.Drawing.Color.White;
            this.RegisterToken.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.RegisterToken.HoverState.Parent = this.RegisterToken;
            this.RegisterToken.Location = new System.Drawing.Point(313, 89);
            this.RegisterToken.Name = "RegisterToken";
            this.RegisterToken.PasswordChar = '\0';
            this.RegisterToken.PlaceholderText = "Token";
            this.RegisterToken.SelectedText = "";
            this.RegisterToken.ShadowDecoration.Parent = this.RegisterToken;
            this.RegisterToken.Size = new System.Drawing.Size(252, 36);
            this.RegisterToken.TabIndex = 9;
            this.RegisterToken.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.RegisterToken.UseSystemPasswordChar = true;
            // 
            // RegisterEmail
            // 
            this.RegisterEmail.Animated = true;
            this.RegisterEmail.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(200)))), ((int)(((byte)(207)))));
            this.RegisterEmail.BorderRadius = 5;
            this.RegisterEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.RegisterEmail.DefaultText = "";
            this.RegisterEmail.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.RegisterEmail.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.RegisterEmail.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.RegisterEmail.DisabledState.Parent = this.RegisterEmail;
            this.RegisterEmail.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.RegisterEmail.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(34)))), ((int)(((byte)(79)))));
            this.RegisterEmail.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.RegisterEmail.FocusedState.Parent = this.RegisterEmail;
            this.RegisterEmail.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegisterEmail.ForeColor = System.Drawing.Color.White;
            this.RegisterEmail.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.RegisterEmail.HoverState.Parent = this.RegisterEmail;
            this.RegisterEmail.Location = new System.Drawing.Point(44, 89);
            this.RegisterEmail.Name = "RegisterEmail";
            this.RegisterEmail.PasswordChar = '\0';
            this.RegisterEmail.PlaceholderText = "Discord Name and Tag";
            this.RegisterEmail.SelectedText = "";
            this.RegisterEmail.ShadowDecoration.Parent = this.RegisterEmail;
            this.RegisterEmail.Size = new System.Drawing.Size(252, 36);
            this.RegisterEmail.TabIndex = 8;
            this.RegisterEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // RegisterButton
            // 
            this.RegisterButton.Animated = true;
            this.RegisterButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(200)))), ((int)(((byte)(207)))));
            this.RegisterButton.BorderRadius = 5;
            this.RegisterButton.CheckedState.Parent = this.RegisterButton;
            this.RegisterButton.CustomImages.Parent = this.RegisterButton;
            this.RegisterButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(58)))), ((int)(((byte)(181)))));
            this.RegisterButton.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.RegisterButton.ForeColor = System.Drawing.Color.White;
            this.RegisterButton.HoverState.Parent = this.RegisterButton;
            this.RegisterButton.Location = new System.Drawing.Point(44, 183);
            this.RegisterButton.Name = "RegisterButton";
            this.RegisterButton.ShadowDecoration.Parent = this.RegisterButton;
            this.RegisterButton.Size = new System.Drawing.Size(521, 35);
            this.RegisterButton.TabIndex = 7;
            this.RegisterButton.Text = "Register";
            this.RegisterButton.Click += new System.EventHandler(this.RegisterButton_Click);
            // 
            // RegisterPassword
            // 
            this.RegisterPassword.Animated = true;
            this.RegisterPassword.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(200)))), ((int)(((byte)(207)))));
            this.RegisterPassword.BorderRadius = 5;
            this.RegisterPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.RegisterPassword.DefaultText = "";
            this.RegisterPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.RegisterPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.RegisterPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.RegisterPassword.DisabledState.Parent = this.RegisterPassword;
            this.RegisterPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.RegisterPassword.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(34)))), ((int)(((byte)(79)))));
            this.RegisterPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.RegisterPassword.FocusedState.Parent = this.RegisterPassword;
            this.RegisterPassword.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegisterPassword.ForeColor = System.Drawing.Color.White;
            this.RegisterPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.RegisterPassword.HoverState.Parent = this.RegisterPassword;
            this.RegisterPassword.Location = new System.Drawing.Point(313, 26);
            this.RegisterPassword.Name = "RegisterPassword";
            this.RegisterPassword.PasswordChar = '\0';
            this.RegisterPassword.PlaceholderText = "Password";
            this.RegisterPassword.SelectedText = "";
            this.RegisterPassword.ShadowDecoration.Parent = this.RegisterPassword;
            this.RegisterPassword.Size = new System.Drawing.Size(252, 36);
            this.RegisterPassword.TabIndex = 6;
            this.RegisterPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.RegisterPassword.UseSystemPasswordChar = true;
            // 
            // RegisterUser
            // 
            this.RegisterUser.Animated = true;
            this.RegisterUser.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(200)))), ((int)(((byte)(207)))));
            this.RegisterUser.BorderRadius = 5;
            this.RegisterUser.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.RegisterUser.DefaultText = "";
            this.RegisterUser.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.RegisterUser.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.RegisterUser.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.RegisterUser.DisabledState.Parent = this.RegisterUser;
            this.RegisterUser.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.RegisterUser.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(34)))), ((int)(((byte)(79)))));
            this.RegisterUser.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.RegisterUser.FocusedState.Parent = this.RegisterUser;
            this.RegisterUser.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegisterUser.ForeColor = System.Drawing.Color.White;
            this.RegisterUser.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.RegisterUser.HoverState.Parent = this.RegisterUser;
            this.RegisterUser.Location = new System.Drawing.Point(44, 26);
            this.RegisterUser.Name = "RegisterUser";
            this.RegisterUser.PasswordChar = '\0';
            this.RegisterUser.PlaceholderText = "Username";
            this.RegisterUser.SelectedText = "";
            this.RegisterUser.ShadowDecoration.Parent = this.RegisterUser;
            this.RegisterUser.Size = new System.Drawing.Size(252, 36);
            this.RegisterUser.TabIndex = 5;
            this.RegisterUser.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.TargetControl = this;
            // 
            // Login
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(34)))), ((int)(((byte)(79)))));
            this.ClientSize = new System.Drawing.Size(608, 334);
            this.Controls.Add(this.buttonPanel);
            this.Controls.Add(this.banner);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainPanel";
            this.Load += new System.EventHandler(this.Login_Load);
            this.banner.ResumeLayout(false);
            this.banner.PerformLayout();
            this.buttonPanel.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel banner;
        private Guna.UI2.WinForms.Guna2Button exit;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Panel buttonPanel;
        private Guna.UI2.WinForms.Guna2Button loginBTN;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private Guna.UI2.WinForms.Guna2Separator line;
        private Guna.UI2.WinForms.Guna2Button RegisterBTN;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private Guna.UI2.WinForms.Guna2TextBox LoginUsername;
        private System.Windows.Forms.Label remebermelabel;
        private Guna.UI2.WinForms.Guna2ToggleSwitch LoginSwitch;
        private Guna.UI2.WinForms.Guna2Button LoginButton;
        private Guna.UI2.WinForms.Guna2TextBox LoginPassword;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2ToggleSwitch ShowTokenAndPass;
        private Guna.UI2.WinForms.Guna2TextBox RegisterToken;
        private Guna.UI2.WinForms.Guna2TextBox RegisterEmail;
        private Guna.UI2.WinForms.Guna2Button RegisterButton;
        private Guna.UI2.WinForms.Guna2TextBox RegisterPassword;
        private Guna.UI2.WinForms.Guna2TextBox RegisterUser;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
    }
}