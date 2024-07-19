using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ED_Login
{
    public partial class Angemeldet : Form
    {
        public Angemeldet(string benutzername, string IstAdmin)
        {
            InitializeComponent();
            this.BackColor = ColorTranslator.FromHtml("#F2F6F7");
            StartPosition = FormStartPosition.CenterScreen;
            LabelWillkommen.Text = "Willkommen, " + benutzername + "!";
            if (IstAdmin == "1")
            {
                LabelStatus.Text = "Status: Administrator";
            }
            else
            {
                LabelStatus.Text = "Status: Benutzer";
            }
        }

        private void LogoutButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form = new Form1();
            form.Show();
            form.StartPosition = FormStartPosition.CenterScreen;
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
    }
}
