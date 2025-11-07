namespace IkanLogger
{
    partial class SignUp
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
            txtSignUp = new Label();
            tbPassword = new TextBox();
            btnSignUp = new Button();
            txtPassword = new Label();
            txtAlready = new Label();
            linkLogin = new LinkLabel();
            txtUsername = new Label();
            tbUsername = new TextBox();
            SuspendLayout();
            // 
            // txtSignUp
            // 
            txtSignUp.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtSignUp.AutoSize = true;
            txtSignUp.BackColor = Color.Transparent;
            txtSignUp.FlatStyle = FlatStyle.Flat;
            txtSignUp.Font = new Font("MAUIKEA Demo", 33.6F);
            txtSignUp.Location = new Point(875, 257);
            txtSignUp.Margin = new Padding(0);
            txtSignUp.Name = "txtSignUp";
            txtSignUp.Size = new Size(214, 56);
            txtSignUp.TabIndex = 0;
            txtSignUp.Text = "Sign Up";
            // 
            // tbPassword
            // 
            tbPassword.BorderStyle = BorderStyle.None;
            tbPassword.Font = new Font("Plus Jakarta Sans SemiBold", 16.8000011F, FontStyle.Bold);
            tbPassword.Location = new Point(655, 588);
            tbPassword.Margin = new Padding(0);
            tbPassword.MaximumSize = new Size(700, 50);
            tbPassword.MinimumSize = new Size(0, 50);
            tbPassword.Name = "tbPassword";
            tbPassword.Size = new Size(600, 50);
            tbPassword.TabIndex = 3;
            tbPassword.UseSystemPasswordChar = true;
            // 
            // btnSignUp
            // 
            btnSignUp.BackColor = Color.Transparent;
            btnSignUp.FlatAppearance.BorderSize = 0;
            btnSignUp.FlatStyle = FlatStyle.Flat;
            btnSignUp.Font = new Font("Plus Jakarta Sans", 22.7999973F, FontStyle.Bold);
            btnSignUp.Location = new Point(880, 700);
            btnSignUp.Margin = new Padding(0);
            btnSignUp.Name = "btnSignUp";
            btnSignUp.Size = new Size(183, 69);
            btnSignUp.TabIndex = 4;
            btnSignUp.Text = "Sign Up";
            btnSignUp.UseVisualStyleBackColor = false;
            btnSignUp.Click += btnSignUp_Click;
            // 
            // txtPassword
            // 
            txtPassword.AutoSize = true;
            txtPassword.BackColor = Color.Transparent;
            txtPassword.Font = new Font("Plus Jakarta Sans Medium", 16F, FontStyle.Bold);
            txtPassword.Location = new Point(640, 524);
            txtPassword.Margin = new Padding(0);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(147, 45);
            txtPassword.TabIndex = 5;
            txtPassword.Text = "Password";
            // 
            // txtAlready
            // 
            txtAlready.AutoSize = true;
            txtAlready.BackColor = Color.Transparent;
            txtAlready.Font = new Font("Plus Jakarta Sans Medium", 16.8F, FontStyle.Bold);
            txtAlready.Location = new Point(713, 787);
            txtAlready.Margin = new Padding(0);
            txtAlready.Name = "txtAlready";
            txtAlready.Size = new Size(360, 46);
            txtAlready.TabIndex = 6;
            txtAlready.Text = "Already have an account?";
            // 
            // linkLogin
            // 
            linkLogin.AutoSize = true;
            linkLogin.BackColor = Color.Transparent;
            linkLogin.Font = new Font("Plus Jakarta Sans ExtraBold", 16.8000011F, FontStyle.Bold);
            linkLogin.Location = new Point(1059, 787);
            linkLogin.Margin = new Padding(0);
            linkLogin.Name = "linkLogin";
            linkLogin.Size = new Size(99, 48);
            linkLogin.TabIndex = 5;
            linkLogin.TabStop = true;
            linkLogin.Text = "Login";
            linkLogin.LinkClicked += linkLogin_LinkClicked;
            // 
            // txtUsername
            // 
            txtUsername.AutoSize = true;
            txtUsername.BackColor = Color.Transparent;
            txtUsername.FlatStyle = FlatStyle.Flat;
            txtUsername.Font = new Font("Plus Jakarta Sans Medium", 16F, FontStyle.Bold);
            txtUsername.ForeColor = SystemColors.ControlText;
            txtUsername.Location = new Point(640, 364);
            txtUsername.Margin = new Padding(0);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(153, 45);
            txtUsername.TabIndex = 9;
            txtUsername.Text = "Username";
            // 
            // tbUsername
            // 
            tbUsername.BorderStyle = BorderStyle.None;
            tbUsername.Cursor = Cursors.IBeam;
            tbUsername.Font = new Font("Plus Jakarta Sans SemiBold", 16.8000011F, FontStyle.Bold);
            tbUsername.Location = new Point(655, 430);
            tbUsername.Margin = new Padding(0);
            tbUsername.MaximumSize = new Size(700, 0);
            tbUsername.MinimumSize = new Size(0, 50);
            tbUsername.Name = "tbUsername";
            tbUsername.Size = new Size(600, 50);
            tbUsername.TabIndex = 2;
            // 
            // SignUp
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Artboard_155;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(874, 556);
            Controls.Add(txtUsername);
            Controls.Add(tbUsername);
            Controls.Add(linkLogin);
            Controls.Add(txtAlready);
            Controls.Add(txtPassword);
            Controls.Add(btnSignUp);
            Controls.Add(tbPassword);
            Controls.Add(txtSignUp);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Name = "SignUp";
            Text = "Form1";
            WindowState = FormWindowState.Maximized;
            Load += SignUp_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label title;
        private TextBox tbPassword;
        private Button btnSignUp;
        private Label lblPassword;
        private Label label1;
        private LinkLabel linkLogin;
        private Label lblUsername;
        private TextBox tbUsername;
        private Label txtUsername;
        private Label txtPassword;
        private Label txtAlready;
        private Label txtSignUp;
        private Button BtnSignUp;
    }
}