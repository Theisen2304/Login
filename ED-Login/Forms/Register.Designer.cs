namespace ED_Login
{
    partial class Register
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
            this.LabelED = new System.Windows.Forms.Label();
            this.labelregistrieren = new System.Windows.Forms.Label();
            this.TextBoxPasswort = new System.Windows.Forms.TextBox();
            this.TextBoxEmail = new System.Windows.Forms.TextBox();
            this.TextBoxBenutzername = new System.Windows.Forms.TextBox();
            this.TextBoxName = new System.Windows.Forms.TextBox();
            this.TextBoxPasswortbestaetigen = new System.Windows.Forms.TextBox();
            this.LabelName = new System.Windows.Forms.Label();
            this.checkBoxDatenschutz = new System.Windows.Forms.CheckBox();
            this.LabelBenutzername = new System.Windows.Forms.Label();
            this.ButtonRegistrieren = new System.Windows.Forms.Button();
            this.LabelEmail = new System.Windows.Forms.Label();
            this.LabelPasswort = new System.Windows.Forms.Label();
            this.LabelPasswortBestaetigen = new System.Windows.Forms.Label();
            this.LabelSicherheitsfrage = new System.Windows.Forms.Label();
            this.ComboBoxFragen = new System.Windows.Forms.ComboBox();
            this.TextBoxSicherheitsfrage = new System.Windows.Forms.TextBox();
            this.ButtonBeenden = new System.Windows.Forms.Button();
            this.ButtonZurueck = new System.Windows.Forms.Button();
            this.LabelPasswortAnforderungen = new System.Windows.Forms.Label();
            this.LabelPasswortStimmtnichtüberein = new System.Windows.Forms.Label();
            this.LabelEmailUngültig = new System.Windows.Forms.Label();
            this.LabelBereitsVergeben = new System.Windows.Forms.Label();
            this.LabelBenutzerbereitsvergeben = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LabelED
            // 
            this.LabelED.AutoSize = true;
            this.LabelED.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelED.ForeColor = System.Drawing.Color.Red;
            this.LabelED.Location = new System.Drawing.Point(250, 9);
            this.LabelED.Name = "LabelED";
            this.LabelED.Size = new System.Drawing.Size(96, 46);
            this.LabelED.TabIndex = 0;
            this.LabelED.Text = ">ED";
            // 
            // labelregistrieren
            // 
            this.labelregistrieren.AutoSize = true;
            this.labelregistrieren.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelregistrieren.Location = new System.Drawing.Point(352, 9);
            this.labelregistrieren.Name = "labelregistrieren";
            this.labelregistrieren.Size = new System.Drawing.Size(199, 46);
            this.labelregistrieren.TabIndex = 1;
            this.labelregistrieren.Text = "registrieren";
            // 
            // TextBoxPasswort
            // 
            this.TextBoxPasswort.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxPasswort.ForeColor = System.Drawing.Color.Silver;
            this.TextBoxPasswort.Location = new System.Drawing.Point(275, 364);
            this.TextBoxPasswort.Name = "TextBoxPasswort";
            this.TextBoxPasswort.Size = new System.Drawing.Size(247, 22);
            this.TextBoxPasswort.TabIndex = 2;
            this.TextBoxPasswort.Text = "Passwort";
            this.TextBoxPasswort.TextChanged += new System.EventHandler(this.TextBoxPasswort_TextChanged);
            this.TextBoxPasswort.Enter += new System.EventHandler(this.TextBoxPasswort_Enter);
            this.TextBoxPasswort.Leave += new System.EventHandler(this.TextBoxPasswort_Leave);
            // 
            // TextBoxEmail
            // 
            this.TextBoxEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxEmail.ForeColor = System.Drawing.Color.Silver;
            this.TextBoxEmail.Location = new System.Drawing.Point(275, 289);
            this.TextBoxEmail.Name = "TextBoxEmail";
            this.TextBoxEmail.Size = new System.Drawing.Size(247, 22);
            this.TextBoxEmail.TabIndex = 3;
            this.TextBoxEmail.Text = "example@eurodata.de";
            this.TextBoxEmail.TextChanged += new System.EventHandler(this.TextboxEmailBenutzerEingabe_TextChanged);
            this.TextBoxEmail.Enter += new System.EventHandler(this.TextBoxEmail_Enter);
            this.TextBoxEmail.Leave += new System.EventHandler(this.TextBoxEmail_Leave);
            // 
            // TextBoxBenutzername
            // 
            this.TextBoxBenutzername.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxBenutzername.ForeColor = System.Drawing.Color.Silver;
            this.TextBoxBenutzername.Location = new System.Drawing.Point(275, 210);
            this.TextBoxBenutzername.Name = "TextBoxBenutzername";
            this.TextBoxBenutzername.Size = new System.Drawing.Size(247, 22);
            this.TextBoxBenutzername.TabIndex = 4;
            this.TextBoxBenutzername.Text = "e.g ma.mustermann";
            this.TextBoxBenutzername.TextChanged += new System.EventHandler(this.TextBoxBenutzername_TextChanged);
            this.TextBoxBenutzername.Enter += new System.EventHandler(this.TextBoxBenutzername_Enter);
            this.TextBoxBenutzername.Leave += new System.EventHandler(this.TextBoxBenutzername_Leave);
            // 
            // TextBoxName
            // 
            this.TextBoxName.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxName.ForeColor = System.Drawing.Color.Silver;
            this.TextBoxName.Location = new System.Drawing.Point(275, 135);
            this.TextBoxName.Name = "TextBoxName";
            this.TextBoxName.Size = new System.Drawing.Size(247, 22);
            this.TextBoxName.TabIndex = 5;
            this.TextBoxName.Text = "Max Mustermann";
            this.TextBoxName.Enter += new System.EventHandler(this.TextBoxName_Enter);
            this.TextBoxName.Leave += new System.EventHandler(this.TextBoxName_Leave);
            // 
            // TextBoxPasswortbestaetigen
            // 
            this.TextBoxPasswortbestaetigen.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxPasswortbestaetigen.ForeColor = System.Drawing.Color.Silver;
            this.TextBoxPasswortbestaetigen.Location = new System.Drawing.Point(275, 442);
            this.TextBoxPasswortbestaetigen.Name = "TextBoxPasswortbestaetigen";
            this.TextBoxPasswortbestaetigen.Size = new System.Drawing.Size(247, 22);
            this.TextBoxPasswortbestaetigen.TabIndex = 6;
            this.TextBoxPasswortbestaetigen.Text = "Passwort";
            this.TextBoxPasswortbestaetigen.TextChanged += new System.EventHandler(this.TextBoxPasswortbestaetigen_TextChanged);
            this.TextBoxPasswortbestaetigen.Enter += new System.EventHandler(this.TextBoxPasswortbestaetigen_Enter);
            this.TextBoxPasswortbestaetigen.Leave += new System.EventHandler(this.TextBoxPasswortbestaetigen_Leave);
            // 
            // LabelName
            // 
            this.LabelName.AutoSize = true;
            this.LabelName.Font = new System.Drawing.Font("Times New Roman", 7.8F);
            this.LabelName.Location = new System.Drawing.Point(272, 116);
            this.LabelName.Name = "LabelName";
            this.LabelName.Size = new System.Drawing.Size(37, 15);
            this.LabelName.TabIndex = 10;
            this.LabelName.Text = "Name";
            // 
            // checkBoxDatenschutz
            // 
            this.checkBoxDatenschutz.AutoSize = true;
            this.checkBoxDatenschutz.Location = new System.Drawing.Point(275, 578);
            this.checkBoxDatenschutz.Name = "checkBoxDatenschutz";
            this.checkBoxDatenschutz.Size = new System.Drawing.Size(265, 20);
            this.checkBoxDatenschutz.TabIndex = 11;
            this.checkBoxDatenschutz.Text = "Ich stimme den Datenschutzrichtlinien zu";
            this.checkBoxDatenschutz.UseVisualStyleBackColor = true;
            this.checkBoxDatenschutz.CheckedChanged += new System.EventHandler(this.CheckBoxDatenschutz_CheckedChanged);
            // 
            // LabelBenutzername
            // 
            this.LabelBenutzername.AutoSize = true;
            this.LabelBenutzername.Font = new System.Drawing.Font("Times New Roman", 7.8F);
            this.LabelBenutzername.Location = new System.Drawing.Point(272, 192);
            this.LabelBenutzername.Name = "LabelBenutzername";
            this.LabelBenutzername.Size = new System.Drawing.Size(82, 15);
            this.LabelBenutzername.TabIndex = 12;
            this.LabelBenutzername.Text = "Benutzername";
            // 
            // ButtonRegistrieren
            // 
            this.ButtonRegistrieren.Enabled = false;
            this.ButtonRegistrieren.ForeColor = System.Drawing.Color.Silver;
            this.ButtonRegistrieren.Location = new System.Drawing.Point(348, 624);
            this.ButtonRegistrieren.Name = "ButtonRegistrieren";
            this.ButtonRegistrieren.Size = new System.Drawing.Size(101, 36);
            this.ButtonRegistrieren.TabIndex = 13;
            this.ButtonRegistrieren.Text = "Registrieren";
            this.ButtonRegistrieren.UseVisualStyleBackColor = true;
            this.ButtonRegistrieren.Click += new System.EventHandler(this.Registrieren_Click);
            // 
            // LabelEmail
            // 
            this.LabelEmail.AutoSize = true;
            this.LabelEmail.Font = new System.Drawing.Font("Times New Roman", 7.8F);
            this.LabelEmail.Location = new System.Drawing.Point(272, 271);
            this.LabelEmail.Name = "LabelEmail";
            this.LabelEmail.Size = new System.Drawing.Size(39, 15);
            this.LabelEmail.TabIndex = 14;
            this.LabelEmail.Text = "E-mail";
            // 
            // LabelPasswort
            // 
            this.LabelPasswort.AutoSize = true;
            this.LabelPasswort.Font = new System.Drawing.Font("Times New Roman", 7.8F);
            this.LabelPasswort.Location = new System.Drawing.Point(272, 346);
            this.LabelPasswort.Name = "LabelPasswort";
            this.LabelPasswort.Size = new System.Drawing.Size(56, 15);
            this.LabelPasswort.TabIndex = 15;
            this.LabelPasswort.Text = "Passwort";
            // 
            // LabelPasswortBestaetigen
            // 
            this.LabelPasswortBestaetigen.AutoSize = true;
            this.LabelPasswortBestaetigen.Font = new System.Drawing.Font("Times New Roman", 7.8F);
            this.LabelPasswortBestaetigen.Location = new System.Drawing.Point(272, 424);
            this.LabelPasswortBestaetigen.Name = "LabelPasswortBestaetigen";
            this.LabelPasswortBestaetigen.Size = new System.Drawing.Size(115, 15);
            this.LabelPasswortBestaetigen.TabIndex = 16;
            this.LabelPasswortBestaetigen.Text = "Passwort bestätigen";
            // 
            // LabelSicherheitsfrage
            // 
            this.LabelSicherheitsfrage.AutoSize = true;
            this.LabelSicherheitsfrage.Font = new System.Drawing.Font("Times New Roman", 7.8F);
            this.LabelSicherheitsfrage.Location = new System.Drawing.Point(272, 488);
            this.LabelSicherheitsfrage.Name = "LabelSicherheitsfrage";
            this.LabelSicherheitsfrage.Size = new System.Drawing.Size(93, 15);
            this.LabelSicherheitsfrage.TabIndex = 17;
            this.LabelSicherheitsfrage.Text = "Sicherheitsfrage";
            // 
            // ComboBoxFragen
            // 
            this.ComboBoxFragen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxFragen.FormattingEnabled = true;
            this.ComboBoxFragen.Items.AddRange(new object[] {
            "Wie hieß dein erstes Haustier?",
            "In Welcher Stadt wurdest du geboren?",
            "Welche Firma ist deine Lieblingsfirma?",
            "Wie war der Mädchenname deiner Mutter?",
            "Was ist ihre Lieblingszahl?"});
            this.ComboBoxFragen.Location = new System.Drawing.Point(275, 506);
            this.ComboBoxFragen.Name = "ComboBoxFragen";
            this.ComboBoxFragen.Size = new System.Drawing.Size(247, 24);
            this.ComboBoxFragen.TabIndex = 18;
            this.ComboBoxFragen.SelectedIndexChanged += new System.EventHandler(this.ComboBoxFragen_SelectedIndexChanged);
            // 
            // TextBoxSicherheitsfrage
            // 
            this.TextBoxSicherheitsfrage.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxSicherheitsfrage.ForeColor = System.Drawing.Color.Silver;
            this.TextBoxSicherheitsfrage.Location = new System.Drawing.Point(275, 536);
            this.TextBoxSicherheitsfrage.Name = "TextBoxSicherheitsfrage";
            this.TextBoxSicherheitsfrage.Size = new System.Drawing.Size(247, 22);
            this.TextBoxSicherheitsfrage.TabIndex = 19;
            this.TextBoxSicherheitsfrage.Text = "Antwort";
            this.TextBoxSicherheitsfrage.Enter += new System.EventHandler(this.TextBoxSicherheitsfrage_Enter);
            this.TextBoxSicherheitsfrage.Leave += new System.EventHandler(this.TextBoxSicherheitsfrage_Leave);
            // 
            // ButtonBeenden
            // 
            this.ButtonBeenden.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ButtonBeenden.Location = new System.Drawing.Point(684, 659);
            this.ButtonBeenden.Name = "ButtonBeenden";
            this.ButtonBeenden.Size = new System.Drawing.Size(94, 27);
            this.ButtonBeenden.TabIndex = 20;
            this.ButtonBeenden.Text = "Beenden";
            this.ButtonBeenden.UseVisualStyleBackColor = true;
            this.ButtonBeenden.Click += new System.EventHandler(this.ButtonBeenden_Click);
            // 
            // ButtonZurueck
            // 
            this.ButtonZurueck.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ButtonZurueck.Location = new System.Drawing.Point(584, 659);
            this.ButtonZurueck.Name = "ButtonZurueck";
            this.ButtonZurueck.Size = new System.Drawing.Size(94, 27);
            this.ButtonZurueck.TabIndex = 21;
            this.ButtonZurueck.Text = "Zurück";
            this.ButtonZurueck.UseVisualStyleBackColor = true;
            this.ButtonZurueck.Click += new System.EventHandler(this.ButtonZurueck_Click);
            // 
            // LabelPasswortAnforderungen
            // 
            this.LabelPasswortAnforderungen.AutoSize = true;
            this.LabelPasswortAnforderungen.ForeColor = System.Drawing.Color.Red;
            this.LabelPasswortAnforderungen.Location = new System.Drawing.Point(528, 364);
            this.LabelPasswortAnforderungen.Name = "LabelPasswortAnforderungen";
            this.LabelPasswortAnforderungen.Size = new System.Drawing.Size(185, 64);
            this.LabelPasswortAnforderungen.TabIndex = 22;
            this.LabelPasswortAnforderungen.Text = " Mindestens 8 Zeichen\n Mindestens 1 Zahl\n Mindestens 1 Sonderzeichen\n Mindestens " +
    "1 Großbuchstabe";
            // 
            // LabelPasswortStimmtnichtüberein
            // 
            this.LabelPasswortStimmtnichtüberein.AutoSize = true;
            this.LabelPasswortStimmtnichtüberein.BackColor = System.Drawing.Color.Transparent;
            this.LabelPasswortStimmtnichtüberein.ForeColor = System.Drawing.Color.Red;
            this.LabelPasswortStimmtnichtüberein.Location = new System.Drawing.Point(528, 442);
            this.LabelPasswortStimmtnichtüberein.Name = "LabelPasswortStimmtnichtüberein";
            this.LabelPasswortStimmtnichtüberein.Size = new System.Drawing.Size(208, 16);
            this.LabelPasswortStimmtnichtüberein.TabIndex = 23;
            this.LabelPasswortStimmtnichtüberein.Text = "Passwörter stimmen nicht überein!";
            // 
            // LabelEmailUngültig
            // 
            this.LabelEmailUngültig.AutoSize = true;
            this.LabelEmailUngültig.ForeColor = System.Drawing.Color.Red;
            this.LabelEmailUngültig.Location = new System.Drawing.Point(528, 280);
            this.LabelEmailUngültig.Name = "LabelEmailUngültig";
            this.LabelEmailUngültig.Size = new System.Drawing.Size(93, 16);
            this.LabelEmailUngültig.TabIndex = 24;
            this.LabelEmailUngültig.Text = "Email ungültig!";
            // 
            // LabelBereitsVergeben
            // 
            this.LabelBereitsVergeben.AutoSize = true;
            this.LabelBereitsVergeben.ForeColor = System.Drawing.Color.Red;
            this.LabelBereitsVergeben.Location = new System.Drawing.Point(528, 296);
            this.LabelBereitsVergeben.Name = "LabelBereitsVergeben";
            this.LabelBereitsVergeben.Size = new System.Drawing.Size(145, 16);
            this.LabelBereitsVergeben.TabIndex = 25;
            this.LabelBereitsVergeben.Text = "E-mail schon vergeben";
            this.LabelBereitsVergeben.Visible = false;
            // 
            // LabelBenutzerbereitsvergeben
            // 
            this.LabelBenutzerbereitsvergeben.AutoSize = true;
            this.LabelBenutzerbereitsvergeben.ForeColor = System.Drawing.Color.Red;
            this.LabelBenutzerbereitsvergeben.Location = new System.Drawing.Point(528, 213);
            this.LabelBenutzerbereitsvergeben.Name = "LabelBenutzerbereitsvergeben";
            this.LabelBenutzerbereitsvergeben.Size = new System.Drawing.Size(198, 16);
            this.LabelBenutzerbereitsvergeben.TabIndex = 26;
            this.LabelBenutzerbereitsvergeben.Text = "Benutzername bereits vergeben";
            this.LabelBenutzerbereitsvergeben.Visible = false;
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(787, 712);
            this.Controls.Add(this.LabelBenutzerbereitsvergeben);
            this.Controls.Add(this.LabelBereitsVergeben);
            this.Controls.Add(this.LabelEmailUngültig);
            this.Controls.Add(this.LabelPasswortStimmtnichtüberein);
            this.Controls.Add(this.LabelPasswortAnforderungen);
            this.Controls.Add(this.ButtonZurueck);
            this.Controls.Add(this.ButtonBeenden);
            this.Controls.Add(this.TextBoxSicherheitsfrage);
            this.Controls.Add(this.ComboBoxFragen);
            this.Controls.Add(this.LabelSicherheitsfrage);
            this.Controls.Add(this.LabelPasswortBestaetigen);
            this.Controls.Add(this.LabelPasswort);
            this.Controls.Add(this.LabelEmail);
            this.Controls.Add(this.ButtonRegistrieren);
            this.Controls.Add(this.LabelBenutzername);
            this.Controls.Add(this.checkBoxDatenschutz);
            this.Controls.Add(this.LabelName);
            this.Controls.Add(this.TextBoxPasswortbestaetigen);
            this.Controls.Add(this.TextBoxName);
            this.Controls.Add(this.TextBoxBenutzername);
            this.Controls.Add(this.TextBoxEmail);
            this.Controls.Add(this.TextBoxPasswort);
            this.Controls.Add(this.labelregistrieren);
            this.Controls.Add(this.LabelED);
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.Name = "Register";
            this.Text = "Register";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabelED;
        private System.Windows.Forms.Label labelregistrieren;
        private System.Windows.Forms.TextBox TextBoxPasswort;
        private System.Windows.Forms.TextBox TextBoxEmail;
        public System.Windows.Forms.TextBox TextBoxBenutzername;
        private System.Windows.Forms.TextBox TextBoxName;
        private System.Windows.Forms.TextBox TextBoxPasswortbestaetigen;
        private System.Windows.Forms.Label LabelName;
        private System.Windows.Forms.CheckBox checkBoxDatenschutz;
        private System.Windows.Forms.Label LabelBenutzername;
        private System.Windows.Forms.Button ButtonRegistrieren;
        private System.Windows.Forms.Label LabelEmail;
        private System.Windows.Forms.Label LabelPasswort;
        private System.Windows.Forms.Label LabelPasswortBestaetigen;
        private System.Windows.Forms.Label LabelSicherheitsfrage;
        private System.Windows.Forms.ComboBox ComboBoxFragen;
        private System.Windows.Forms.TextBox TextBoxSicherheitsfrage;
        private System.Windows.Forms.Button ButtonBeenden;
        private System.Windows.Forms.Button ButtonZurueck;
        private System.Windows.Forms.Label LabelPasswortAnforderungen;
        private System.Windows.Forms.Label LabelPasswortStimmtnichtüberein;
        private System.Windows.Forms.Label LabelEmailUngültig;
        private System.Windows.Forms.Label LabelBereitsVergeben;
        private System.Windows.Forms.Label LabelBenutzerbereitsvergeben;
    }
}