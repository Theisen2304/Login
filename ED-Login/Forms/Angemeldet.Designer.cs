namespace ED_Login
{
    partial class Angemeldet
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Angemeldet));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.LogoutButton = new ED_Login.TransparentButton();
            this.LabelStatus = new System.Windows.Forms.Label();
            this.LabelWillkommen = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(231, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(327, 141);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // LogoutButton
            // 
            this.LogoutButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(127)))), ((int)(((byte)(156)))));
            this.LogoutButton.Font = new System.Drawing.Font("Roboto", 12F);
            this.LogoutButton.ForeColor = System.Drawing.Color.White;
            this.LogoutButton.Location = new System.Drawing.Point(325, 317);
            this.LogoutButton.Name = "LogoutButton";
            this.LogoutButton.Opacity = 1F;
            this.LogoutButton.Size = new System.Drawing.Size(131, 47);
            this.LogoutButton.TabIndex = 1;
            this.LogoutButton.Text = "Logout";
            this.LogoutButton.UseVisualStyleBackColor = false;
            this.LogoutButton.Click += new System.EventHandler(this.LogoutButton_Click);
            this.LogoutButton.MouseEnter += new System.EventHandler(this.LogoutButton_MouseEnter);
            this.LogoutButton.MouseLeave += new System.EventHandler(this.LogoutButton_MouseLeave);
            // 
            // LabelStatus
            // 
            this.LabelStatus.AutoSize = true;
            this.LabelStatus.BackColor = System.Drawing.Color.Transparent;
            this.LabelStatus.Font = new System.Drawing.Font("Roboto", 10F);
            this.LabelStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(115)))), ((int)(((byte)(122)))));
            this.LabelStatus.Location = new System.Drawing.Point(12, 9);
            this.LabelStatus.Name = "LabelStatus";
            this.LabelStatus.Size = new System.Drawing.Size(0, 20);
            this.LabelStatus.TabIndex = 2;
            // 
            // LabelWillkommen
            // 
            this.LabelWillkommen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.LabelWillkommen.AutoSize = true;
            this.LabelWillkommen.Font = new System.Drawing.Font("Roboto", 10F);
            this.LabelWillkommen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(115)))), ((int)(((byte)(122)))));
            this.LabelWillkommen.Location = new System.Drawing.Point(321, 169);
            this.LabelWillkommen.Name = "LabelWillkommen";
            this.LabelWillkommen.Size = new System.Drawing.Size(42, 20);
            this.LabelWillkommen.TabIndex = 3;
            this.LabelWillkommen.Text = "Test";
            this.LabelWillkommen.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Angemeldet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LabelWillkommen);
            this.Controls.Add(this.LabelStatus);
            this.Controls.Add(this.LogoutButton);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Angemeldet";
            this.Text = "Angemeldet";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private TransparentButton LogoutButton;
        private System.Windows.Forms.Label LabelStatus;
        private System.Windows.Forms.Label LabelWillkommen;
    }
}