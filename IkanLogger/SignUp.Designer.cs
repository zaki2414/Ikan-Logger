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
            title = new Label();
            tbPassword = new TextBox();
            btnSignUp = new Button();
            lblPassword = new Label();
            label1 = new Label();
            linkLogin = new LinkLabel();
            lblUsername = new Label();
            tbUsername = new TextBox();
            SuspendLayout();
            // 
            // title
            // 
            title.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            title.AutoSize = true;
            title.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            title.Location = new Point(365, 85);
            title.Name = "title";
            title.Size = new Size(159, 50);
            title.TabIndex = 0;
            title.Text = "Sign Up";
            // 
            // tbPassword
            // 
            tbPassword.Location = new Point(333, 254);
            tbPassword.Margin = new Padding(3, 4, 3, 4);
            tbPassword.Name = "tbPassword";
            tbPassword.Size = new Size(238, 27);
            tbPassword.TabIndex = 3;
            tbPassword.UseSystemPasswordChar = true;
            // 
            // btnSignUp
            // 
            btnSignUp.Location = new Point(333, 305);
            btnSignUp.Margin = new Padding(3, 4, 3, 4);
            btnSignUp.Name = "btnSignUp";
            btnSignUp.Size = new Size(238, 29);
            btnSignUp.TabIndex = 4;
            btnSignUp.Text = "Sign Up";
            btnSignUp.UseVisualStyleBackColor = true;
            btnSignUp.Click += btnSignUp_Click;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Location = new Point(333, 230);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(70, 20);
            lblPassword.TabIndex = 5;
            lblPassword.Text = "Password";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(333, 349);
            label1.Name = "label1";
            label1.Size = new Size(178, 20);
            label1.TabIndex = 6;
            label1.Text = "Already have an account?";
            // 
            // linkLogin
            // 
            linkLogin.AutoSize = true;
            linkLogin.Location = new Point(525, 349);
            linkLogin.Name = "linkLogin";
            linkLogin.Size = new Size(46, 20);
            linkLogin.TabIndex = 5;
            linkLogin.TabStop = true;
            linkLogin.Text = "Login";
            linkLogin.LinkClicked += linkLogin_LinkClicked;
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Location = new Point(333, 167);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(75, 20);
            lblUsername.TabIndex = 9;
            lblUsername.Text = "Username";
            // 
            // tbUsername
            // 
            tbUsername.Location = new Point(333, 191);
            tbUsername.Margin = new Padding(3, 4, 3, 4);
            tbUsername.Name = "tbUsername";
            tbUsername.Size = new Size(238, 27);
            tbUsername.TabIndex = 2;
            // 
            // SignUp
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(874, 556);
            Controls.Add(lblUsername);
            Controls.Add(tbUsername);
            Controls.Add(linkLogin);
            Controls.Add(label1);
            Controls.Add(lblPassword);
            Controls.Add(btnSignUp);
            Controls.Add(tbPassword);
            Controls.Add(title);
            Name = "SignUp";
            Text = "Form1";
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
    }
}