namespace IkanLogger
{
    partial class Profile
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Profile));
            pictureBox1 = new PictureBox();
            panelProfile = new Panel();
            pictureBox2 = new PictureBox();
            tbTelp = new TextBox();
            label3 = new Label();
            tbEmail = new TextBox();
            label1 = new Label();
            tbNama = new TextBox();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panelProfile.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(165, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(133, 102);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panelProfile
            // 
            panelProfile.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panelProfile.Controls.Add(pictureBox2);
            panelProfile.Controls.Add(tbTelp);
            panelProfile.Controls.Add(label3);
            panelProfile.Controls.Add(tbEmail);
            panelProfile.Controls.Add(label1);
            panelProfile.Controls.Add(tbNama);
            panelProfile.Controls.Add(label2);
            panelProfile.Controls.Add(pictureBox1);
            panelProfile.Location = new Point(185, 71);
            panelProfile.Name = "panelProfile";
            panelProfile.Size = new Size(430, 395);
            panelProfile.TabIndex = 1;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(3, 3);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(31, 26);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 8;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // tbTelp
            // 
            tbTelp.Enabled = false;
            tbTelp.Location = new Point(74, 271);
            tbTelp.Name = "tbTelp";
            tbTelp.ReadOnly = true;
            tbTelp.Size = new Size(305, 27);
            tbTelp.TabIndex = 7;
            tbTelp.TabStop = false;
            tbTelp.Text = "000000000";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(74, 248);
            label3.Name = "label3";
            label3.Size = new Size(61, 20);
            label3.TabIndex = 6;
            label3.Text = "No Telp";
            // 
            // tbEmail
            // 
            tbEmail.Enabled = false;
            tbEmail.Location = new Point(74, 213);
            tbEmail.Name = "tbEmail";
            tbEmail.ReadOnly = true;
            tbEmail.Size = new Size(305, 27);
            tbEmail.TabIndex = 5;
            tbEmail.TabStop = false;
            tbEmail.Text = "admin@admin";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(74, 190);
            label1.Name = "label1";
            label1.Size = new Size(46, 20);
            label1.TabIndex = 4;
            label1.Text = "Email";
            // 
            // tbNama
            // 
            tbNama.Enabled = false;
            tbNama.Location = new Point(74, 156);
            tbNama.Name = "tbNama";
            tbNama.ReadOnly = true;
            tbNama.Size = new Size(305, 27);
            tbNama.TabIndex = 3;
            tbNama.TabStop = false;
            tbNama.Text = "Admin";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(74, 133);
            label2.Name = "label2";
            label2.Size = new Size(49, 20);
            label2.TabIndex = 2;
            label2.Text = "Nama";
            // 
            // Profile
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DeepSkyBlue;
            ClientSize = new Size(807, 493);
            Controls.Add(panelProfile);
            Name = "Profile";
            Text = "Profile";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panelProfile.ResumeLayout(false);
            panelProfile.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private Panel panelProfile;
        private TextBox tbTelp;
        private Label label3;
        private TextBox tbEmail;
        private Label label1;
        private TextBox tbNama;
        private Label label2;
        private PictureBox pictureBox2;
    }
}