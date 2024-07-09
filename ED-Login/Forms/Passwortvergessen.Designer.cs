namespace ED_Login.Forms
{
    partial class Passwortvergessen
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
            this.EDLabel = new System.Windows.Forms.Label();
            this.LabelPasswortVergessen = new System.Windows.Forms.Label();
            this.LabelSicherheitsFragen = new System.Windows.Forms.Label();
            this.ComboBoxSicherheitsFragen = new System.Windows.Forms.ComboBox();
            this.TextBoxBenutzerName = new System.Windows.Forms.TextBox();
            this.LabelBenutzerName = new System.Windows.Forms.Label();
            this.TextBoxAntwort = new System.Windows.Forms.TextBox();
            this.TextBoxEmail = new System.Windows.Forms.TextBox();
            this.LabelEmail = new System.Windows.Forms.Label();
            this.LabelErkannt = new System.Windows.Forms.Label();
            this.LabelEmailUngültig = new System.Windows.Forms.Label();
            this.ButtonZurueck = new System.Windows.Forms.Button();
            this.TextBoxNeuesPasswortBestätigen = new System.Windows.Forms.TextBox();
            this.TextBoxNeuesPasswort = new System.Windows.Forms.TextBox();
            this.LabelNeuesPasswort = new System.Windows.Forms.Label();
            this.LabelNeuesPasswortBestaetigen = new System.Windows.Forms.Label();
            this.LabelGeschafft = new System.Windows.Forms.Label();
            this.ButtonSendenAntwort = new System.Windows.Forms.Button();
            this.LabelPWAnforderung = new System.Windows.Forms.Label();
            this.LabelPWÜbereinstimmung = new System.Windows.Forms.Label();
            this.ButtonÄndern = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // EDLabel
            // 
            this.EDLabel.AutoSize = true;
            this.EDLabel.Font = new System.Drawing.Font("Times New Roman", 24F);
            this.EDLabel.ForeColor = System.Drawing.Color.Red;
            this.EDLabel.Location = new System.Drawing.Point(54, 9);
            this.EDLabel.Name = "EDLabel";
            this.EDLabel.Size = new System.Drawing.Size(96, 46);
            this.EDLabel.TabIndex = 0;
            this.EDLabel.Text = ">ED";
            // 
            // LabelPasswortVergessen
            // 
            this.LabelPasswortVergessen.AutoSize = true;
            this.LabelPasswortVergessen.Font = new System.Drawing.Font("Times New Roman", 24F);
            this.LabelPasswortVergessen.ForeColor = System.Drawing.Color.Snow;
            this.LabelPasswortVergessen.Location = new System.Drawing.Point(154, 9);
            this.LabelPasswortVergessen.Name = "LabelPasswortVergessen";
            this.LabelPasswortVergessen.Size = new System.Drawing.Size(318, 46);
            this.LabelPasswortVergessen.TabIndex = 1;
            this.LabelPasswortVergessen.Text = "Passwortvergessen";
            // 
            // LabelSicherheitsFragen
            // 
            this.LabelSicherheitsFragen.AutoSize = true;
            this.LabelSicherheitsFragen.ForeColor = System.Drawing.SystemColors.Control;
            this.LabelSicherheitsFragen.Location = new System.Drawing.Point(104, 154);
            this.LabelSicherheitsFragen.Name = "LabelSicherheitsFragen";
            this.LabelSicherheitsFragen.Size = new System.Drawing.Size(111, 16);
            this.LabelSicherheitsFragen.TabIndex = 2;
            this.LabelSicherheitsFragen.Text = "Sicherheitsfragen";
            // 
            // ComboBoxSicherheitsFragen
            // 
            this.ComboBoxSicherheitsFragen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxSicherheitsFragen.Enabled = false;
            this.ComboBoxSicherheitsFragen.Font = new System.Drawing.Font("Times New Roman", 8.25F);
            this.ComboBoxSicherheitsFragen.FormattingEnabled = true;
            this.ComboBoxSicherheitsFragen.Items.AddRange(new object[] {
            "Wie hieß dein erstes Haustier?",
            "In Welcher Stadt wurdest du geboren?",
            "Welche Firma ist deine Lieblingsfirma?",
            "Wie war der Mädchenname deiner Mutter?",
            "Was ist ihre Lieblingszahl?"});
            this.ComboBoxSicherheitsFragen.Location = new System.Drawing.Point(107, 173);
            this.ComboBoxSicherheitsFragen.Name = "ComboBoxSicherheitsFragen";
            this.ComboBoxSicherheitsFragen.Size = new System.Drawing.Size(305, 24);
            this.ComboBoxSicherheitsFragen.TabIndex = 3;
            // 
            // TextBoxBenutzerName
            // 
            this.TextBoxBenutzerName.BackColor = System.Drawing.SystemColors.Window;
            this.TextBoxBenutzerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxBenutzerName.ForeColor = System.Drawing.Color.Silver;
            this.TextBoxBenutzerName.Location = new System.Drawing.Point(45, 86);
            this.TextBoxBenutzerName.Name = "TextBoxBenutzerName";
            this.TextBoxBenutzerName.Size = new System.Drawing.Size(178, 22);
            this.TextBoxBenutzerName.TabIndex = 4;
            this.TextBoxBenutzerName.Text = "e.g ma.mustermann";
            this.TextBoxBenutzerName.TextChanged += new System.EventHandler(this.TextBoxBenutzerName_TextChanged);
            this.TextBoxBenutzerName.Enter += new System.EventHandler(this.TextBoxBenutzerName_Enter);
            this.TextBoxBenutzerName.Leave += new System.EventHandler(this.TextBoxBenutzerName_Leave);
            // 
            // LabelBenutzerName
            // 
            this.LabelBenutzerName.AutoSize = true;
            this.LabelBenutzerName.ForeColor = System.Drawing.Color.Snow;
            this.LabelBenutzerName.Location = new System.Drawing.Point(45, 67);
            this.LabelBenutzerName.Name = "LabelBenutzerName";
            this.LabelBenutzerName.Size = new System.Drawing.Size(93, 16);
            this.LabelBenutzerName.TabIndex = 5;
            this.LabelBenutzerName.Text = "Benutzername";
            // 
            // TextBoxAntwort
            // 
            this.TextBoxAntwort.Location = new System.Drawing.Point(107, 203);
            this.TextBoxAntwort.Name = "TextBoxAntwort";
            this.TextBoxAntwort.Size = new System.Drawing.Size(305, 22);
            this.TextBoxAntwort.TabIndex = 6;
            // 
            // TextBoxEmail
            // 
            this.TextBoxEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxEmail.ForeColor = System.Drawing.Color.Silver;
            this.TextBoxEmail.Location = new System.Drawing.Point(298, 86);
            this.TextBoxEmail.Name = "TextBoxEmail";
            this.TextBoxEmail.Size = new System.Drawing.Size(174, 22);
            this.TextBoxEmail.TabIndex = 7;
            this.TextBoxEmail.Text = "example@eurodata.de";
            this.TextBoxEmail.TextChanged += new System.EventHandler(this.TextBoxEmail_TextChanged);
            this.TextBoxEmail.Enter += new System.EventHandler(this.TextBoxEmail_Enter);
            this.TextBoxEmail.Leave += new System.EventHandler(this.TextBoxEmail_Leave);
            // 
            // LabelEmail
            // 
            this.LabelEmail.AutoSize = true;
            this.LabelEmail.ForeColor = System.Drawing.Color.Snow;
            this.LabelEmail.Location = new System.Drawing.Point(295, 67);
            this.LabelEmail.Name = "LabelEmail";
            this.LabelEmail.Size = new System.Drawing.Size(41, 16);
            this.LabelEmail.TabIndex = 8;
            this.LabelEmail.Text = "Email";
            // 
            // LabelErkannt
            // 
            this.LabelErkannt.AutoSize = true;
            this.LabelErkannt.ForeColor = System.Drawing.Color.Lime;
            this.LabelErkannt.Location = new System.Drawing.Point(203, 134);
            this.LabelErkannt.Name = "LabelErkannt";
            this.LabelErkannt.Size = new System.Drawing.Size(106, 16);
            this.LabelErkannt.TabIndex = 9;
            this.LabelErkannt.Text = "Account Erkannt!";
            this.LabelErkannt.Visible = false;
            // 
            // LabelEmailUngültig
            // 
            this.LabelEmailUngültig.AutoSize = true;
            this.LabelEmailUngültig.ForeColor = System.Drawing.Color.Red;
            this.LabelEmailUngültig.Location = new System.Drawing.Point(304, 111);
            this.LabelEmailUngültig.Name = "LabelEmailUngültig";
            this.LabelEmailUngültig.Size = new System.Drawing.Size(97, 16);
            this.LabelEmailUngültig.TabIndex = 10;
            this.LabelEmailUngültig.Text = "E-Mail Ungültig";
            this.LabelEmailUngültig.Visible = false;
            // 
            // ButtonZurueck
            // 
            this.ButtonZurueck.Location = new System.Drawing.Point(397, 354);
            this.ButtonZurueck.Name = "ButtonZurueck";
            this.ButtonZurueck.Size = new System.Drawing.Size(75, 23);
            this.ButtonZurueck.TabIndex = 11;
            this.ButtonZurueck.Text = "Zurück";
            this.ButtonZurueck.UseVisualStyleBackColor = true;
            this.ButtonZurueck.Click += new System.EventHandler(this.ButtonZurueck_Click);
            // 
            // TextBoxNeuesPasswortBestätigen
            // 
            this.TextBoxNeuesPasswortBestätigen.Location = new System.Drawing.Point(107, 325);
            this.TextBoxNeuesPasswortBestätigen.Name = "TextBoxNeuesPasswortBestätigen";
            this.TextBoxNeuesPasswortBestätigen.Size = new System.Drawing.Size(305, 22);
            this.TextBoxNeuesPasswortBestätigen.TabIndex = 12;
            this.TextBoxNeuesPasswortBestätigen.Visible = false;
            this.TextBoxNeuesPasswortBestätigen.TextChanged += new System.EventHandler(this.TextBoxNeuesPasswortBestätigen_TextChanged);
            // 
            // TextBoxNeuesPasswort
            // 
            this.TextBoxNeuesPasswort.Location = new System.Drawing.Point(107, 282);
            this.TextBoxNeuesPasswort.Name = "TextBoxNeuesPasswort";
            this.TextBoxNeuesPasswort.Size = new System.Drawing.Size(305, 22);
            this.TextBoxNeuesPasswort.TabIndex = 13;
            this.TextBoxNeuesPasswort.Visible = false;
            this.TextBoxNeuesPasswort.TextChanged += new System.EventHandler(this.TextBoxNeuesPasswort_TextChanged);
            // 
            // LabelNeuesPasswort
            // 
            this.LabelNeuesPasswort.AutoSize = true;
            this.LabelNeuesPasswort.ForeColor = System.Drawing.SystemColors.Control;
            this.LabelNeuesPasswort.Location = new System.Drawing.Point(106, 263);
            this.LabelNeuesPasswort.Name = "LabelNeuesPasswort";
            this.LabelNeuesPasswort.Size = new System.Drawing.Size(105, 16);
            this.LabelNeuesPasswort.TabIndex = 14;
            this.LabelNeuesPasswort.Text = "Neues Passwort";
            this.LabelNeuesPasswort.Visible = false;
            // 
            // LabelNeuesPasswortBestaetigen
            // 
            this.LabelNeuesPasswortBestaetigen.AutoSize = true;
            this.LabelNeuesPasswortBestaetigen.ForeColor = System.Drawing.Color.White;
            this.LabelNeuesPasswortBestaetigen.Location = new System.Drawing.Point(106, 305);
            this.LabelNeuesPasswortBestaetigen.Name = "LabelNeuesPasswortBestaetigen";
            this.LabelNeuesPasswortBestaetigen.Size = new System.Drawing.Size(172, 16);
            this.LabelNeuesPasswortBestaetigen.TabIndex = 15;
            this.LabelNeuesPasswortBestaetigen.Text = "Neues Passwort Bestätigen";
            this.LabelNeuesPasswortBestaetigen.Visible = false;
            // 
            // LabelGeschafft
            // 
            this.LabelGeschafft.AutoSize = true;
            this.LabelGeschafft.ForeColor = System.Drawing.Color.Lime;
            this.LabelGeschafft.Location = new System.Drawing.Point(418, 203);
            this.LabelGeschafft.Name = "LabelGeschafft";
            this.LabelGeschafft.Size = new System.Drawing.Size(66, 16);
            this.LabelGeschafft.TabIndex = 16;
            this.LabelGeschafft.Text = "Geschafft!";
            this.LabelGeschafft.Visible = false;
            // 
            // ButtonSendenAntwort
            // 
            this.ButtonSendenAntwort.Location = new System.Drawing.Point(217, 231);
            this.ButtonSendenAntwort.Name = "ButtonSendenAntwort";
            this.ButtonSendenAntwort.Size = new System.Drawing.Size(75, 23);
            this.ButtonSendenAntwort.TabIndex = 17;
            this.ButtonSendenAntwort.Text = "Senden";
            this.ButtonSendenAntwort.UseVisualStyleBackColor = true;
            this.ButtonSendenAntwort.Click += new System.EventHandler(this.ButtonSendenAntwort_Click);
            // 
            // LabelPWAnforderung
            // 
            this.LabelPWAnforderung.AutoSize = true;
            this.LabelPWAnforderung.ForeColor = System.Drawing.Color.Red;
            this.LabelPWAnforderung.Location = new System.Drawing.Point(217, 263);
            this.LabelPWAnforderung.Name = "LabelPWAnforderung";
            this.LabelPWAnforderung.Size = new System.Drawing.Size(272, 16);
            this.LabelPWAnforderung.TabIndex = 18;
            this.LabelPWAnforderung.Text = "Passwort entspricht nicht den Anforderungen!";
            this.LabelPWAnforderung.Visible = false;
            // 
            // LabelPWÜbereinstimmung
            // 
            this.LabelPWÜbereinstimmung.AutoSize = true;
            this.LabelPWÜbereinstimmung.ForeColor = System.Drawing.Color.Red;
            this.LabelPWÜbereinstimmung.Location = new System.Drawing.Point(284, 306);
            this.LabelPWÜbereinstimmung.Name = "LabelPWÜbereinstimmung";
            this.LabelPWÜbereinstimmung.Size = new System.Drawing.Size(260, 20);
            this.LabelPWÜbereinstimmung.TabIndex = 19;
            this.LabelPWÜbereinstimmung.Text = "Passwörter stimmen nicht überein!";
            this.LabelPWÜbereinstimmung.Visible = false;
            // 
            // ButtonÄndern
            // 
            this.ButtonÄndern.Location = new System.Drawing.Point(220, 404);
            this.ButtonÄndern.Name = "ButtonÄndern";
            this.ButtonÄndern.Size = new System.Drawing.Size(75, 23);
            this.ButtonÄndern.TabIndex = 20;
            this.ButtonÄndern.Text = "Ändern";
            this.ButtonÄndern.UseVisualStyleBackColor = true;
            this.ButtonÄndern.Visible = false;
            this.ButtonÄndern.Click += new System.EventHandler(this.ButtonÄndern_Click);
            // 
            // Passwortvergessen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(536, 439);
            this.Controls.Add(this.ButtonÄndern);
            this.Controls.Add(this.LabelPWÜbereinstimmung);
            this.Controls.Add(this.LabelPWAnforderung);
            this.Controls.Add(this.ButtonSendenAntwort);
            this.Controls.Add(this.LabelGeschafft);
            this.Controls.Add(this.LabelNeuesPasswortBestaetigen);
            this.Controls.Add(this.LabelNeuesPasswort);
            this.Controls.Add(this.TextBoxNeuesPasswort);
            this.Controls.Add(this.TextBoxNeuesPasswortBestätigen);
            this.Controls.Add(this.ButtonZurueck);
            this.Controls.Add(this.LabelEmailUngültig);
            this.Controls.Add(this.LabelErkannt);
            this.Controls.Add(this.LabelEmail);
            this.Controls.Add(this.TextBoxEmail);
            this.Controls.Add(this.TextBoxAntwort);
            this.Controls.Add(this.LabelBenutzerName);
            this.Controls.Add(this.TextBoxBenutzerName);
            this.Controls.Add(this.ComboBoxSicherheitsFragen);
            this.Controls.Add(this.LabelSicherheitsFragen);
            this.Controls.Add(this.LabelPasswortVergessen);
            this.Controls.Add(this.EDLabel);
            this.Name = "Passwortvergessen";
            this.Text = "Passwortvergessen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label EDLabel;
        private System.Windows.Forms.Label LabelPasswortVergessen;
        private System.Windows.Forms.Label LabelSicherheitsFragen;
        private System.Windows.Forms.ComboBox ComboBoxSicherheitsFragen;
        private System.Windows.Forms.TextBox TextBoxBenutzerName;
        private System.Windows.Forms.Label LabelBenutzerName;
        private System.Windows.Forms.TextBox TextBoxAntwort;
        private System.Windows.Forms.TextBox TextBoxEmail;
        private System.Windows.Forms.Label LabelEmail;
        private System.Windows.Forms.Label LabelErkannt;
        private System.Windows.Forms.Label LabelEmailUngültig;
        private System.Windows.Forms.Button ButtonZurueck;
        private System.Windows.Forms.TextBox TextBoxNeuesPasswortBestätigen;
        private System.Windows.Forms.TextBox TextBoxNeuesPasswort;
        private System.Windows.Forms.Label LabelNeuesPasswort;
        private System.Windows.Forms.Label LabelNeuesPasswortBestaetigen;
        private System.Windows.Forms.Label LabelGeschafft;
        private System.Windows.Forms.Button ButtonSendenAntwort;
        private System.Windows.Forms.Label LabelPWAnforderung;
        private System.Windows.Forms.Label LabelPWÜbereinstimmung;
        private System.Windows.Forms.Button ButtonÄndern;
    }
}