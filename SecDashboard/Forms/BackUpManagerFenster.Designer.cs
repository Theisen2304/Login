namespace SecDashboard
{
    partial class BackUpManagerFenster
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
            this.ListBoxBackups = new System.Windows.Forms.ListBox();
            this.BackupErstellenButton = new System.Windows.Forms.Button();
            this.ButtonBackupLoeschen = new System.Windows.Forms.Button();
            this.ButtonRestore = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ListBoxBackups
            // 
            this.ListBoxBackups.FormattingEnabled = true;
            this.ListBoxBackups.Location = new System.Drawing.Point(8, 14);
            this.ListBoxBackups.Name = "ListBoxBackups";
            this.ListBoxBackups.Size = new System.Drawing.Size(567, 225);
            this.ListBoxBackups.TabIndex = 0;
            // 
            // BackupErstellenButton
            // 
            this.BackupErstellenButton.Location = new System.Drawing.Point(245, 253);
            this.BackupErstellenButton.Name = "BackupErstellenButton";
            this.BackupErstellenButton.Size = new System.Drawing.Size(100, 50);
            this.BackupErstellenButton.TabIndex = 1;
            this.BackupErstellenButton.Text = "Backup Erstellen";
            this.BackupErstellenButton.UseVisualStyleBackColor = true;
            this.BackupErstellenButton.Click += new System.EventHandler(this.BackupErstellenButton_Click);
            // 
            // ButtonBackupLoeschen
            // 
            this.ButtonBackupLoeschen.Location = new System.Drawing.Point(475, 253);
            this.ButtonBackupLoeschen.Name = "ButtonBackupLoeschen";
            this.ButtonBackupLoeschen.Size = new System.Drawing.Size(100, 50);
            this.ButtonBackupLoeschen.TabIndex = 2;
            this.ButtonBackupLoeschen.Text = "Backup Löschen";
            this.ButtonBackupLoeschen.UseVisualStyleBackColor = true;
            this.ButtonBackupLoeschen.Click += new System.EventHandler(this.ButtonBackupLoeschen_Click);
            // 
            // ButtonRestore
            // 
            this.ButtonRestore.Location = new System.Drawing.Point(12, 253);
            this.ButtonRestore.Name = "ButtonRestore";
            this.ButtonRestore.Size = new System.Drawing.Size(100, 50);
            this.ButtonRestore.TabIndex = 5;
            this.ButtonRestore.Text = "Wiederherstellen";
            this.ButtonRestore.UseVisualStyleBackColor = true;
            this.ButtonRestore.Click += new System.EventHandler(this.ButtonRestore_Click);
            // 
            // BackUpManagerFenster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(577, 338);
            this.Controls.Add(this.ButtonRestore);
            this.Controls.Add(this.ButtonBackupLoeschen);
            this.Controls.Add(this.BackupErstellenButton);
            this.Controls.Add(this.ListBoxBackups);
            this.Name = "BackUpManagerFenster";
            this.Text = "BackUpManagerFenster";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox ListBoxBackups;
        private System.Windows.Forms.Button BackupErstellenButton;
        private System.Windows.Forms.Button ButtonBackupLoeschen;
        private System.Windows.Forms.Button ButtonRestore;
    }
}