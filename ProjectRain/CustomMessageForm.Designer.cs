namespace ProjectRain
{
    partial class CustomMessageForm
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
            this.Drag = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.title = new System.Windows.Forms.Label();
            this.banner = new System.Windows.Forms.Panel();
            this.button = new Guna.UI2.WinForms.Guna2Button();
            this.textbox = new System.Windows.Forms.RichTextBox();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.banner.SuspendLayout();
            this.SuspendLayout();
            // 
            // Drag
            // 
            this.Drag.ContainerControl = this;
            this.Drag.TargetControl = this.title;
            // 
            // title
            // 
            this.title.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.title.ForeColor = System.Drawing.Color.White;
            this.title.Location = new System.Drawing.Point(3, 6);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(434, 42);
            this.title.TabIndex = 3;
            this.title.Text = "Title Here";
            this.title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // banner
            // 
            this.banner.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(45)))), ((int)(((byte)(99)))));
            this.banner.Controls.Add(this.title);
            this.banner.Dock = System.Windows.Forms.DockStyle.Top;
            this.banner.Location = new System.Drawing.Point(0, 0);
            this.banner.Name = "banner";
            this.banner.Size = new System.Drawing.Size(440, 55);
            this.banner.TabIndex = 0;
            // 
            // button
            // 
            this.button.Animated = true;
            this.button.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(200)))), ((int)(((byte)(207)))));
            this.button.BorderRadius = 5;
            this.button.CheckedState.Parent = this.button;
            this.button.CustomImages.Parent = this.button;
            this.button.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(45)))), ((int)(((byte)(99)))));
            this.button.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.button.ForeColor = System.Drawing.Color.White;
            this.button.HoverState.Parent = this.button;
            this.button.Location = new System.Drawing.Point(0, 273);
            this.button.Name = "button";
            this.button.ShadowDecoration.Parent = this.button;
            this.button.Size = new System.Drawing.Size(440, 51);
            this.button.TabIndex = 3;
            this.button.Text = "OK";
            this.button.Click += new System.EventHandler(this.button_Click);
            // 
            // textbox
            // 
            this.textbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(34)))), ((int)(((byte)(79)))));
            this.textbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textbox.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.textbox.ForeColor = System.Drawing.Color.White;
            this.textbox.Location = new System.Drawing.Point(8, 68);
            this.textbox.Name = "textbox";
            this.textbox.ReadOnly = true;
            this.textbox.Size = new System.Drawing.Size(420, 190);
            this.textbox.TabIndex = 7;
            this.textbox.Text = "N/A";
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.TargetControl = this;
            // 
            // CustomMessageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(34)))), ((int)(((byte)(79)))));
            this.ClientSize = new System.Drawing.Size(440, 324);
            this.Controls.Add(this.textbox);
            this.Controls.Add(this.button);
            this.Controls.Add(this.banner);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CustomMessageForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rain Message";
            this.Load += new System.EventHandler(this.CustomMessageForm_Load);
            this.banner.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2DragControl Drag;
        private System.Windows.Forms.Panel banner;
        private System.Windows.Forms.Label title;
        private Guna.UI2.WinForms.Guna2Button button;
        private System.Windows.Forms.RichTextBox textbox;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
    }
}