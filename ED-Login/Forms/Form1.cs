using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
// using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Security.Cryptography;
using ED_Login.Forms;

namespace ED_Login
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;

        }
        private void TextboxEmailBenutzerEingabe_Enter(object sender, EventArgs e)
        {
            if (TextboxEmailBenutzerEingabe.Text == "example@eurodata.de")
            {

                TextboxEmailBenutzerEingabe.Font = new Font(TextboxPasswortEingabe.Font, FontStyle.Regular);
                TextboxEmailBenutzerEingabe.ForeColor = Color.Black;
                TextboxEmailBenutzerEingabe.Text = "";
            }
        }
        private void TextboxEmailBenutzerEingabe_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TextboxEmailBenutzerEingabe.Text))
            {
                TextboxEmailBenutzerEingabe.Font = new Font(TextboxPasswortEingabe.Font, FontStyle.Italic);
                TextboxEmailBenutzerEingabe.ForeColor = Color.Silver;
                TextboxEmailBenutzerEingabe.Text = "example@eurodata.de";
            }
        }
        private void TextboxPasswortEingabe_Enter(object sender, EventArgs e)
        {
            if (TextboxPasswortEingabe.Text == "Passwort")
            {
                TextboxPasswortEingabe.Font = new Font(TextboxPasswortEingabe.Font, FontStyle.Regular);
                TextboxPasswortEingabe.UseSystemPasswordChar = true;
                TextboxPasswortEingabe.ForeColor = Color.Black;
                TextboxPasswortEingabe.Text = "";
            }
        }        
        private void TextboxPasswortEingabe_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TextboxPasswortEingabe.Text))
            {

                TextboxPasswortEingabe.Font = new Font(TextboxPasswortEingabe.Font, FontStyle.Italic);
                TextboxPasswortEingabe.UseSystemPasswordChar = false;
                TextboxPasswortEingabe.ForeColor = Color.Silver;
                TextboxPasswortEingabe.Text = "Passwort";
            }
        }
        private void RedirectPasswortVergessen_MouseClick(object sender, MouseEventArgs e)
        {
            this.Hide();
            Passwortvergessen passwortvergessen = new Passwortvergessen();
            passwortvergessen.StartPosition = FormStartPosition.CenterScreen;
            passwortvergessen.Show();
        }
        private void RedirectRegistrieren_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
             this.Hide();
             Register register = new Register();
             register.StartPosition = FormStartPosition.CenterScreen;
             register.Show();
        }
        private void ButtonLogin_Click(object sender, EventArgs e)
        {
            using (StreamReader passreader = new StreamReader(Application.StartupPath + "\\Data\\" + "Benutzerdaten.csv"))
            {
                string Zeile;
                string eingegebenespasswort;
                eingegebenespasswort = HashPassword(TextboxPasswortEingabe.Text);

                while ((Zeile = passreader.ReadLine()) != null)
                {
                    string[] Data = Zeile.Split(';');
                    // Data.Length einfügen

                    if (Data.Length < 3) 
                    {
                        continue;
                    }
                    if (Data[1] == TextboxEmailBenutzerEingabe.Text && Data[3] == eingegebenespasswort || Data[2] == TextboxEmailBenutzerEingabe.Text && Data[3] == eingegebenespasswort)
                    {
                        LabelLoginErfolgreich.Visible = true;

                    }
                    if (Data[1] == TextboxEmailBenutzerEingabe.Text || Data[2] == TextboxEmailBenutzerEingabe.Text)
                    {
                        if(LabelLoginErfolgreich.Visible == true)
                        {
                            LabelPasswortfalsch.Visible = false;
                        }
                        else
                        {
                            LabelPasswortfalsch.Visible = true;
                        }
                    }
                    if (Data[3] == eingegebenespasswort)
                    {
                        if (LabelLoginErfolgreich.Visible == true)
                        {
                            LabelBenutzerEmailFalsch.Visible = false;
                        }
                        else
                        {
                            LabelBenutzerEmailFalsch.Visible = true;
                        }
                    }
                    
                }
            }
        }
        private bool TestvonEmail()
        {
            string email = TextboxEmailBenutzerEingabe.Text;
            Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            Match match = regex.Match(email);
            return match.Success;
        }
        private void TextboxEmailBenutzerEingabe_TextChanged(object sender, EventArgs e)
        {
            if (TestvonEmail() == false)
            {
                EmailNichtGültig.Visible = true;
            }
            else
            {
                EmailNichtGültig.Visible = false;
            }
            
        }
        private void ButtonBeenden_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private string HashPassword(string password)
        {
            using (SHA256 sha256Hash = SHA256.Create())
            {
                // Berechne den Hash - dies gibt Byte-Daten zurück.
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(password));

                // Konvertiere die Byte-Daten in eine Zeichenkette (hexadezimal)
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }
                return builder.ToString();
            }
        }

        //private bool StreamreaderBenutzen(string nutzername)
        //{

        //    using (StreamReader passreader = new StreamReader(Application.StartupPath + "\\Data\\" + "Benutzerdaten.csv"))
        //    {
        //        string Zeile;

        //        while ((Zeile = passreader.ReadLine()) != null)
        //        {
        //            string[] Data = Zeile.Split(';');

        //        }
        //    }


        //}

        //public string ReaderBenutzer(string input)
        //{
        //    using (StreamReader benutzerreader = new StreamReader(input))
        //    {
        //    }
        //}

        //private bool Login(string eingebenesPasswort, string gespeicherterHash)
        //{
        //    eingebenesPasswort = TextboxPasswortEingabe.Text;
        //    // Hash das eingegebene Passwort
        //    string hashVomEingegebenenPasswort = HashPassword(eingebenesPasswort);

        //    // Vergleiche den neu erstellten Hash mit dem gespeicherten Hash
        //    return hashVomEingegebenenPasswort == gespeicherterHash;
        //}
    }
}
