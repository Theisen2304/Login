﻿using System.Drawing;

namespace ED_Login
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.ButtonLogin = new System.Windows.Forms.Button();
            this.labeled1temp = new System.Windows.Forms.Label();
            this.labellogin2temp = new System.Windows.Forms.Label();
            this.TextboxEmailBenutzerEingabe = new System.Windows.Forms.TextBox();
            this.TextboxPasswortEingabe = new System.Windows.Forms.TextBox();
            this.LabelEmailOderBenutzerName = new System.Windows.Forms.Label();
            this.LabelPasswort = new System.Windows.Forms.Label();
            this.LabelKeinKonto = new System.Windows.Forms.Label();
            this.RedirectRegistrieren = new System.Windows.Forms.LinkLabel();
            this.RedirectPasswortVergessen = new System.Windows.Forms.LinkLabel();
            this.ButtonBeenden = new System.Windows.Forms.Button();
            this.LabelLoginErfolgreich = new System.Windows.Forms.Label();
            this.LabelBenutzerEmailFalsch = new System.Windows.Forms.Label();
            this.LabelPasswortfalsch = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ButtonLogin
            // 
            this.ButtonLogin.Location = new System.Drawing.Point(356, 327);
            this.ButtonLogin.Name = "ButtonLogin";
            this.ButtonLogin.Size = new System.Drawing.Size(75, 25);
            this.ButtonLogin.TabIndex = 0;
            this.ButtonLogin.Text = "Login";
            this.ButtonLogin.UseVisualStyleBackColor = true;
            this.ButtonLogin.Click += new System.EventHandler(this.ButtonLogin_Click);
            // 
            // labeled1temp
            // 
            this.labeled1temp.AutoSize = true;
            this.labeled1temp.BackColor = System.Drawing.Color.Transparent;
            this.labeled1temp.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeled1temp.ForeColor = System.Drawing.Color.Red;
            this.labeled1temp.Location = new System.Drawing.Point(268, 46);
            this.labeled1temp.Name = "labeled1temp";
            this.labeled1temp.Size = new System.Drawing.Size(96, 46);
            this.labeled1temp.TabIndex = 3;
            this.labeled1temp.Text = ">ED";
            // 
            // labellogin2temp
            // 
            this.labellogin2temp.AutoSize = true;
            this.labellogin2temp.BackColor = System.Drawing.Color.Transparent;
            this.labellogin2temp.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labellogin2temp.ForeColor = System.Drawing.Color.Transparent;
            this.labellogin2temp.Location = new System.Drawing.Point(361, 46);
            this.labellogin2temp.Name = "labellogin2temp";
            this.labellogin2temp.Size = new System.Drawing.Size(143, 46);
            this.labellogin2temp.TabIndex = 4;
            this.labellogin2temp.Text = "LOGIN";
            this.labellogin2temp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TextboxEmailBenutzerEingabe
            // 
            this.TextboxEmailBenutzerEingabe.BackColor = System.Drawing.Color.White;
            this.TextboxEmailBenutzerEingabe.CausesValidation = false;
            this.TextboxEmailBenutzerEingabe.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextboxEmailBenutzerEingabe.ForeColor = ColorTranslator.FromHtml("#688B99");
            this.TextboxEmailBenutzerEingabe.Location = new System.Drawing.Point(293, 146);
            this.TextboxEmailBenutzerEingabe.Name = "TextboxEmailBenutzerEingabe";
            this.TextboxEmailBenutzerEingabe.Size = new System.Drawing.Size(199, 22);
            this.TextboxEmailBenutzerEingabe.TabIndex = 5;
            this.TextboxEmailBenutzerEingabe.Text = "example@eurodata.de";
            this.TextboxEmailBenutzerEingabe.Enter += new System.EventHandler(this.TextboxEmailBenutzerEingabe_Enter);
            this.TextboxEmailBenutzerEingabe.Leave += new System.EventHandler(this.TextboxEmailBenutzerEingabe_Leave);
            // 
            // TextboxPasswortEingabe
            // 
            this.TextboxPasswortEingabe.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextboxPasswortEingabe.ForeColor = ColorTranslator.FromHtml("#688B99");
            this.TextboxPasswortEingabe.Location = new System.Drawing.Point(293, 210);
            this.TextboxPasswortEingabe.Name = "TextboxPasswortEingabe";
            this.TextboxPasswortEingabe.Size = new System.Drawing.Size(199, 22);
            this.TextboxPasswortEingabe.TabIndex = 6;
            this.TextboxPasswortEingabe.Text = "Passwort";
            this.TextboxPasswortEingabe.Enter += new System.EventHandler(this.TextboxPasswortEingabe_Enter);
            this.TextboxPasswortEingabe.Leave += new System.EventHandler(this.TextboxPasswortEingabe_Leave);
            // 
            // LabelEmailOderBenutzerName
            // 
            this.LabelEmailOderBenutzerName.AutoSize = true;
            this.LabelEmailOderBenutzerName.ForeColor = ColorTranslator.FromHtml("#5E737A");
            this.LabelEmailOderBenutzerName.Location = new System.Drawing.Point(290, 127);
            this.LabelEmailOderBenutzerName.Name = "LabelEmailOderBenutzerName";
            this.LabelEmailOderBenutzerName.Size = new System.Drawing.Size(165, 16);
            this.LabelEmailOderBenutzerName.TabIndex = 7;
            this.LabelEmailOderBenutzerName.Text = "E-Mail oder Benutzername";
            // 
            // LabelPasswort
            // 
            this.LabelPasswort.AutoSize = true;
            this.LabelPasswort.ForeColor = ColorTranslator.FromHtml("#5E737A");
            this.LabelPasswort.Location = new System.Drawing.Point(290, 191);
            this.LabelPasswort.Name = "LabelPasswort";
            this.LabelPasswort.Size = new System.Drawing.Size(62, 16);
            this.LabelPasswort.TabIndex = 8;
            this.LabelPasswort.Text = "Passwort";
            // 
            // LabelKeinKonto
            // 
            this.LabelKeinKonto.AutoSize = true;
            this.LabelKeinKonto.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelKeinKonto.ForeColor = ColorTranslator.FromHtml("#5E737A");
            this.LabelKeinKonto.Location = new System.Drawing.Point(388, 235);
            this.LabelKeinKonto.Name = "LabelKeinKonto";
            this.LabelKeinKonto.Size = new System.Drawing.Size(104, 15);
            this.LabelKeinKonto.TabIndex = 9;
            this.LabelKeinKonto.Text = "Noch kein Konto?";
            // 
            // RedirectRegistrieren
            // 
            this.RedirectRegistrieren.AutoSize = true;
            this.RedirectRegistrieren.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RedirectRegistrieren.LinkColor = ColorTranslator.FromHtml("#007F9C");
            this.RedirectRegistrieren.Location = new System.Drawing.Point(388, 250);
            this.RedirectRegistrieren.Name = "RedirectRegistrieren";
            this.RedirectRegistrieren.Size = new System.Drawing.Size(100, 15);
            this.RedirectRegistrieren.TabIndex = 10;
            this.RedirectRegistrieren.TabStop = true;
            this.RedirectRegistrieren.Text = "Jetzt registrieren!";
            this.RedirectRegistrieren.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.RedirectRegistrieren.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.RedirectRegistrieren_LinkClicked);
            // 
            // RedirectPasswortVergessen
            // 
            this.RedirectPasswortVergessen.AutoSize = true;
            this.RedirectPasswortVergessen.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RedirectPasswortVergessen.LinkColor = ColorTranslator.FromHtml("#007F9C");
            this.RedirectPasswortVergessen.Location = new System.Drawing.Point(303, 235);
            this.RedirectPasswortVergessen.Name = "RedirectPasswortVergessen";
            this.RedirectPasswortVergessen.Size = new System.Drawing.Size(70, 30);
            this.RedirectPasswortVergessen.TabIndex = 11;
            this.RedirectPasswortVergessen.TabStop = true;
            this.RedirectPasswortVergessen.Text = "Passwort \r\nvergessen?";
            this.RedirectPasswortVergessen.MouseClick += new System.Windows.Forms.MouseEventHandler(this.RedirectPasswortVergessen_MouseClick);
            // 
            // ButtonBeenden
            // 
            this.ButtonBeenden.Location = new System.Drawing.Point(700, 414);
            this.ButtonBeenden.Name = "ButtonBeenden";
            this.ButtonBeenden.Size = new System.Drawing.Size(88, 24);
            this.ButtonBeenden.TabIndex = 13;
            this.ButtonBeenden.Text = "Beenden";
            this.ButtonBeenden.UseVisualStyleBackColor = true;
            this.ButtonBeenden.Click += new System.EventHandler(this.ButtonBeenden_Click);
            // 
            // LabelLoginErfolgreich
            // 
            this.LabelLoginErfolgreich.AutoSize = true;
            this.LabelLoginErfolgreich.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelLoginErfolgreich.ForeColor = ColorTranslator.FromHtml("#5E737A");
            this.LabelLoginErfolgreich.Location = new System.Drawing.Point(246, 367);
            this.LabelLoginErfolgreich.Name = "LabelLoginErfolgreich";
            this.LabelLoginErfolgreich.Size = new System.Drawing.Size(311, 46);
            this.LabelLoginErfolgreich.TabIndex = 14;
            this.LabelLoginErfolgreich.Text = "Login Erfolgreich!";
            this.LabelLoginErfolgreich.Visible = false;
            // 
            // LabelBenutzerEmailFalsch
            // 
            this.LabelBenutzerEmailFalsch.AutoSize = true;
            this.LabelBenutzerEmailFalsch.ForeColor = System.Drawing.Color.Red;
            this.LabelBenutzerEmailFalsch.Location = new System.Drawing.Point(498, 149);
            this.LabelBenutzerEmailFalsch.Name = "LabelBenutzerEmailFalsch";
            this.LabelBenutzerEmailFalsch.Size = new System.Drawing.Size(165, 16);
            this.LabelBenutzerEmailFalsch.TabIndex = 15;
            this.LabelBenutzerEmailFalsch.Text = "Benutzer oder Email falsch";
            this.LabelBenutzerEmailFalsch.Visible = false;
            // 
            // LabelPasswortfalsch
            // 
            this.LabelPasswortfalsch.AutoSize = true;
            this.LabelPasswortfalsch.ForeColor = System.Drawing.Color.Red;
            this.LabelPasswortfalsch.Location = new System.Drawing.Point(498, 213);
            this.LabelPasswortfalsch.Name = "LabelPasswortfalsch";
            this.LabelPasswortfalsch.Size = new System.Drawing.Size(108, 16);
            this.LabelPasswortfalsch.TabIndex = 16;
            this.LabelPasswortfalsch.Text = "Passwort Falsch!";
            this.LabelPasswortfalsch.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LabelPasswortfalsch);
            this.Controls.Add(this.LabelBenutzerEmailFalsch);
            this.Controls.Add(this.LabelLoginErfolgreich);
            this.Controls.Add(this.ButtonBeenden);
            this.Controls.Add(this.RedirectPasswortVergessen);
            this.Controls.Add(this.RedirectRegistrieren);
            this.Controls.Add(this.LabelKeinKonto);
            this.Controls.Add(this.LabelPasswort);
            this.Controls.Add(this.LabelEmailOderBenutzerName);
            this.Controls.Add(this.TextboxPasswortEingabe);
            this.Controls.Add(this.TextboxEmailBenutzerEingabe);
            this.Controls.Add(this.labellogin2temp);
            this.Controls.Add(this.labeled1temp);
            this.Controls.Add(this.ButtonLogin);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ButtonLogin;
        private System.Windows.Forms.Label labeled1temp;
        private System.Windows.Forms.Label labellogin2temp;
        private System.Windows.Forms.TextBox TextboxEmailBenutzerEingabe;
        private System.Windows.Forms.TextBox TextboxPasswortEingabe;
        private System.Windows.Forms.Label LabelEmailOderBenutzerName;
        private System.Windows.Forms.Label LabelPasswort;
        private System.Windows.Forms.Label LabelKeinKonto;
        private System.Windows.Forms.LinkLabel RedirectRegistrieren;
        private System.Windows.Forms.LinkLabel RedirectPasswortVergessen;
        private System.Windows.Forms.Button ButtonBeenden;
        private System.Windows.Forms.Label LabelLoginErfolgreich;
        private System.Windows.Forms.Label LabelBenutzerEmailFalsch;
        private System.Windows.Forms.Label LabelPasswortfalsch;
    }
}

