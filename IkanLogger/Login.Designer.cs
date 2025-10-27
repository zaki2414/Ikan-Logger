namespace IkanLogger;

partial class Login
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
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
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        btnLogin = new Button();
        tbUsername = new TextBox();
        lblUserName = new Label();
        lblPassword = new Label();
        tbPassword = new TextBox();
        title = new Label();
        linkSignUp = new LinkLabel();
        label1 = new Label();
        SuspendLayout();
        // 
        // btnLogin
        // 
        btnLogin.ForeColor = SystemColors.ControlText;
        btnLogin.Location = new Point(323, 303);
        btnLogin.Margin = new Padding(3, 4, 3, 4);
        btnLogin.Name = "btnLogin";
        btnLogin.Size = new Size(238, 31);
        btnLogin.TabIndex = 0;
        btnLogin.Text = "Login";
        btnLogin.UseVisualStyleBackColor = true;
        btnLogin.Click += btnLogin_Click;
        // 
        // tbUsername
        // 
        tbUsername.Location = new Point(323, 184);
        tbUsername.Margin = new Padding(3, 4, 3, 4);
        tbUsername.Name = "tbUsername";
        tbUsername.Size = new Size(238, 27);
        tbUsername.TabIndex = 1;
        // 
        // lblUserName
        // 
        lblUserName.AutoSize = true;
        lblUserName.Location = new Point(323, 160);
        lblUserName.Name = "lblUserName";
        lblUserName.Size = new Size(75, 20);
        lblUserName.TabIndex = 2;
        lblUserName.Text = "Username";
        // 
        // lblPassword
        // 
        lblPassword.AutoSize = true;
        lblPassword.Location = new Point(323, 228);
        lblPassword.Name = "lblPassword";
        lblPassword.Size = new Size(70, 20);
        lblPassword.TabIndex = 4;
        lblPassword.Text = "Password";
        // 
        // tbPassword
        // 
        tbPassword.Location = new Point(323, 252);
        tbPassword.Margin = new Padding(3, 4, 3, 4);
        tbPassword.Name = "tbPassword";
        tbPassword.Size = new Size(238, 27);
        tbPassword.TabIndex = 3;
        tbPassword.UseSystemPasswordChar = true;
        // 
        // title
        // 
        title.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        title.AutoSize = true;
        title.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
        title.Location = new Point(382, 84);
        title.Name = "title";
        title.Size = new Size(120, 50);
        title.TabIndex = 5;
        title.Text = "Login";
        // 
        // linkSignUp
        // 
        linkSignUp.AutoSize = true;
        linkSignUp.Location = new Point(504, 347);
        linkSignUp.Name = "linkSignUp";
        linkSignUp.Size = new Size(61, 20);
        linkSignUp.TabIndex = 6;
        linkSignUp.TabStop = true;
        linkSignUp.Text = "Sign Up";
        linkSignUp.LinkClicked += linkSignUp_LinkClicked;
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Location = new Point(323, 347);
        label1.Name = "label1";
        label1.Size = new Size(163, 20);
        label1.TabIndex = 7;
        label1.Text = "Don't have an account?";
        // 
        // Login
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(914, 600);
        Controls.Add(label1);
        Controls.Add(linkSignUp);
        Controls.Add(title);
        Controls.Add(lblPassword);
        Controls.Add(tbPassword);
        Controls.Add(lblUserName);
        Controls.Add(tbUsername);
        Controls.Add(btnLogin);
        Margin = new Padding(3, 4, 3, 4);
        Name = "Login";
        Text = "Form1";
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Button btnLogin;
    private TextBox tbUsername;
    private Label lblUserName;
    private Label lblPassword;
    private TextBox tbPassword;
    private Label title;
    private LinkLabel linkSignUp;
    private Label label1;
}
