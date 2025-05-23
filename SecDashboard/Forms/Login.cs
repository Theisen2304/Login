﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Security.Cryptography;
using SecDashboard.Forms;
using SecDashboard;

namespace SecDashboard
{
    public partial class Login : Form
    {
        public bool IstEMailFokussiert;
        public bool IstPWFokussiert;

        private const FormStartPosition centerScreen = FormStartPosition.CenterScreen;

        public Login()
        {
            InitializeComponent();
            StartPosition = centerScreen;
            this.BackColor = ColorTranslator.FromHtml("#F2F6F7");
        }
        private void TextboxEmailBenutzerEingabe_Enter(object sender, EventArgs e)
        {
                TextboxEmailBenutzerEingabe.Font = new Font(TextboxPasswortEingabe.Font, FontStyle.Regular);
                TextboxEmailBenutzerEingabe.ForeColor = ColorTranslator.FromHtml("#3D494D");
                TextboxEmailBenutzerEingabe.Text = "";
        }
        private void TextboxPasswortEingabe_Enter(object sender, EventArgs e)
        {
                TextboxPasswortEingabe.Font = new Font(TextboxPasswortEingabe.Font, FontStyle.Regular);
                TextboxPasswortEingabe.UseSystemPasswordChar = true;
                TextboxPasswortEingabe.ForeColor = ColorTranslator.FromHtml("#3D494D");
                TextboxPasswortEingabe.Text = "";
        }

        //private void TextboxEmailBenutzerEingabe_Enter(object sender, EventArgs e)
        //{
        //    IstEMailFokussiert = true;
        //    if (TextboxEmailBenutzerEingabe.Text == "example@eurodata.de")
        //    {

        //        TextboxEmailBenutzerEingabe.Font = new Font(TextboxPasswortEingabe.Font, FontStyle.Regular);
        //        TextboxEmailBenutzerEingabe.ForeColor = ColorTranslator.FromHtml("#3D494D");
        //        TextboxEmailBenutzerEingabe.Text = "";
        //    }
        //    TextboxEmailBenutzerEingabe.BackColor = ColorTranslator.FromHtml("#DEE4E8");
        //}
        //private void TextboxEmailBenutzerEingabe_Leave(object sender, EventArgs e)
        //{
        //    if (string.IsNullOrWhiteSpace(TextboxEmailBenutzerEingabe.Text))
        //    {
        //        TextboxEmailBenutzerEingabe.Font = new Font(TextboxPasswortEingabe.Font, FontStyle.Italic);
        //        TextboxEmailBenutzerEingabe.ForeColor = ColorTranslator.FromHtml("#688B99");
        //        TextboxEmailBenutzerEingabe.Text = "example@eurodata.de";
        //    }
        //    TextboxEmailBenutzerEingabe.BackColor = Color.White;
        //    IstEMailFokussiert = false;

        //}
        //private void TextboxPasswortEingabe_Enter(object sender, EventArgs e)
        //{
        //    IstPWFokussiert = true;
        //    if (TextboxPasswortEingabe.Text == "Passwort")
        //    {
        //        TextboxPasswortEingabe.Font = new Font(TextboxPasswortEingabe.Font, FontStyle.Regular);
        //        TextboxPasswortEingabe.UseSystemPasswordChar = true;
        //        TextboxPasswortEingabe.ForeColor = ColorTranslator.FromHtml("#3D494D");
        //        TextboxPasswortEingabe.Text = "";
        //    }
        //}        
        //private void TextboxPasswortEingabe_Leave(object sender, EventArgs e)
        //{
        //    if (string.IsNullOrWhiteSpace(TextboxPasswortEingabe.Text))
        //    {

        //        TextboxPasswortEingabe.Font = new Font(TextboxPasswortEingabe.Font, FontStyle.Italic);
        //        TextboxPasswortEingabe.UseSystemPasswordChar = false;
        //        TextboxPasswortEingabe.ForeColor = ColorTranslator.FromHtml("#688B99");
        //        TextboxPasswortEingabe.Text = "Passwort";
        //    }
        //    TextboxPasswortEingabe.BackColor = Color.White;
        //    IstPWFokussiert = false;
        //}
        private void RedirectPasswortVergessen_MouseClick(object sender, MouseEventArgs e)
        {
            this.Hide();
            Passwortvergessen passwortvergessen = new Passwortvergessen();
            passwortvergessen.StartPosition = centerScreen;
            passwortvergessen.ShowDialog();
            this.Close();
        }
        private void RedirectRegistrieren_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
             this.Hide();
             Register register = new Register();
             register.StartPosition = centerScreen;
             register.ShowDialog();
             this.Close();
        }
        //private void ButtonLogin_Click(object sender, EventArgs e)
        //{
        //    using (StreamReader passreader = new StreamReader(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\CSVDATA\Benutzerdaten.csv")))
        //    {
        //        string Zeile;
        //        string eingegebenespasswort;
        //        eingegebenespasswort = HashPassword(TextboxPasswortEingabe.Text);

        //        while ((Zeile = passreader.ReadLine()) != null)
        //        {
        //            string[] Data = Zeile.Split(';');
        //            // Data.Length einfügen

        //            if (Data.Length < 3) 
        //            {
        //                continue;
        //            }
        //            if (Data[2] == TextboxEmailBenutzerEingabe.Text && Data[4] == eingegebenespasswort || Data[3] == TextboxEmailBenutzerEingabe.Text && Data[4] == eingegebenespasswort)
        //            {
        //                LabelLoginErfolgreich.Visible = true;

        //            }
        //            if (Data[2] == TextboxEmailBenutzerEingabe.Text || Data[3] == TextboxEmailBenutzerEingabe.Text)
        //            {
        //                if(LabelLoginErfolgreich.Visible == true)
        //                {
        //                    LabelPasswortfalsch.Visible = false;
        //                }
        //                else
        //                {
        //                    LabelPasswortfalsch.Visible = true;
        //                }
        //            }
        //            if (Data[4] == eingegebenespasswort)
        //            {
        //                if (LabelLoginErfolgreich.Visible == true)
        //                {
        //                    LabelBenutzerEmailFalsch.Visible = false;
        //                }
        //                else
        //                {
        //                    LabelBenutzerEmailFalsch.Visible = true;
        //                }
        //            }

        //            if (LabelLoginErfolgreich.Visible == true)
        //            {
        //                this.Hide();
        //                Angemeldet angemeldet = new Angemeldet(TextboxEmailBenutzerEingabe.Text);
        //                angemeldet.Show();
        //                angemeldet.StartPosition = centerScreen;
        //            }
                    
        //        }
        //    }
        //}
        //public void Login(string username, string password)
        //{
        //    if (IsLoginSuccessful(username, password))
        //    {
        //        SaveLastLoggedInUser(username);
        //        // Weiterer Code für erfolgreichen Login
        //    }
        //}
        private string HashPassword(string password)
        {
            using (SHA256 sha256Hash = SHA256.Create())
            {
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(password));

                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }
                return builder.ToString();
            }
        }


        private void TextboxEmailBenutzerEingabe_MouseLeave(object sender, EventArgs e)
        {
            if (IstEMailFokussiert == true)
            {
                TextboxEmailBenutzerEingabe.BackColor = ColorTranslator.FromHtml("#DEE4E8");
            }
            else
            {
                TextboxEmailBenutzerEingabe.BackColor = Color.White;
            }
            IstButtonAktiv();
        }

        private void TextboxEmailBenutzerEingabe_MouseEnter(object sender, EventArgs e)
        {
            TextboxEmailBenutzerEingabe.BackColor = ColorTranslator.FromHtml("#E4E9EC");
        }

        private void TextboxPasswortEingabe_MouseEnter(object sender, EventArgs e)
        {
            TextboxPasswortEingabe.BackColor = ColorTranslator.FromHtml("#E4E9EC");
        }

        private void TextboxPasswortEingabe_MouseLeave(object sender, EventArgs e)
        {
            if (IstPWFokussiert == true)
            {
                TextboxPasswortEingabe.BackColor = ColorTranslator.FromHtml("#DEE4E8");
            }
            else
            {
                TextboxPasswortEingabe.BackColor = Color.White;
            }
            IstButtonAktiv();
        }

        public void IstButtonAktiv()
        {
            if (string.IsNullOrWhiteSpace(TextboxEmailBenutzerEingabe.Text) || string.IsNullOrWhiteSpace(TextboxPasswortEingabe.Text))
            {
                NeuerLoginButton.Opacity = 0.35f;
            }
            else
            {
                NeuerLoginButton.Opacity = 1f;
            }
        }

        private void NeuerLoginButton_Click(object sender, EventArgs e)
        {
            using (StreamReader passreader = new StreamReader(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\CSVDATA\Benutzerdaten.csv")))
            {
                string Zeile;
                string eingegebenespasswort;
                eingegebenespasswort = HashPassword(TextboxPasswortEingabe.Text);

                while ((Zeile = passreader.ReadLine()) != null)
                {
                    string[] Data = Zeile.Split(';');                   

                    if (Data.Length < 3)
                    {
                        continue;
                    }
                    if (Data[2] == TextboxEmailBenutzerEingabe.Text && Data[4] == eingegebenespasswort || Data[3] == TextboxEmailBenutzerEingabe.Text && Data[4] == eingegebenespasswort)
                    {
                        LabelLoginErfolgreich.Visible = true;

                    }
                    if (Data[2] == TextboxEmailBenutzerEingabe.Text || Data[3] == TextboxEmailBenutzerEingabe.Text)
                    {
                        if (LabelLoginErfolgreich.Visible == true)
                        { 
                            LabelPasswortfalsch.Visible = false;
                        }
                        else
                        {

                            LabelPasswortfalsch.Visible = true;
                        }
                    }
                    if (Data[4] == eingegebenespasswort)
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

                    if (LabelLoginErfolgreich.Visible == true)
                    {
                        string benutzername = Data[2];
                        string status = Data[8];
                        DatenBankManager.AddLoginEntry(Data[2], Data[8]);
                        BackupManager.BackupAll();
                            this.Hide();
                            Angemeldet angemeldet = new Angemeldet(benutzername, status);
                            angemeldet.ShowDialog();
                            angemeldet.StartPosition = centerScreen;
                            this.Close();
                    }

                }
            }
        }

        private void NeuerLoginButton_MouseEnter(object sender, EventArgs e)
        {
            NeuerLoginButton.BackColor = ColorTranslator.FromHtml("#00718A");
        }

        private void NeuerLoginButton_MouseLeave(object sender, EventArgs e)
        {
            NeuerLoginButton.BackColor = ColorTranslator.FromHtml("#007F9C");
        }

        private void TextboxEmailBenutzerEingabe_Leave(object sender, EventArgs e)
        {
            IstButtonAktiv();
        }

        private void TextboxPasswortEingabe_Leave(object sender, EventArgs e)
        {
            IstButtonAktiv();
        }

        private void TextboxEmailBenutzerEingabe_TextChanged(object sender, EventArgs e)
        {
            IstButtonAktiv();
        }

        private void TextboxPasswortEingabe_TextChanged(object sender, EventArgs e)
        {
            IstButtonAktiv();
        }
    }
}
