namespace Cafeteria
{
    partial class FormLogin
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Panel leftPanel;
        private System.Windows.Forms.PictureBox pbLeftTop;
        private System.Windows.Forms.PictureBox pbLeftBottom;

        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.PictureBox pbAvatar;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.Label lbSubtitle;
        private Cafeteria.Controls.NeumorphicTextBox tbUser;
        private Cafeteria.Controls.NeumorphicTextBox tbPass;
        private System.Windows.Forms.CheckBox chRemember;
        private Cafeteria.Controls.NeumorphicButton btLogin;
        private Cafeteria.Controls.NeumorphicButton btExit;
        private System.Windows.Forms.LinkLabel lnkForgot;
        private System.Windows.Forms.LinkLabel lnkSignup;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.leftPanel = new System.Windows.Forms.Panel();
            this.pbLeftTop = new System.Windows.Forms.PictureBox();
            this.pbLeftBottom = new System.Windows.Forms.PictureBox();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.pbAvatar = new System.Windows.Forms.PictureBox();
            this.lbTitle = new System.Windows.Forms.Label();
            this.lbSubtitle = new System.Windows.Forms.Label();
            this.tbUser = new Cafeteria.Controls.NeumorphicTextBox();
            this.tbPass = new Cafeteria.Controls.NeumorphicTextBox();
            this.chRemember = new System.Windows.Forms.CheckBox();
            this.btLogin = new Cafeteria.Controls.NeumorphicButton();
            this.btExit = new Cafeteria.Controls.NeumorphicButton();
            this.lnkForgot = new System.Windows.Forms.LinkLabel();
            this.lnkSignup = new System.Windows.Forms.LinkLabel();
            this.leftPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLeftTop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLeftBottom)).BeginInit();
            this.mainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbAvatar)).BeginInit();
            this.SuspendLayout();
            // 
            // leftPanel
            // 
            this.leftPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.leftPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.leftPanel.Controls.Add(this.pbLeftTop);
            this.leftPanel.Controls.Add(this.pbLeftBottom);
            this.leftPanel.Location = new System.Drawing.Point(0, 0);
            this.leftPanel.Name = "leftPanel";
            this.leftPanel.Size = new System.Drawing.Size(560, 720);
            this.leftPanel.TabIndex = 0;
            // 
            // pbLeftTop
            // 
            this.pbLeftTop.BackColor = System.Drawing.Color.Transparent;
            this.pbLeftTop.Location = new System.Drawing.Point(20, 12);
            this.pbLeftTop.Name = "pbLeftTop";
            this.pbLeftTop.Size = new System.Drawing.Size(520, 333);
            this.pbLeftTop.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbLeftTop.TabIndex = 0;
            this.pbLeftTop.TabStop = false;
            this.pbLeftTop.Click += new System.EventHandler(this.pbLeftTop_Click);
            this.pbLeftTop.Paint += new System.Windows.Forms.PaintEventHandler(this.pbLeft_Paint);
            // 
            // pbLeftBottom
            // 
            this.pbLeftBottom.BackColor = System.Drawing.Color.Transparent;
            this.pbLeftBottom.Location = new System.Drawing.Point(20, 355);
            this.pbLeftBottom.Name = "pbLeftBottom";
            this.pbLeftBottom.Size = new System.Drawing.Size(520, 353);
            this.pbLeftBottom.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbLeftBottom.TabIndex = 1;
            this.pbLeftBottom.TabStop = false;
            this.pbLeftBottom.Paint += new System.Windows.Forms.PaintEventHandler(this.pbLeft_Paint);
            // 
            // mainPanel
            // 
            this.mainPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mainPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(247)))));
            this.mainPanel.Controls.Add(this.pbAvatar);
            this.mainPanel.Controls.Add(this.lbTitle);
            this.mainPanel.Controls.Add(this.lbSubtitle);
            this.mainPanel.Controls.Add(this.tbUser);
            this.mainPanel.Controls.Add(this.tbPass);
            this.mainPanel.Controls.Add(this.chRemember);
            this.mainPanel.Controls.Add(this.btLogin);
            this.mainPanel.Controls.Add(this.btExit);
            this.mainPanel.Controls.Add(this.lnkForgot);
            this.mainPanel.Controls.Add(this.lnkSignup);
            this.mainPanel.Location = new System.Drawing.Point(560, 0);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(440, 720);
            this.mainPanel.TabIndex = 1;
            this.mainPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.mainPanel_Paint);
            // 
            // pbAvatar
            // 
            this.pbAvatar.BackColor = System.Drawing.Color.Transparent;
            this.pbAvatar.Location = new System.Drawing.Point(153, 12);
            this.pbAvatar.Name = "pbAvatar";
            this.pbAvatar.Size = new System.Drawing.Size(156, 131);
            this.pbAvatar.TabIndex = 0;
            this.pbAvatar.TabStop = false;
            this.pbAvatar.Paint += new System.Windows.Forms.PaintEventHandler(this.pbAvatar_Paint);
            // 
            // lbTitle
            // 
            this.lbTitle.Font = new System.Drawing.Font("Segoe UI", 28F, System.Drawing.FontStyle.Bold);
            this.lbTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(60)))));
            this.lbTitle.Location = new System.Drawing.Point(0, 150);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(440, 70);
            this.lbTitle.TabIndex = 1;
            this.lbTitle.Text = "Welcome Back";
            this.lbTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbSubtitle
            // 
            this.lbSubtitle.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lbSubtitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(110)))), ((int)(((byte)(130)))));
            this.lbSubtitle.Location = new System.Drawing.Point(0, 210);
            this.lbSubtitle.Name = "lbSubtitle";
            this.lbSubtitle.Size = new System.Drawing.Size(440, 30);
            this.lbSubtitle.TabIndex = 2;
            this.lbSubtitle.Text = "Sign in to your account";
            this.lbSubtitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbUser
            // 
            this.tbUser.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(248)))), ((int)(((byte)(250)))));
            this.tbUser.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.tbUser.Location = new System.Drawing.Point(40, 260);
            this.tbUser.Name = "tbUser";
            this.tbUser.Padding = new System.Windows.Forms.Padding(2);
            this.tbUser.Size = new System.Drawing.Size(360, 48);
            this.tbUser.TabIndex = 3;
            this.tbUser.UseSystemPasswordChar = false;
            // 
            // tbPass
            // 
            this.tbPass.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(248)))), ((int)(((byte)(250)))));
            this.tbPass.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.tbPass.Location = new System.Drawing.Point(40, 325);
            this.tbPass.Name = "tbPass";
            this.tbPass.Padding = new System.Windows.Forms.Padding(2);
            this.tbPass.Size = new System.Drawing.Size(360, 48);
            this.tbPass.TabIndex = 4;
            this.tbPass.UseSystemPasswordChar = true;
            // 
            // chRemember
            // 
            this.chRemember.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.chRemember.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(110)))));
            this.chRemember.Location = new System.Drawing.Point(40, 390);
            this.chRemember.Name = "chRemember";
            this.chRemember.Size = new System.Drawing.Size(104, 24);
            this.chRemember.TabIndex = 5;
            this.chRemember.Text = "Remember me";
            // 
            // btLogin
            // 
            this.btLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btLogin.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.btLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(60)))), ((int)(((byte)(80)))));
            this.btLogin.Location = new System.Drawing.Point(40, 430);
            this.btLogin.Name = "btLogin";
            this.btLogin.Size = new System.Drawing.Size(360, 55);
            this.btLogin.TabIndex = 6;
            this.btLogin.Text = "Sign In";
            this.btLogin.Click += new System.EventHandler(this.btlogin_Click);
            // 
            // btExit
            // 
            this.btExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btExit.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold);
            this.btExit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(60)))), ((int)(((byte)(80)))));
            this.btExit.Location = new System.Drawing.Point(40, 500);
            this.btExit.Name = "btExit";
            this.btExit.Size = new System.Drawing.Size(120, 42);
            this.btExit.TabIndex = 7;
            this.btExit.Text = "Exit";
            this.btExit.Click += new System.EventHandler(this.btexit_Click);
            // 
            // lnkForgot
            // 
            this.lnkForgot.AutoSize = true;
            this.lnkForgot.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lnkForgot.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(95)))), ((int)(((byte)(160)))));
            this.lnkForgot.Location = new System.Drawing.Point(300, 392);
            this.lnkForgot.Name = "lnkForgot";
            this.lnkForgot.Size = new System.Drawing.Size(169, 28);
            this.lnkForgot.TabIndex = 8;
            this.lnkForgot.TabStop = true;
            this.lnkForgot.Text = "Forgot password?";
            // 
            // lnkSignup
            // 
            this.lnkSignup.AutoSize = true;
            this.lnkSignup.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lnkSignup.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(95)))), ((int)(((byte)(160)))));
            this.lnkSignup.Location = new System.Drawing.Point(110, 660);
            this.lnkSignup.Name = "lnkSignup";
            this.lnkSignup.Size = new System.Drawing.Size(288, 28);
            this.lnkSignup.TabIndex = 9;
            this.lnkSignup.TabStop = true;
            this.lnkSignup.Text = "Don\'t have an account? Sign up";
            // 
            // FormLogin
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(1000, 720);
            this.Controls.Add(this.leftPanel);
            this.Controls.Add(this.mainPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormLogin_FormClosing);
            this.Load += new System.EventHandler(this.FormLogin_Load);
            this.leftPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbLeftTop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLeftBottom)).EndInit();
            this.mainPanel.ResumeLayout(false);
            this.mainPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbAvatar)).EndInit();
            this.ResumeLayout(false);

        }
    }
}
