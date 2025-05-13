namespace SecDashboard
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
            this.LabelStatus = new System.Windows.Forms.Label();
            this.ButtonLoginHistorie = new System.Windows.Forms.Button();
            this.dataGridViewHistorie = new System.Windows.Forms.DataGridView();
            this.ButtonZurueck = new System.Windows.Forms.Button();
            this.BackupButton = new System.Windows.Forms.Button();
            this.BackUpManagerFensterButton = new System.Windows.Forms.Button();
            this.LogoutButton = new SecDashboard.TransparentButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHistorie)).BeginInit();
            this.SuspendLayout();
            // 
            // LabelStatus
            // 
            this.LabelStatus.AutoSize = true;
            this.LabelStatus.BackColor = System.Drawing.Color.Transparent;
            this.LabelStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.LabelStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(115)))), ((int)(((byte)(122)))));
            this.LabelStatus.Location = new System.Drawing.Point(9, 7);
            this.LabelStatus.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LabelStatus.Name = "LabelStatus";
            this.LabelStatus.Size = new System.Drawing.Size(0, 17);
            this.LabelStatus.TabIndex = 2;
            // 
            // ButtonLoginHistorie
            // 
            this.ButtonLoginHistorie.Location = new System.Drawing.Point(63, 105);
            this.ButtonLoginHistorie.Name = "ButtonLoginHistorie";
            this.ButtonLoginHistorie.Size = new System.Drawing.Size(100, 92);
            this.ButtonLoginHistorie.TabIndex = 3;
            this.ButtonLoginHistorie.Text = "Zeige die Login-Historie";
            this.ButtonLoginHistorie.UseVisualStyleBackColor = true;
            this.ButtonLoginHistorie.Visible = false;
            this.ButtonLoginHistorie.Click += new System.EventHandler(this.ButtonLoginHistorie_Click);
            // 
            // dataGridViewHistorie
            // 
            this.dataGridViewHistorie.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewHistorie.Location = new System.Drawing.Point(14, 7);
            this.dataGridViewHistorie.Name = "dataGridViewHistorie";
            this.dataGridViewHistorie.Size = new System.Drawing.Size(574, 305);
            this.dataGridViewHistorie.TabIndex = 4;
            this.dataGridViewHistorie.Visible = false;
            // 
            // ButtonZurueck
            // 
            this.ButtonZurueck.Location = new System.Drawing.Point(12, 319);
            this.ButtonZurueck.Name = "ButtonZurueck";
            this.ButtonZurueck.Size = new System.Drawing.Size(100, 37);
            this.ButtonZurueck.TabIndex = 5;
            this.ButtonZurueck.Text = "Zurück";
            this.ButtonZurueck.UseVisualStyleBackColor = true;
            this.ButtonZurueck.Visible = false;
            this.ButtonZurueck.Click += new System.EventHandler(this.ButtonZurueck_Click);
            // 
            // BackupButton
            // 
            this.BackupButton.Location = new System.Drawing.Point(248, 105);
            this.BackupButton.Name = "BackupButton";
            this.BackupButton.Size = new System.Drawing.Size(98, 92);
            this.BackupButton.TabIndex = 6;
            this.BackupButton.Text = "Backup Erstellen";
            this.BackupButton.UseVisualStyleBackColor = true;
            this.BackupButton.Visible = false;
            this.BackupButton.Click += new System.EventHandler(this.BackupButton_Click);
            // 
            // BackUpManagerFensterButton
            // 
            this.BackUpManagerFensterButton.Location = new System.Drawing.Point(433, 105);
            this.BackUpManagerFensterButton.Name = "BackUpManagerFensterButton";
            this.BackUpManagerFensterButton.Size = new System.Drawing.Size(98, 92);
            this.BackUpManagerFensterButton.TabIndex = 7;
            this.BackUpManagerFensterButton.Text = "Backup Manager";
            this.BackUpManagerFensterButton.UseVisualStyleBackColor = true;
            this.BackUpManagerFensterButton.Visible = false;
            this.BackUpManagerFensterButton.Click += new System.EventHandler(this.BackUpManagerFensterButton_Click);
            // 
            // LogoutButton
            // 
            this.LogoutButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(127)))), ((int)(((byte)(156)))));
            this.LogoutButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.LogoutButton.ForeColor = System.Drawing.Color.White;
            this.LogoutButton.Location = new System.Drawing.Point(248, 317);
            this.LogoutButton.Margin = new System.Windows.Forms.Padding(2);
            this.LogoutButton.Name = "LogoutButton";
            this.LogoutButton.Opacity = 1F;
            this.LogoutButton.Size = new System.Drawing.Size(98, 38);
            this.LogoutButton.TabIndex = 1;
            this.LogoutButton.Text = "Logout";
            this.LogoutButton.UseVisualStyleBackColor = false;
            this.LogoutButton.Click += new System.EventHandler(this.LogoutButton_Click);
            this.LogoutButton.MouseEnter += new System.EventHandler(this.LogoutButton_MouseEnter);
            this.LogoutButton.MouseLeave += new System.EventHandler(this.LogoutButton_MouseLeave);
            // 
            // Angemeldet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.BackUpManagerFensterButton);
            this.Controls.Add(this.BackupButton);
            this.Controls.Add(this.ButtonZurueck);
            this.Controls.Add(this.ButtonLoginHistorie);
            this.Controls.Add(this.LabelStatus);
            this.Controls.Add(this.LogoutButton);
            this.Controls.Add(this.dataGridViewHistorie);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Angemeldet";
            this.Text = "SecDashBoard";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHistorie)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private TransparentButton LogoutButton;
        private System.Windows.Forms.Label LabelStatus;
        private System.Windows.Forms.Button ButtonLoginHistorie;
        private System.Windows.Forms.DataGridView dataGridViewHistorie;
        private System.Windows.Forms.Button ButtonZurueck;
        private System.Windows.Forms.Button BackupButton;
        private System.Windows.Forms.Button BackUpManagerFensterButton;
    }
}