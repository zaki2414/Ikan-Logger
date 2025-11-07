namespace IkanLogger
{
    partial class CustomMessageBox
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
            lblText = new Label();
            btnOK = new Button();
            SuspendLayout();
            // 
            // lblText
            // 
            lblText.Anchor = AnchorStyles.Top;
            lblText.AutoSize = true;
            lblText.BackColor = Color.Transparent;
            lblText.Font = new Font("MAUIKEA Demo", 20F);
            lblText.Location = new Point(239, 68);
            lblText.Margin = new Padding(0);
            lblText.MaximumSize = new Size(600, 50);
            lblText.MinimumSize = new Size(130, 0);
            lblText.Name = "lblText";
            lblText.Size = new Size(130, 34);
            lblText.TabIndex = 0;
            lblText.Text = "label1";
            lblText.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnOK
            // 
            btnOK.BackColor = Color.Transparent;
            btnOK.Cursor = Cursors.Hand;
            btnOK.FlatAppearance.BorderSize = 0;
            btnOK.FlatStyle = FlatStyle.Flat;
            btnOK.Font = new Font("Plus Jakarta Sans", 22.7999973F, FontStyle.Bold);
            btnOK.Location = new Point(239, 208);
            btnOK.Name = "btnOK";
            btnOK.Size = new Size(115, 74);
            btnOK.TabIndex = 1;
            btnOK.Text = "OK";
            btnOK.UseVisualStyleBackColor = false;
            btnOK.Click += btnOK_Click;
            // 
            // CustomMessageBox
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(617, 353);
            Controls.Add(btnOK);
            Controls.Add(lblText);
            FormBorderStyle = FormBorderStyle.None;
            Name = "CustomMessageBox";
            Text = "CustomMessageBox";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblText;
        private Button btnOK;
    }
}