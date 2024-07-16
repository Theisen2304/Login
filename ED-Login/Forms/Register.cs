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
using System.Text.RegularExpressions;
using System.Security.Cryptography;
using Svg.Skia;
using SkiaSharp;
using System.Xml.Linq;
using static System.Net.WebRequestMethods;

namespace ED_Login
{
    public partial class Register : Form
    {
        public Register()
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
        //private void Registrieren_Click(object sender, EventArgs e)
        //{
        //    int nextId = GetNextId();
        //    bool istAdmin = false; // Beispielsweise
        //    bool istAktiv = false;
        //    bool zuletztangemeldet = false;

        //    if (TextBoxBenutzername.Text == "Administrator")
        //    {
        //        istAdmin = true;
        //    }

        //    string gehashtesPasswort = HashPassword(TextBoxPasswort.Text);
        //    string gehashtesPasswortbestaetigen = HashPassword(TextBoxPasswortbestaetigen.Text);

        //    StreamWriter sw = new StreamWriter(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\CSVDATA\Benutzerdaten.csv"), true);
        //    string neuezeile = nextId + ";" + TextBoxName.Text + ";" + TextBoxBenutzername.Text + ";" + TextBoxEmail.Text + ";" + gehashtesPasswort + ";" + gehashtesPasswortbestaetigen + ";"
        //        + ComboBoxFragen.SelectedIndex + ";" + TextBoxSicherheitsfrage.Text + ";" + (istAdmin ? "1" : "0") + ";" + (istAktiv ? "1" : "0") + ";" + (zuletztangemeldet ? "1" : "0") + ";";
        //    sw.WriteLine(neuezeile);
        //    sw.Close();
        //    this.Hide();
        //    Form1 form = new Form1();
        //    form.Show();
        //}
        private void OpacityButton_Click(object sender, EventArgs e)
        {
            
            {
                int nextId = GetNextId();
                bool istAdmin = false; // Beispielsweise
                bool istAktiv = false;
                bool zuletztangemeldet = false;

                if (TextBoxBenutzername.Text == "Administrator")
                {
                   istAdmin = true;
                }

                string gehashtesPasswort = HashPassword(TextBoxPasswort.Text);
                string gehashtesPasswortbestaetigen = HashPassword(TextBoxPasswortbestaetigen.Text);

                StreamWriter sw = new StreamWriter(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\CSVDATA\Benutzerdaten.csv"), true);
                string neuezeile = nextId + ";" + TextBoxName.Text + ";" + TextBoxBenutzername.Text + ";" + TextBoxEmail.Text + ";" + gehashtesPasswort + ";" + gehashtesPasswortbestaetigen + ";"
                   + ComboBoxFragen.SelectedIndex + ";" + TextBoxSicherheitsfrage.Text + ";" + (istAdmin ? "1" : "0") + ";" + (istAktiv ? "1" : "0") + ";" + (zuletztangemeldet ? "1" : "0") + ";";
                sw.WriteLine(neuezeile);
                sw.Close();
                this.Hide();
                Form1 form = new Form1();
                form.Show();
            }
        }
        private int GetNextId()
        {
            string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\CSVDATA\Benutzerdaten.csv");
            string lastLine = System.IO.File.ReadLines(filePath).LastOrDefault();

            if (!string.IsNullOrEmpty(lastLine))
            {
                string[] data = lastLine.Split(';');

                if (int.TryParse(data[0].Trim(), out int id))
                {
                    return id + 1; 
                }
                else
                {                 
                    Console.WriteLine("Die erste Spalte enthält keine gültige Ganzzahl: " + data[0]);
                }
            }

            return 1; 
        }
        //private void TextBoxEmail_Enter(object sender, EventArgs e)
        //{
        //    if (TextBoxEmail.Text == "example@eurodata.de")
        //    {

        //        TextBoxEmail.Font = new Font(TextBoxEmail.Font, FontStyle.Regular);
        //        TextBoxEmail.ForeColor = Color.Black;
        //        TextBoxEmail.Text = "";
        //    }
        //}
        //private void TextBoxEmail_Leave(object sender, EventArgs e)
        //{
        //    if (string.IsNullOrWhiteSpace(TextBoxEmail.Text))
        //    {
        //        TextBoxEmail.Font = new Font(TextBoxEmail.Font, FontStyle.Italic);
        //        TextBoxEmail.ForeColor = Color.Silver;
        //        TextBoxEmail.Text = "example@eurodata.de";
        //    }
        //    Registrierenbuttonüberprüfen();
        //}
        //private void TextBoxName_Enter(object sender, EventArgs e)
        //{
        //    if (TextBoxName.Text == "Max Mustermann")
        //    {
        //        TextBoxName.Font = new Font(TextBoxName.Font, FontStyle.Regular);
        //        TextBoxName.ForeColor = Color.Black;
        //        TextBoxName.Text = "";
        //    }
        //}
        //private void TextBoxName_Leave(object sender, EventArgs e)
        //{
        //    if(string.IsNullOrWhiteSpace(TextBoxName.Text))
        //    {
        //        TextBoxName.Font = new Font (TextBoxName.Font, FontStyle.Italic);
        //        TextBoxName.ForeColor = Color.Silver;
        //        TextBoxName.Text = "Max Mustermann";
        //    }
        //    Registrierenbuttonüberprüfen();

        //}
        //private void TextBoxBenutzername_Enter(object sender, EventArgs e)
        //{
        //    if (TextBoxBenutzername.Text == "e.g ma.mustermann")
        //    {
        //        TextBoxBenutzername.Font = new Font(TextBoxBenutzername.Font, FontStyle.Regular);
        //        TextBoxBenutzername.ForeColor = Color.Black;
        //        TextBoxBenutzername.Text = "";
        //    }
        //}
        //private void TextBoxBenutzername_Leave(object sender, EventArgs e)
        //{
        //    if (string.IsNullOrWhiteSpace(TextBoxBenutzername.Text))
        //    {
        //        TextBoxBenutzername.Font = new Font(TextBoxBenutzername.Font, FontStyle.Italic);
        //        TextBoxBenutzername.ForeColor = Color.Silver;
        //        TextBoxBenutzername.Text = "e.g ma.mustermann";
        //    }
        //    Registrierenbuttonüberprüfen();
        //}
        //private void TextBoxPasswort_Enter(object sender, EventArgs e)
        //{
        //    if (TextBoxPasswort.Text == "Passwort")
        //    {
        //        TextBoxPasswort.Font = new Font(TextBoxPasswort.Font, FontStyle.Regular);
        //        TextBoxPasswort.UseSystemPasswordChar = true;
        //        TextBoxPasswort.ForeColor = Color.Black;
        //        TextBoxPasswort.Text = "";
        //    }
        //}
        //private void TextBoxPasswort_Leave(object sender, EventArgs e)
        //{
        //    if (string.IsNullOrWhiteSpace(TextBoxPasswort.Text))
        //    {
        //        TextBoxPasswort.Font = new Font(TextBoxPasswort.Font, FontStyle.Italic);
        //        TextBoxPasswort.UseSystemPasswordChar = false;
        //        TextBoxPasswort.ForeColor = Color.Silver;
        //        TextBoxPasswort.Text = "Passwort";
        //    }
        //    Registrierenbuttonüberprüfen();
        //}
        //private void TextBoxPasswortbestaetigen_Enter(object sender, EventArgs e)
        //{
        //    if (TextBoxPasswortbestaetigen.Text == "Passwort")
        //    {
        //        TextBoxPasswortbestaetigen.Font = new Font(TextBoxPasswortbestaetigen.Font, FontStyle.Regular);
        //        TextBoxPasswortbestaetigen.UseSystemPasswordChar = true;
        //        TextBoxPasswortbestaetigen.ForeColor = Color.Black;
        //        TextBoxPasswortbestaetigen.Text = "";
        //    }

        //}
        //private void TextBoxPasswortbestaetigen_Leave(object sender, EventArgs e)
        //{
        //    if (string.IsNullOrWhiteSpace(TextBoxPasswortbestaetigen.Text))
        //    {
        //        TextBoxPasswortbestaetigen.Font = new Font(TextBoxPasswortbestaetigen.Font, FontStyle.Italic);
        //        TextBoxPasswortbestaetigen.UseSystemPasswordChar = false;
        //        TextBoxPasswortbestaetigen.ForeColor = Color.Silver;
        //        TextBoxPasswortbestaetigen.Text = "Passwort";
        //    }
        //    Registrierenbuttonüberprüfen();
        //}
        //private void TextBoxSicherheitsfrage_Enter(object sender, EventArgs e)
        //{
        //    if (TextBoxSicherheitsfrage.Text == "Antwort")
        //    {
        //        TextBoxSicherheitsfrage.Font = new Font(TextBoxSicherheitsfrage.Font, FontStyle.Regular);
        //        TextBoxSicherheitsfrage.ForeColor = Color.Black;
        //        TextBoxSicherheitsfrage.Text = "";
        //    }
        //    Registrierenbuttonüberprüfen();
        //}
        //private void TextBoxSicherheitsfrage_Leave(object sender, EventArgs e)
        //{
        //    if (string.IsNullOrWhiteSpace(TextBoxSicherheitsfrage.Text))
        //    {
        //        TextBoxSicherheitsfrage.Font = new Font(TextBoxSicherheitsfrage.Font, FontStyle.Italic);
        //        TextBoxSicherheitsfrage.ForeColor = Color.Silver;
        //        TextBoxSicherheitsfrage.Text = "Antwort";
        //    }
        //    Registrierenbuttonüberprüfen();
        //}
        private void ButtonBeenden_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void ButtonZurueck_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form1 = new Form1();
            form1.StartPosition = FormStartPosition.CenterScreen;
            form1.Show();
        }
        public bool Passwortüberprüfen()
        {
            string passwort = TextBoxPasswort.Text;
            Regex regex = new Regex(@"^(?=.*[0-9])(?=.*[!@#$%^&*])(?=.*[A-Z]).{8,}$");
            Match match = regex.Match(passwort);
            return match.Success;
        }
        private void TextBoxPasswort_TextChanged(object sender, EventArgs e)
        {
            if (!Passwortüberprüfen()) // vereinfachte Bedingung
            {
                LabelPasswortAnforderungen.Visible = true;
            }
            else
            {
                LabelPasswortAnforderungen.Visible = false;
            }
        }
        private bool TestvonEmail()
        {
            string email = TextBoxEmail.Text;
            Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,})+)$");
            Match match = regex.Match(email);
            return match.Success;
        }
        private void TextboxEmailBenutzerEingabe_TextChanged(object sender, EventArgs e)
        {
            if (TestvonEmail() == false)
            {
                LabelEmailUngültig.Visible = true;
            }
            else
            {
                if(TextBoxEmail.Text == "example@eurodata.de")
                {
                    LabelEmailUngültig.Visible = true;
                }
                else
                {
                    LabelEmailUngültig.Visible = false;
                }
            }
            StreamreaderBereitsvergeben(TextBoxEmail.Text);

        }
        private void TextBoxPasswortbestaetigen_TextChanged(object sender, EventArgs e)
        {
            if (TextBoxPasswortbestaetigen.Text != TextBoxPasswort.Text)
            {
                LabelPasswortStimmtnichtüberein.Visible = true;
            }
            else
            {
                LabelPasswortStimmtnichtüberein.Visible = false;
            }
        }

        private bool StreamreaderBereitsvergeben(string nutzername)
        {
            try
            {

                using (StreamReader passreader = new StreamReader(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\CSVDATA\Benutzerdaten.csv")))
                {
                    string Zeile;

                    LabelBereitsVergeben.Visible = false;
                    LabelBenutzerbereitsvergeben.Visible = false;

                    while ((Zeile = passreader.ReadLine()) != null)
                    {
                        string[] Data = Zeile.Split(';');

                        if (Data.Length < 3)
                        {
                            return false;
                        }
                        else if (Data[2] == TextBoxEmail.Text)
                        {
                            LabelBereitsVergeben.Visible = true;
                        }
                        if (Data[1] == TextBoxBenutzername.Text)
                        {
                            LabelBenutzerbereitsvergeben.Visible = true;
                        }
                    }
                    return true;
                }
            }
            catch
            {
                Console.WriteLine("Es gab einen Fehler beim Öffnen der Datei: ");
                return false;
            }


        }

        private void TextBoxBenutzername_TextChanged(object sender, EventArgs e)
        {
            StreamreaderBereitsvergeben(TextBoxBenutzername.Text);
            Registrierenbuttonüberprüfen();
        }
        public void Registrierenbuttonüberprüfen()
        {
            if (TextBoxName.Text != "" && LabelBenutzerbereitsvergeben.Visible == false && LabelBereitsVergeben.Visible == false && LabelEmailUngültig.Visible == false && LabelPasswortAnforderungen.Visible == false && LabelPasswortStimmtnichtüberein.Visible == false && ComboBoxFragen.SelectedIndex != -1 && TextBoxSicherheitsfrage.Text != "" && checkBoxDatenschutz.Checked == true)
            {
                OpacityRegistrierenButton.Enabled = true;
                OpacityRegistrierenButton.Opacity = 1f;
                OpacityRegistrierenButton.Update();
            }
            else
            {
                OpacityRegistrierenButton.Enabled = false;
                OpacityRegistrierenButton.Opacity = 0.35f;
            }
        }
        private void ComboBoxFragen_SelectedIndexChanged(object sender, EventArgs e)
        {
            Registrierenbuttonüberprüfen();
        }
        private void CheckBoxDatenschutz_CheckedChanged(object sender, EventArgs e)
        {
            Registrierenbuttonüberprüfen();
        }

        private void OpacityRegistrierenButton_MouseEnter(object sender, EventArgs e)
        {
            if (OpacityRegistrierenButton.Enabled == true)
            {
                OpacityRegistrierenButton.BackColor = ColorTranslator.FromHtml("#00718A");
            }
            else
            {
                OpacityRegistrierenButton.BackColor = ColorTranslator.FromHtml("#007F9C");
            }
            
        }

        private void OpacityRegistrierenButton_MouseLeave(object sender, EventArgs e)
        {
            OpacityRegistrierenButton.BackColor = ColorTranslator.FromHtml("#007F9C");
        }

        private void TextBoxName_MouseEnter(object sender, EventArgs e)
        {
            TextBoxName.BackColor = ColorTranslator.FromHtml("#E4E9EC");
        }
        private void TextBoxName_MouseLeave(object sender, EventArgs e)
        {
            TextBoxName.BackColor = Color.White;
        }
        private void TextBoxBenutzername_MouseEnter(object sender, EventArgs e)
        {
            TextBoxBenutzername.BackColor = ColorTranslator.FromHtml("#E4E9EC");
        }
        private void TextBoxBenutzername_MouseLeave(object sender, EventArgs e)
        {
            TextBoxBenutzername.BackColor = Color.White;
        }
        private void TextBoxEmail_MouseEnter(object sender, EventArgs e)
        {
            TextBoxEmail.BackColor = ColorTranslator.FromHtml("#E4E9EC");
        }
        private void TextBoxEmail_MouseLeave(object sender, EventArgs e)
        {
            TextBoxEmail.BackColor = Color.White;
        }
        private void TextBoxPasswort_MouseEnter(object sender, EventArgs e)
        {
            TextBoxPasswort.BackColor = ColorTranslator.FromHtml("#E4E9EC");
        }
        private void TextBoxPasswort_MouseLeave(object sender, EventArgs e)
        {
            TextBoxPasswort.BackColor = Color.White;
        }
        private void TextBoxPasswortbestaetigen_MouseEnter(object sender, EventArgs e)
        {
            TextBoxPasswortbestaetigen.BackColor = ColorTranslator.FromHtml("#E4E9EC");
        }
        private void TextBoxPasswortbestaetigen_MouseLeave(object sender, EventArgs e)
        {
            TextBoxPasswortbestaetigen.BackColor = Color.White;
        }
        private void TextBoxSicherheitsfrage_MouseEnter(object sender, EventArgs e)
        {
            TextBoxSicherheitsfrage.BackColor = ColorTranslator.FromHtml("#E4E9EC");
        }
        private void TextBoxSicherheitsfrage_MouseLeave(object sender, EventArgs e)
        {
            TextBoxSicherheitsfrage.BackColor = Color.White;
        }




        //private void ButtonRegistrieren_EnabledChanged(object sender, EventArgs e)
        //{
        //    if (LabelBenutzerbereitsvergeben.Visible == false || LabelBereitsVergeben.Visible == false || LabelEmailUngültig.Visible == false || LabelPasswortAnforderungen.Visible == false || LabelPasswortStimmtnichtüberein.Visible == false)
        //    {
        //        ButtonRegistrieren.ForeColor = Color.Black;
        //    }
        //    else
        //    {
        //        ButtonRegistrieren.Enabled = false;
        //    }
        //}
    }
}
