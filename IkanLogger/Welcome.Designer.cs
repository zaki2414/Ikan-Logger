

namespace IkanLogger
{
    partial class Welcome
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
            txtJudul = new Label();
            txtSubJudul = new Label();
            txtJunPro = new Label();
            btnLogin = new Button();
            SuspendLayout();
            // 
            // txtJudul
            // 
            txtJudul.AutoSize = true;
            txtJudul.BackColor = Color.Transparent;
            txtJudul.Font = new Font("MAUIKEA Demo", 105F);
            txtJudul.Location = new Point(458, 376);
            txtJudul.Margin = new Padding(0);
            txtJudul.Name = "txtJudul";
            txtJudul.Size = new Size(1045, 175);
            txtJudul.TabIndex = 0;
            txtJudul.Tag = "txtJudul";
            txtJudul.Text = "Ikan Logger";
            // 
            // txtSubJudul
            // 
            txtSubJudul.AutoSize = true;
            txtSubJudul.BackColor = Color.Transparent;
            txtSubJudul.Font = new Font("MAUIKEA Demo", 28F);
            txtSubJudul.Location = new Point(709, 596);
            txtSubJudul.Name = "txtSubJudul";
            txtSubJudul.Size = new Size(470, 47);
            txtSubJudul.TabIndex = 1;
            txtSubJudul.Tag = "txtSubJudul";
            txtSubJudul.Text = "logs Where You Fish";
            // 
            // txtJunPro
            // 
            txtJunPro.AutoSize = true;
            txtJunPro.BackColor = Color.Transparent;
            txtJunPro.Font = new Font("MAUIKEA Demo", 14F);
            txtJunPro.Location = new Point(92, 83);
            txtJunPro.Margin = new Padding(0);
            txtJunPro.Name = "txtJunPro";
            txtJunPro.Size = new Size(179, 24);
            txtJunPro.TabIndex = 2;
            txtJunPro.Tag = "txtJunPro";
            txtJunPro.Text = "Junior Project";
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.Transparent;
            btnLogin.FlatAppearance.BorderSize = 0;
            btnLogin.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnLogin.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("MAUIKEA Demo", 37.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLogin.Location = new Point(842, 825);
            btnLogin.Margin = new Padding(0);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(239, 68);
            btnLogin.TabIndex = 3;
            btnLogin.Tag = "btnLogin";
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // Welcome
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Artboard_151;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(btnLogin);
            Controls.Add(txtJunPro);
            Controls.Add(txtSubJudul);
            Controls.Add(txtJudul);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Name = "Welcome";
            Text = "Form1";
            WindowState = FormWindowState.Maximized;
            Load += Welcome_Load;
            ResumeLayout(false);
            PerformLayout();
        }
        #endregion

        private Label txtJudul;
        private Label txtSubJudul;
        private Label txtJunPro;
        private Button btnLogin;
    }
}