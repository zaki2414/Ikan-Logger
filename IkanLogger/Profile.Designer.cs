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
            panelProfile = new Panel();
            backButton = new PictureBox();
            tbNama = new TextBox();
            label2 = new Label();
            panelProfile.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)backButton).BeginInit();
            SuspendLayout();
            // 
            // panelProfile
            // 
            panelProfile.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panelProfile.Controls.Add(backButton);
            panelProfile.Controls.Add(tbNama);
            panelProfile.Controls.Add(label2);
            panelProfile.Location = new Point(185, 71);
            panelProfile.Name = "panelProfile";
            panelProfile.Size = new Size(430, 395);
            panelProfile.TabIndex = 1;
            // 
            // backButton
            // 
            backButton.Image = (Image)resources.GetObject("backButton.Image");
            backButton.Location = new Point(3, 3);
            backButton.Name = "backButton";
            backButton.Size = new Size(31, 26);
            backButton.SizeMode = PictureBoxSizeMode.Zoom;
            backButton.TabIndex = 8;
            backButton.TabStop = false;
            backButton.Click += pictureBox2_Click;
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
            Load += Profile_Load;
            panelProfile.ResumeLayout(false);
            panelProfile.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)backButton).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel panelProfile;
        private TextBox tbNama;
        private Label label2;
        private PictureBox backButton;
    }
}