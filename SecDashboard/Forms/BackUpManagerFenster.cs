using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SecDashboard
{
    public partial class BackUpManagerFenster : Form
    {
        private string backupOrdner = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"../../Backups/LHDATA/");

        public BackUpManagerFenster()
        {
            InitializeComponent();
            LadeBackups();
        }

        private void LadeBackups()
        {
            ListBoxBackups.Items.Clear();

            if (!Directory.Exists(backupOrdner))
                Directory.CreateDirectory(backupOrdner);

            var dateien = Directory.GetFiles(backupOrdner, "*.enc");
            foreach (var datei in dateien)
            {
                ListBoxBackups.Items.Add(Path.GetFileName(datei));
            }
        }

        private void btnBackupLöschen_Click(object sender, EventArgs e)
        {
            if (ListBoxBackups.SelectedItem == null)
            {
                MessageBox.Show("Bitte eine Datei auswählen.");
                return;
            }

            var datei = Path.Combine(backupOrdner, ListBoxBackups.SelectedItem.ToString());

            if (File.Exists(datei))
            {
                File.Delete(datei);
                LadeBackups();
                MessageBox.Show("Backup gelöscht.");
            }
        }

        private void btnZurück_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BackupErstellenButton_Click(object sender, EventArgs e)
        {
            try
            {
                BackupManager.BackupLoginHistory();
                LadeBackups();
                MessageBox.Show("Backup erfolgreich erstellt.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Fehler beim Backup: {ex.Message}");
            }
        }

        private void ButtonBackupLoeschen_Click(object sender, EventArgs e)
        {
            if (ListBoxBackups.SelectedItem == null)
            {
                MessageBox.Show("Bitte eine Datei auswählen.");
                return;
            }

            var datei = Path.Combine(backupOrdner, ListBoxBackups.SelectedItem.ToString());

            if (File.Exists(datei))
            {
                File.Delete(datei);
                LadeBackups();
                MessageBox.Show("Backup gelöscht.");
            }
        }

        private void ButtonRestore_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog()) 
            {
                openFileDialog.Filter = "Backup-Dateien (*.enc|*.enc";
                openFileDialog.Title = "Backup auswählen";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string selectedBackup = openFileDialog.FileName;
                    string restorepath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"../../login_history.sqlite");


                    try
                    {
                        BackupManager.DecryptFileAndRestore(selectedBackup, restorepath);
                        MessageBox.Show("Backup erfolgreich wiederhergestellt");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Fehler bei der Wiederherstellung " + ex.Message, "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}
