using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ED_Login.Forms
{
    public partial class Passwortvergessen : Form
    {
        public Passwortvergessen()
        {
            InitializeComponent();
            this.BackColor = ColorTranslator.FromHtml("#F2F6F7");
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

        private void TextBoxBenutzerName_Enter(object sender, EventArgs e)
        {
            if (TextBoxBenutzerName.Text == "e.g ma.mustermann")
            {
                TextBoxBenutzerName.Font = new Font(TextBoxBenutzerName.Font, FontStyle.Regular);
                TextBoxBenutzerName.ForeColor = Color.Black;
                TextBoxBenutzerName.Text = "";
            }
        }

        private void TextBoxBenutzerName_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TextBoxBenutzerName.Text))
            {
                TextBoxBenutzerName.Font = new Font(TextBoxBenutzerName.Font, FontStyle.Italic);
                TextBoxBenutzerName.ForeColor = Color.Silver;
                TextBoxBenutzerName.Text = "e.g ma.mustermann";
            }
        }
        private void TextBoxBenutzerName_TextChanged(object sender, EventArgs e)
        {
            AccountErkannt();
        }

        private void TextBoxEmail_Enter(object sender, EventArgs e)
        {
            if (TestvonEmail() == false)
            {
                LabelEmailUngültig.Visible = true;
            }
            else
            {
                LabelEmailUngültig.Visible = false;
            }
            if (TextBoxEmail.Text == "example@eurodata.de")
            {

                TextBoxEmail.Font = new Font(TextBoxEmail.Font, FontStyle.Regular);
                TextBoxEmail.ForeColor = Color.Black;
                TextBoxEmail.Text = "";
            }
        }

        private void TextBoxEmail_Leave(object sender, EventArgs e)
        {
            LabelEmailUngültig.Visible = false;
            if (string.IsNullOrWhiteSpace(TextBoxEmail.Text))
            {
                TextBoxEmail.Font = new Font(TextBoxEmail.Font, FontStyle.Italic);
                TextBoxEmail.ForeColor = Color.Silver;
                TextBoxEmail.Text = "example@eurodata.de";
            }
        }

        private void TextBoxEmail_TextChanged(object sender, EventArgs e)
        {
            if (TestvonEmail() == false)
            {
                LabelEmailUngültig.Visible = true;
            }
            else
            {
                LabelEmailUngültig.Visible = false;
            }
            AccountErkannt();
        }
        private bool TestvonEmail()
        {
            string email = TextBoxEmail.Text;
            Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,})+)$");
            Match match = regex.Match(email);
            return match.Success;
        }
        private void ButtonZurueck_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form1 = new Form1();
            form1.StartPosition = FormStartPosition.CenterScreen;
            form1.Show();
        }
        public void AccountErkannt()
        {
            using (StreamReader passreader = new StreamReader(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\CSVDATA\Benutzerdaten.csv")))
            {
                string Zeile;
                while ((Zeile = passreader.ReadLine()) != null)
                {
                    string[] Data = Zeile.Split(';');
                    // Data.Length einfügen
                    if (Data.Length <= 3)
                    {
                        continue;
                    }
                    if (Data[3] == TextBoxEmail.Text && Data[2] == TextBoxBenutzerName.Text)
                    {
                        LabelErkannt.Visible = true;
                        int nummer;
                        if (int.TryParse(Data[6], out nummer))
                        {
                            ComboBoxSicherheitsFragen.SelectedIndex = nummer;
                            if (TextBoxAntwort.Text == Data[7])
                            {
                                LabelGeschafft.Visible = true;
                                LabelNeuesPasswort.Visible = true;
                                LabelNeuesPasswortBestaetigen.Visible = true;
                                TextBoxNeuesPasswort.Visible = true;
                                TextBoxNeuesPasswortBestätigen.Visible = true;
                            }
                        }
                    }
                    else
                    {
                        LabelErkannt.Visible = false;
                        ComboBoxSicherheitsFragen.SelectedIndex = -1;
                    }
                    //bool emailEqual = Data[3].Trim() == TextBoxEmail.Text.Trim();
                    //bool usernameEqual = Data[2].Trim() == TextBoxBenutzerName.Text.Trim();
                    //Console.WriteLine($"Email-Vergleich: {emailEqual}, Benutzername-Vergleich: {usernameEqual}");
                    //Console.WriteLine("Email aus CSV: " + Data[3].Trim());
                    //Console.WriteLine("Email aus TextBox: " + TextBoxEmail.Text.Trim());
                    //Console.WriteLine("Benutzername aus CSV: " + Data[2].Trim());
                    //Console.WriteLine("Benutzername aus TextBox: " + TextBoxBenutzerName.Text.Trim());
                    //Console.WriteLine("Länge Email CSV: " + Data[3].Trim().Length);
                    //Console.WriteLine("Länge Email TextBox: " + TextBoxEmail.Text.Trim().Length);
                    //Console.WriteLine("Länge Benutzername CSV: " + Data[2].Trim().Length);
                    //Console.WriteLine("Länge Benutzername TextBox: " + TextBoxBenutzerName.Text.Trim().Length);
                }

            }
        }
        private void ButtonSendenAntwort_Click(object sender, EventArgs e)
        {
            AccountErkannt();
        }
        public bool Passwortüberprüfen()
        {
            string passwort = TextBoxNeuesPasswort.Text;
            Regex regex = new Regex(@"^(?=.*[0-9])(?=.*[!@#$%^&*])(?=.*[A-Z]).{8,}$");
            Match match = regex.Match(passwort);
            return match.Success;
        }
        private void TextBoxNeuesPasswort_TextChanged(object sender, EventArgs e)
        {
            TextBoxNeuesPasswort.UseSystemPasswordChar = true;
            if (!Passwortüberprüfen())
            {
                LabelPWAnforderung.Visible = true;
            }
            else
            {
                LabelPWAnforderung.Visible = false;
                if (TextBoxNeuesPasswort.Text != TextBoxNeuesPasswortBestätigen.Text)
                {
                    LabelPWÜbereinstimmung.Visible = true;
                    ButtonÄndern.Visible = false;
                }
                else
                {
                    LabelPWÜbereinstimmung.Visible = false;
                    ButtonÄndern.Visible = true;
                }
            }
        }
        private void TextBoxNeuesPasswortBestätigen_TextChanged(object sender, EventArgs e)
        {
            TextBoxNeuesPasswortBestätigen.UseSystemPasswordChar = true;
            if (TextBoxNeuesPasswort.Text != TextBoxNeuesPasswortBestätigen.Text)
            {
                LabelPWÜbereinstimmung.Visible = true;
                ButtonÄndern.Visible = false;
            }
            else
            {
                LabelPWÜbereinstimmung.Visible = false;
                ButtonÄndern.Visible = true;
            }
        }
        private void ButtonÄndern_Click(object sender, EventArgs e)
        {
            List<string> alleZeilen = new List<string>();
            bool AenderungGetaetigt = false;

            using (StreamReader passreader = new StreamReader("C:/Users/ma.theisen/Documents/Backup/Projekt/ED-Login/ED-Login/CSVDATA/Benutzerdaten.csv"))
            {
                string Zeile;
                while ((Zeile = passreader.ReadLine()) != null)
                {
                    string[] Data = Zeile.Split(';');

                    
                    if (Data.Length < 6) 
                    {
                        alleZeilen.Add(Zeile);
                        continue;
                    }

                    // Benutzername und E-Mail überprüfen
                    if (Data[3] == TextBoxEmail.Text && Data[1] == TextBoxBenutzerName.Text)
                    {
                        // Änderungen vornehmen falls nötig
                        Data[4] = HashPassword(TextBoxNeuesPasswort.Text);
                        Data[5] = HashPassword(TextBoxNeuesPasswortBestätigen.Text);
                        AenderungGetaetigt = true;
                        alleZeilen.Add(string.Join(";", Data)); 
                    }
                    else
                    {
                        alleZeilen.Add(Zeile);
                    }
                }
            }
            if (AenderungGetaetigt)
            {
                using (StreamWriter sw = new StreamWriter("C:/Users/ma.theisen/Documents/Backup/Projekt/ED-Login/ED-Login/CSVDATA/Benutzerdaten.csv", false)) // false überschreibt die Datei
                {
                    foreach (string zeile in alleZeilen)
                    {
                        sw.WriteLine(zeile);
                    }
                }
            }
            this.Hide();
            Form1 form1 = new Form1();
            form1.Show();
            form1.StartPosition = FormStartPosition.CenterScreen;
        }
    }
}
