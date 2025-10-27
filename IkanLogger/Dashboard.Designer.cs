namespace IkanLogger
{
    partial class Dashboard
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            picMap = new PictureBox();
            panel1 = new Panel();
            navbar = new Panel();
            profileBtn = new Button();
            logBtn = new Button();
            homeBtn = new Button();
            title = new Label();
            ikan2 = new Button();
            ikan1 = new Button();
            infoPanel = new Panel();
            label5 = new Label();
            logPanel = new Panel();
            addLogBtn = new Button();
            log3 = new Label();
            log2 = new Label();
            log1 = new Label();
            label1 = new Label();
            toolTip1 = new ToolTip(components);
            ((System.ComponentModel.ISupportInitialize)picMap).BeginInit();
            panel1.SuspendLayout();
            navbar.SuspendLayout();
            infoPanel.SuspendLayout();
            logPanel.SuspendLayout();
            SuspendLayout();
            // 
            // picMap
            // 
            picMap.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            picMap.BackColor = Color.Transparent;
            picMap.BackgroundImage = (Image)resources.GetObject("picMap.BackgroundImage");
            picMap.BackgroundImageLayout = ImageLayout.Zoom;
            picMap.Location = new Point(0, 0);
            picMap.Name = "picMap";
            picMap.Size = new Size(1116, 527);
            picMap.SizeMode = PictureBoxSizeMode.AutoSize;
            picMap.TabIndex = 0;
            picMap.TabStop = false;
            // 
            // panel1
            // 
            panel1.Controls.Add(navbar);
            panel1.Controls.Add(ikan2);
            panel1.Controls.Add(ikan1);
            panel1.Controls.Add(infoPanel);
            panel1.Controls.Add(logPanel);
            panel1.Controls.Add(picMap);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1116, 527);
            panel1.TabIndex = 1;
            // 
            // navbar
            // 
            navbar.BackColor = Color.SkyBlue;
            navbar.BorderStyle = BorderStyle.FixedSingle;
            navbar.Controls.Add(profileBtn);
            navbar.Controls.Add(logBtn);
            navbar.Controls.Add(homeBtn);
            navbar.Controls.Add(title);
            navbar.Dock = DockStyle.Top;
            navbar.Location = new Point(0, 0);
            navbar.Name = "navbar";
            navbar.Size = new Size(1116, 50);
            navbar.TabIndex = 7;
            // 
            // profileBtn
            // 
            profileBtn.BackColor = Color.Transparent;
            profileBtn.BackgroundImage = (Image)resources.GetObject("profileBtn.BackgroundImage");
            profileBtn.BackgroundImageLayout = ImageLayout.Zoom;
            profileBtn.FlatAppearance.BorderSize = 0;
            profileBtn.FlatStyle = FlatStyle.Flat;
            profileBtn.Location = new Point(1043, 5);
            profileBtn.Name = "profileBtn";
            profileBtn.Size = new Size(43, 39);
            profileBtn.TabIndex = 10;
            profileBtn.UseVisualStyleBackColor = false;
            profileBtn.Click += profileBtn_Click;
            // 
            // logBtn
            // 
            logBtn.BackColor = Color.Transparent;
            logBtn.BackgroundImageLayout = ImageLayout.None;
            logBtn.FlatAppearance.BorderSize = 0;
            logBtn.FlatStyle = FlatStyle.Flat;
            logBtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            logBtn.Location = new Point(924, 10);
            logBtn.Name = "logBtn";
            logBtn.Size = new Size(94, 29);
            logBtn.TabIndex = 9;
            logBtn.Text = "Log";
            logBtn.UseVisualStyleBackColor = false;
            // 
            // homeBtn
            // 
            homeBtn.BackColor = Color.SkyBlue;
            homeBtn.BackgroundImageLayout = ImageLayout.None;
            homeBtn.FlatAppearance.BorderSize = 0;
            homeBtn.FlatStyle = FlatStyle.Flat;
            homeBtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            homeBtn.Location = new Point(824, 11);
            homeBtn.Name = "homeBtn";
            homeBtn.Size = new Size(94, 29);
            homeBtn.TabIndex = 8;
            homeBtn.Text = "Home";
            homeBtn.UseVisualStyleBackColor = false;
            // 
            // title
            // 
            title.AutoSize = true;
            title.BackColor = Color.Transparent;
            title.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            title.Location = new Point(11, 8);
            title.Name = "title";
            title.Size = new Size(123, 28);
            title.TabIndex = 8;
            title.Text = "Ikan Logger";
            // 
            // ikan2
            // 
            ikan2.BackColor = Color.Gray;
            ikan2.FlatStyle = FlatStyle.Flat;
            ikan2.Location = new Point(363, 247);
            ikan2.Name = "ikan2";
            ikan2.Size = new Size(15, 39);
            ikan2.TabIndex = 6;
            toolTip1.SetToolTip(ikan2, "Hiu Putih \r\n");
            ikan2.UseVisualStyleBackColor = false;
            // 
            // ikan1
            // 
            ikan1.BackColor = Color.Yellow;
            ikan1.FlatStyle = FlatStyle.Flat;
            ikan1.Location = new Point(557, 340);
            ikan1.Name = "ikan1";
            ikan1.Size = new Size(15, 39);
            ikan1.TabIndex = 2;
            toolTip1.SetToolTip(ikan1, "Ikan Bandeng \r\n");
            ikan1.UseVisualStyleBackColor = false;
            // 
            // infoPanel
            // 
            infoPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            infoPanel.BorderStyle = BorderStyle.FixedSingle;
            infoPanel.Controls.Add(label5);
            infoPanel.Location = new Point(0, 64);
            infoPanel.Name = "infoPanel";
            infoPanel.Size = new Size(259, 174);
            infoPanel.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(0, 0);
            label5.Name = "label5";
            label5.Size = new Size(206, 100);
            label5.TabIndex = 0;
            label5.Text = "🌦️ Cuaca Hari Ini: Cerah 29°C\r\n🐟 Harga Ikan Saat Ini:\r\n  -- Tongkol: Rp 32.000/kg\r\n -- Bandeng: Rp 50.000/kg\r\n🌊 Kondisi Laut: Tenang";
            // 
            // logPanel
            // 
            logPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            logPanel.AutoScroll = true;
            logPanel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            logPanel.BorderStyle = BorderStyle.FixedSingle;
            logPanel.Controls.Add(addLogBtn);
            logPanel.Controls.Add(log3);
            logPanel.Controls.Add(log2);
            logPanel.Controls.Add(log1);
            logPanel.Controls.Add(label1);
            logPanel.Location = new Point(880, 56);
            logPanel.Name = "logPanel";
            logPanel.Size = new Size(236, 323);
            logPanel.TabIndex = 0;
            // 
            // addLogBtn
            // 
            addLogBtn.Dock = DockStyle.Bottom;
            addLogBtn.Location = new Point(0, 292);
            addLogBtn.Name = "addLogBtn";
            addLogBtn.Size = new Size(234, 29);
            addLogBtn.TabIndex = 4;
            addLogBtn.Text = "+ Tambah";
            addLogBtn.UseVisualStyleBackColor = true;
            // 
            // log3
            // 
            log3.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            log3.AutoSize = true;
            log3.BackColor = Color.White;
            log3.BorderStyle = BorderStyle.FixedSingle;
            log3.Font = new Font("Segoe UI", 11F);
            log3.Location = new Point(17, 190);
            log3.Name = "log3";
            log3.Size = new Size(208, 77);
            log3.TabIndex = 3;
            log3.Text = "Senin, 20 Oktober 2025\r\n-- Patin : 10 Kg\r\n-- Bandeng : 100 Kg\r\n";
            log3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // log2
            // 
            log2.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            log2.AutoSize = true;
            log2.BackColor = Color.White;
            log2.BorderStyle = BorderStyle.FixedSingle;
            log2.Font = new Font("Segoe UI", 11F);
            log2.Location = new Point(17, 113);
            log2.Name = "log2";
            log2.Size = new Size(208, 77);
            log2.TabIndex = 2;
            log2.Text = "Senin, 20 Oktober 2025\r\n-- Patin : 10 Kg\r\n-- Bandeng : 100 Kg\r\n";
            log2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // log1
            // 
            log1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            log1.AutoSize = true;
            log1.BackColor = Color.White;
            log1.BorderStyle = BorderStyle.FixedSingle;
            log1.Font = new Font("Segoe UI", 11F);
            log1.Location = new Point(17, 36);
            log1.Name = "log1";
            log1.Size = new Size(208, 77);
            log1.TabIndex = 1;
            log1.Text = "Senin, 20 Oktober 2025\r\n-- Patin : 10 Kg\r\n-- Bandeng : 100 Kg\r\n";
            log1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(44, 8);
            label1.Name = "label1";
            label1.Size = new Size(152, 28);
            label1.TabIndex = 0;
            label1.Text = "Catatan Terakhir";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1116, 527);
            Controls.Add(panel1);
            Name = "Dashboard";
            Text = "Dashboard";
            ((System.ComponentModel.ISupportInitialize)picMap).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            navbar.ResumeLayout(false);
            navbar.PerformLayout();
            infoPanel.ResumeLayout(false);
            infoPanel.PerformLayout();
            logPanel.ResumeLayout(false);
            logPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox picMap;
        private Panel panel1;
        private Panel logPanel;
        private Label label1;
        private Button addLogBtn;
        private Label log3;
        private Label log2;
        private Label log1;
        private Panel infoPanel;
        private Label label5;
        private Button ikan1;
        private ToolTip toolTip1;
        private Button ikan2;
        private Panel navbar;
        private Button homeBtn;
        private Label title;
        private Button profileBtn;
        private Button logBtn;
    }
}