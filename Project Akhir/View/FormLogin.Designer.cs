namespace Project_Akhir
{
    partial class FormLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            this.tbUsernameLogin = new System.Windows.Forms.TextBox();
            this.tbPasswordLogin = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.linkLabelDaftar = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // tbUsernameLogin
            // 
            this.tbUsernameLogin.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbUsernameLogin.ForeColor = System.Drawing.Color.Silver;
            this.tbUsernameLogin.Location = new System.Drawing.Point(595, 338);
            this.tbUsernameLogin.Margin = new System.Windows.Forms.Padding(5);
            this.tbUsernameLogin.Multiline = true;
            this.tbUsernameLogin.Name = "tbUsernameLogin";
            this.tbUsernameLogin.Size = new System.Drawing.Size(425, 40);
            this.tbUsernameLogin.TabIndex = 0;
            this.tbUsernameLogin.Text = "Username";
            // 
            // tbPasswordLogin
            // 
            this.tbPasswordLogin.Font = new System.Drawing.Font("Nirmala UI", 12F);
            this.tbPasswordLogin.ForeColor = System.Drawing.Color.Silver;
            this.tbPasswordLogin.Location = new System.Drawing.Point(595, 436);
            this.tbPasswordLogin.Multiline = true;
            this.tbPasswordLogin.Name = "tbPasswordLogin";
            this.tbPasswordLogin.Size = new System.Drawing.Size(424, 41);
            this.tbPasswordLogin.TabIndex = 1;
            this.tbPasswordLogin.Text = "Password";
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.Red;
            this.btnLogin.Font = new System.Drawing.Font("Nirmala UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnLogin.Location = new System.Drawing.Point(595, 526);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(424, 64);
            this.btnLogin.TabIndex = 2;
            this.btnLogin.Text = "LOGIN";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.button1_Click);
            // 
            // linkLabelDaftar
            // 
            this.linkLabelDaftar.ActiveLinkColor = System.Drawing.Color.SandyBrown;
            this.linkLabelDaftar.AutoSize = true;
            this.linkLabelDaftar.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.linkLabelDaftar.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.linkLabelDaftar.Location = new System.Drawing.Point(747, 612);
            this.linkLabelDaftar.Name = "linkLabelDaftar";
            this.linkLabelDaftar.Size = new System.Drawing.Size(104, 20);
            this.linkLabelDaftar.TabIndex = 3;
            this.linkLabelDaftar.TabStop = true;
            this.linkLabelDaftar.Text = "Daftar Akun?";
            this.linkLabelDaftar.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelDaftar_LinkClicked);
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1130, 808);
            this.Controls.Add(this.linkLabelDaftar);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.tbPasswordLogin);
            this.Controls.Add(this.tbUsernameLogin);
            this.DoubleBuffered = true;
            this.Name = "FormLogin";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbUsernameLogin;
        private System.Windows.Forms.TextBox tbPasswordLogin;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.LinkLabel linkLabelDaftar;
    }
}

