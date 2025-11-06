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
        txtUserName = new Label();
        txtPassword = new Label();
        tbPassword = new TextBox();
        txtLogin = new Label();
        linkSignUp = new LinkLabel();
        txtDont = new Label();
        SuspendLayout();
        // 
        // btnLogin
        // 
        btnLogin.FlatAppearance.BorderSize = 0;
        btnLogin.FlatAppearance.MouseDownBackColor = Color.Transparent;
        btnLogin.FlatAppearance.MouseOverBackColor = Color.Transparent;
        btnLogin.FlatStyle = FlatStyle.Flat;
        btnLogin.Font = new Font("Plus Jakarta Sans", 22.7999973F, FontStyle.Bold, GraphicsUnit.Point, 0);
        btnLogin.ForeColor = SystemColors.ControlText;
        btnLogin.Location = new Point(903, 700);
        btnLogin.Margin = new Padding(0);
        btnLogin.Name = "btnLogin";
        btnLogin.Size = new Size(238, 31);
        btnLogin.TabIndex = 3;
        btnLogin.Text = "Login";
        btnLogin.UseVisualStyleBackColor = false;
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
        // txtUserName
        // 
        txtUserName.AutoSize = true;
        txtUserName.BackColor = Color.Transparent;
        txtUserName.Font = new Font("Plus Jakarta Sans Medium", 16F, FontStyle.Bold);
        txtUserName.Location = new Point(640, 364);
        txtUserName.Margin = new Padding(0);
        txtUserName.Name = "txtUserName";
        txtUserName.Size = new Size(153, 45);
        txtUserName.TabIndex = 2;
        txtUserName.Text = "Username";
        // 
        // txtPassword
        // 
        txtPassword.AutoSize = true;
        txtPassword.BackColor = Color.Transparent;
        txtPassword.Font = new Font("Plus Jakarta Sans Medium", 16.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
        txtPassword.Location = new Point(640, 524);
        txtPassword.Name = "txtPassword";
        txtPassword.Size = new Size(157, 48);
        txtPassword.TabIndex = 4;
        txtPassword.Text = "Password";
        // 
        // tbPassword
        // 
        tbPassword.Location = new Point(323, 252);
        tbPassword.Margin = new Padding(3, 4, 3, 4);
        tbPassword.Name = "tbPassword";
        tbPassword.Size = new Size(238, 27);
        tbPassword.TabIndex = 2;
        tbPassword.UseSystemPasswordChar = true;
        // 
        // txtLogin
        // 
        txtLogin.AutoSize = true;
        txtLogin.BackColor = Color.Transparent;
        txtLogin.Font = new Font("MAUIKEA Demo", 33.6F);
        txtLogin.Location = new Point(875, 257);
        txtLogin.Margin = new Padding(0);
        txtLogin.Name = "txtLogin";
        txtLogin.Size = new Size(165, 56);
        txtLogin.TabIndex = 5;
        txtLogin.Text = "Login";
        // 
        // linkSignUp
        // 
        linkSignUp.AutoSize = true;
        linkSignUp.BackColor = Color.Transparent;
        linkSignUp.Font = new Font("Plus Jakarta Sans", 16.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
        linkSignUp.Location = new Point(504, 347);
        linkSignUp.Name = "linkSignUp";
        linkSignUp.Size = new Size(127, 48);
        linkSignUp.TabIndex = 4;
        linkSignUp.TabStop = true;
        linkSignUp.Text = "Sign Up";
        linkSignUp.LinkClicked += linkSignUp_LinkClicked;
        // 
        // txtDont
        // 
        txtDont.AutoSize = true;
        txtDont.BackColor = Color.Transparent;
        txtDont.Font = new Font("Plus Jakarta Sans Medium", 16.8F, FontStyle.Bold);
        txtDont.Location = new Point(755, 787);
        txtDont.Margin = new Padding(0);
        txtDont.Name = "txtDont";
        txtDont.Size = new Size(330, 46);
        txtDont.TabIndex = 7;
        txtDont.Text = "Don't have an account?";
        // 
        // Login
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        BackgroundImage = Properties.Resources.Artboard_153;
        BackgroundImageLayout = ImageLayout.Stretch;
        ClientSize = new Size(914, 600);
        Controls.Add(txtDont);
        Controls.Add(linkSignUp);
        Controls.Add(txtLogin);
        Controls.Add(txtPassword);
        Controls.Add(tbPassword);
        Controls.Add(txtUserName);
        Controls.Add(tbUsername);
        Controls.Add(btnLogin);
        DoubleBuffered = true;
        FormBorderStyle = FormBorderStyle.None;
        Margin = new Padding(3, 4, 3, 4);
        Name = "Login";
        Text = "Form1";
        WindowState = FormWindowState.Maximized;
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Button btnLogin;
    private TextBox tbUsername;
    private Label txtUserName;
    private Label txtPassword;
    private TextBox tbPassword;
    private Label title;
    private LinkLabel linkSignUp;
    private Label txtDont;
    private Label txtLogin;
}
