using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SecDashboard.Forms;
using SecDashboard;
using System.Data.SQLite;

namespace SecDashboard
{
    public partial class Angemeldet : Form
    {
        public Angemeldet(string benutzername, string IstAdmin)
        {
            InitializeComponent();
            this.BackColor = ColorTranslator.FromHtml("#F2F6F7");
            StartPosition = FormStartPosition.CenterScreen;
            //LabelWillkommen.Text = "Willkommen, " + benutzername + "!";
            if (IstAdmin == "1")
            {
                LabelStatus.Text = "Status: Administrator";
            }
            else
            {
                LabelStatus.Text = "Status: Benutzer";
            }
            if (IstAdmin == "1")
            {
                ButtonLoginHistorie.Visible = true;
                BackupButton.Visible = true;
                BackUpManagerFensterButton.Visible = true;
            }

        }

        private void LogoutButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login form = new Login();
            form.ShowDialog();
            form.StartPosition = FormStartPosition.CenterScreen;
            this.Close();
        }

        private void LogoutButton_MouseEnter(object sender, EventArgs e)
        {
            LogoutButton.BackColor = ColorTranslator.FromHtml("#00718A");
        }

        private void LogoutButton_MouseLeave(object sender, EventArgs e)
        {
            LogoutButton.BackColor = ColorTranslator.FromHtml("#007F9C");
        }
        public void IstBenutzerAdmin(string benutzername)
        {

        }

        private void ButtonLoginHistorie_Click(object sender, EventArgs e)
        {
            dataGridViewHistorie.Visible = true;
            ButtonZurueck.Visible = true;
            ButtonLoginHistorie.Visible = false;
            LabelStatus.Visible = false;
            BackUpManagerFensterButton.Visible = false;
            BackupButton.Visible = false;

            LadeLoginHistorie();
        }

        private void ButtonZurueck_Click(object sender, EventArgs e)
        {
            dataGridViewHistorie.Visible = false;
            ButtonZurueck.Visible = false;
            ButtonLoginHistorie.Visible = true;
            LabelStatus.Visible = true;
            BackUpManagerFensterButton.Visible = true;
            BackupButton.Visible = true;
        }
        private void LadeLoginHistorie()
        {
            var table = new DataTable();
            using (var connection = new SQLiteConnection(DatenBankManager.ConnectionString))
            {
                connection.Open();
                string query = "SELECT Username, Timestamp, Status FROM LoginHistory";
                using (var adapter = new SQLiteDataAdapter(query, connection))
                {
                    adapter.Fill(table);
                }
            }

            dataGridViewHistorie.DataSource = table;
        }

        private void BackupButton_Click(object sender, EventArgs e)
        {
            try
            {
                BackupManager.BackupAll();
                MessageBox.Show("Backup erfolgreich erstellt.", "Erfolg", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Fehler beim Erstellen des Backups:\n" + ex.Message, "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BackUpManagerFensterButton_Click(object sender, EventArgs e)
        {
            BackUpManagerFenster backUpManagerFenster = new BackUpManagerFenster();
            backUpManagerFenster.ShowDialog();
        }
    }
}
