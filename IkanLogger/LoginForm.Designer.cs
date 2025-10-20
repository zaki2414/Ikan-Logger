namespace IkanLogger;

partial class LoginForm
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
        SuspendLayout();
        // 
        // btnLogin
        // 
        btnLogin.ForeColor = SystemColors.ControlText;
        btnLogin.Location = new Point(342, 271);
        btnLogin.Name = "btnLogin";
        btnLogin.Size = new Size(75, 23);
        btnLogin.TabIndex = 0;
        btnLogin.Text = "Login";
        btnLogin.UseVisualStyleBackColor = true;
        btnLogin.Click += btnLogin_Click;
        // 
        // tbUsername
        // 
        tbUsername.Location = new Point(283, 175);
        tbUsername.Name = "tbUsername";
        tbUsername.Size = new Size(209, 23);
        tbUsername.TabIndex = 1;
        // 
        // lblUserName
        // 
        lblUserName.AutoSize = true;
        lblUserName.Location = new Point(283, 157);
        lblUserName.Name = "lblUserName";
        lblUserName.Size = new Size(60, 15);
        lblUserName.TabIndex = 2;
        lblUserName.Text = "Username";
        // 
        // lblPassword
        // 
        lblPassword.AutoSize = true;
        lblPassword.Location = new Point(283, 208);
        lblPassword.Name = "lblPassword";
        lblPassword.Size = new Size(57, 15);
        lblPassword.TabIndex = 4;
        lblPassword.Text = "Password";
        // 
        // tbPassword
        // 
        tbPassword.Location = new Point(283, 226);
        tbPassword.Name = "tbPassword";
        tbPassword.Size = new Size(209, 23);
        tbPassword.TabIndex = 3;
        tbPassword.UseSystemPasswordChar = true;
        // 
        // Login
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(800, 450);
        Controls.Add(lblPassword);
        Controls.Add(tbPassword);
        Controls.Add(lblUserName);
        Controls.Add(tbUsername);
        Controls.Add(btnLogin);
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
}
