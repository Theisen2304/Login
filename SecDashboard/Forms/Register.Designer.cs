namespace SecDashboard
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
            this.TextBoxPasswort = new System.Windows.Forms.TextBox();
            this.TextBoxEmail = new System.Windows.Forms.TextBox();
            this.TextBoxBenutzername = new System.Windows.Forms.TextBox();
            this.TextBoxName = new System.Windows.Forms.TextBox();
            this.TextBoxPasswortbestaetigen = new System.Windows.Forms.TextBox();
            this.LabelName = new System.Windows.Forms.Label();
            this.checkBoxDatenschutz = new System.Windows.Forms.CheckBox();
            this.LabelBenutzername = new System.Windows.Forms.Label();
            this.LabelEmail = new System.Windows.Forms.Label();
            this.LabelPasswort = new System.Windows.Forms.Label();
            this.LabelPasswortBestaetigen = new System.Windows.Forms.Label();
            this.LabelSicherheitsfrage = new System.Windows.Forms.Label();
            this.ComboBoxFragen = new System.Windows.Forms.ComboBox();
            this.TextBoxSicherheitsfrage = new System.Windows.Forms.TextBox();
            this.LabelPasswortAnforderungen = new System.Windows.Forms.Label();
            this.LabelPasswortStimmtnichtüberein = new System.Windows.Forms.Label();
            this.LabelEmailUngültig = new System.Windows.Forms.Label();
            this.LabelBereitsVergeben = new System.Windows.Forms.Label();
            this.LabelBenutzerbereitsvergeben = new System.Windows.Forms.Label();
            this.ButtonZurueck = new SecDashboard.TransparentButton();
            this.OpacityRegistrierenButton = new SecDashboard.TransparentButton();
            this.SuspendLayout();
            // 
            // TextBoxPasswort
            // 
            this.TextBoxPasswort.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxPasswort.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(73)))), ((int)(((byte)(77)))));
            this.TextBoxPasswort.Location = new System.Drawing.Point(178, 296);
            this.TextBoxPasswort.Margin = new System.Windows.Forms.Padding(2);
            this.TextBoxPasswort.Name = "TextBoxPasswort";
            this.TextBoxPasswort.Size = new System.Drawing.Size(242, 19);
            this.TextBoxPasswort.TabIndex = 2;
            this.TextBoxPasswort.UseSystemPasswordChar = true;
            this.TextBoxPasswort.TextChanged += new System.EventHandler(this.TextBoxPasswort_TextChanged);
            this.TextBoxPasswort.MouseEnter += new System.EventHandler(this.TextBoxPasswort_MouseEnter);
            this.TextBoxPasswort.MouseLeave += new System.EventHandler(this.TextBoxPasswort_MouseLeave);
            // 
            // TextBoxEmail
            // 
            this.TextBoxEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(73)))), ((int)(((byte)(77)))));
            this.TextBoxEmail.Location = new System.Drawing.Point(178, 235);
            this.TextBoxEmail.Margin = new System.Windows.Forms.Padding(2);
            this.TextBoxEmail.Name = "TextBoxEmail";
            this.TextBoxEmail.Size = new System.Drawing.Size(242, 19);
            this.TextBoxEmail.TabIndex = 3;
            this.TextBoxEmail.TextChanged += new System.EventHandler(this.TextboxEmailBenutzerEingabe_TextChanged);
            this.TextBoxEmail.MouseEnter += new System.EventHandler(this.TextBoxEmail_MouseEnter);
            this.TextBoxEmail.MouseLeave += new System.EventHandler(this.TextBoxEmail_MouseLeave);
            // 
            // TextBoxBenutzername
            // 
            this.TextBoxBenutzername.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxBenutzername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(73)))), ((int)(((byte)(77)))));
            this.TextBoxBenutzername.Location = new System.Drawing.Point(178, 171);
            this.TextBoxBenutzername.Margin = new System.Windows.Forms.Padding(2);
            this.TextBoxBenutzername.Name = "TextBoxBenutzername";
            this.TextBoxBenutzername.Size = new System.Drawing.Size(242, 19);
            this.TextBoxBenutzername.TabIndex = 4;
            this.TextBoxBenutzername.TextChanged += new System.EventHandler(this.TextBoxBenutzername_TextChanged);
            this.TextBoxBenutzername.MouseEnter += new System.EventHandler(this.TextBoxBenutzername_MouseEnter);
            this.TextBoxBenutzername.MouseLeave += new System.EventHandler(this.TextBoxBenutzername_MouseLeave);
            // 
            // TextBoxName
            // 
            this.TextBoxName.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(73)))), ((int)(((byte)(77)))));
            this.TextBoxName.Location = new System.Drawing.Point(178, 106);
            this.TextBoxName.Margin = new System.Windows.Forms.Padding(2);
            this.TextBoxName.Name = "TextBoxName";
            this.TextBoxName.Size = new System.Drawing.Size(242, 19);
            this.TextBoxName.TabIndex = 5;
            this.TextBoxName.MouseEnter += new System.EventHandler(this.TextBoxName_MouseEnter);
            this.TextBoxName.MouseLeave += new System.EventHandler(this.TextBoxName_MouseLeave);
            // 
            // TextBoxPasswortbestaetigen
            // 
            this.TextBoxPasswortbestaetigen.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxPasswortbestaetigen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(73)))), ((int)(((byte)(77)))));
            this.TextBoxPasswortbestaetigen.Location = new System.Drawing.Point(178, 359);
            this.TextBoxPasswortbestaetigen.Margin = new System.Windows.Forms.Padding(2);
            this.TextBoxPasswortbestaetigen.Name = "TextBoxPasswortbestaetigen";
            this.TextBoxPasswortbestaetigen.Size = new System.Drawing.Size(242, 19);
            this.TextBoxPasswortbestaetigen.TabIndex = 6;
            this.TextBoxPasswortbestaetigen.UseSystemPasswordChar = true;
            this.TextBoxPasswortbestaetigen.TextChanged += new System.EventHandler(this.TextBoxPasswortbestaetigen_TextChanged);
            this.TextBoxPasswortbestaetigen.MouseEnter += new System.EventHandler(this.TextBoxPasswortbestaetigen_MouseEnter);
            this.TextBoxPasswortbestaetigen.MouseLeave += new System.EventHandler(this.TextBoxPasswortbestaetigen_MouseLeave);
            // 
            // LabelName
            // 
            this.LabelName.AutoSize = true;
            this.LabelName.BackColor = System.Drawing.Color.Transparent;
            this.LabelName.Font = new System.Drawing.Font("Roboto", 10F);
            this.LabelName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(115)))), ((int)(((byte)(122)))));
            this.LabelName.Location = new System.Drawing.Point(176, 87);
            this.LabelName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LabelName.Name = "LabelName";
            this.LabelName.Size = new System.Drawing.Size(45, 17);
            this.LabelName.TabIndex = 10;
            this.LabelName.Text = "Name";
            // 
            // checkBoxDatenschutz
            // 
            this.checkBoxDatenschutz.AutoSize = true;
            this.checkBoxDatenschutz.Font = new System.Drawing.Font("Roboto", 9F);
            this.checkBoxDatenschutz.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(115)))), ((int)(((byte)(122)))));
            this.checkBoxDatenschutz.Location = new System.Drawing.Point(190, 467);
            this.checkBoxDatenschutz.Margin = new System.Windows.Forms.Padding(2);
            this.checkBoxDatenschutz.Name = "checkBoxDatenschutz";
            this.checkBoxDatenschutz.Size = new System.Drawing.Size(249, 18);
            this.checkBoxDatenschutz.TabIndex = 11;
            this.checkBoxDatenschutz.Text = "Ich stimme den Datenschutzrichtlinien zu";
            this.checkBoxDatenschutz.UseVisualStyleBackColor = true;
            this.checkBoxDatenschutz.CheckedChanged += new System.EventHandler(this.CheckBoxDatenschutz_CheckedChanged);
            // 
            // LabelBenutzername
            // 
            this.LabelBenutzername.AutoSize = true;
            this.LabelBenutzername.Font = new System.Drawing.Font("Roboto", 10F);
            this.LabelBenutzername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(115)))), ((int)(((byte)(122)))));
            this.LabelBenutzername.Location = new System.Drawing.Point(176, 151);
            this.LabelBenutzername.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LabelBenutzername.Name = "LabelBenutzername";
            this.LabelBenutzername.Size = new System.Drawing.Size(99, 17);
            this.LabelBenutzername.TabIndex = 12;
            this.LabelBenutzername.Text = "Benutzername";
            // 
            // LabelEmail
            // 
            this.LabelEmail.AutoSize = true;
            this.LabelEmail.Font = new System.Drawing.Font("Roboto", 10F);
            this.LabelEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(115)))), ((int)(((byte)(122)))));
            this.LabelEmail.Location = new System.Drawing.Point(176, 215);
            this.LabelEmail.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LabelEmail.Name = "LabelEmail";
            this.LabelEmail.Size = new System.Drawing.Size(46, 17);
            this.LabelEmail.TabIndex = 14;
            this.LabelEmail.Text = "E-mail";
            // 
            // LabelPasswort
            // 
            this.LabelPasswort.AutoSize = true;
            this.LabelPasswort.Font = new System.Drawing.Font("Roboto", 10F);
            this.LabelPasswort.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(115)))), ((int)(((byte)(122)))));
            this.LabelPasswort.Location = new System.Drawing.Point(176, 277);
            this.LabelPasswort.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LabelPasswort.Name = "LabelPasswort";
            this.LabelPasswort.Size = new System.Drawing.Size(68, 17);
            this.LabelPasswort.TabIndex = 15;
            this.LabelPasswort.Text = "Passwort";
            // 
            // LabelPasswortBestaetigen
            // 
            this.LabelPasswortBestaetigen.AutoSize = true;
            this.LabelPasswortBestaetigen.Font = new System.Drawing.Font("Roboto", 10F);
            this.LabelPasswortBestaetigen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(115)))), ((int)(((byte)(122)))));
            this.LabelPasswortBestaetigen.Location = new System.Drawing.Point(176, 340);
            this.LabelPasswortBestaetigen.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LabelPasswortBestaetigen.Name = "LabelPasswortBestaetigen";
            this.LabelPasswortBestaetigen.Size = new System.Drawing.Size(137, 17);
            this.LabelPasswortBestaetigen.TabIndex = 16;
            this.LabelPasswortBestaetigen.Text = "Passwort bestätigen";
            // 
            // LabelSicherheitsfrage
            // 
            this.LabelSicherheitsfrage.AutoSize = true;
            this.LabelSicherheitsfrage.Font = new System.Drawing.Font("Roboto", 10F);
            this.LabelSicherheitsfrage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(115)))), ((int)(((byte)(122)))));
            this.LabelSicherheitsfrage.Location = new System.Drawing.Point(176, 392);
            this.LabelSicherheitsfrage.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LabelSicherheitsfrage.Name = "LabelSicherheitsfrage";
            this.LabelSicherheitsfrage.Size = new System.Drawing.Size(109, 17);
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
            this.ComboBoxFragen.Location = new System.Drawing.Point(178, 411);
            this.ComboBoxFragen.Margin = new System.Windows.Forms.Padding(2);
            this.ComboBoxFragen.Name = "ComboBoxFragen";
            this.ComboBoxFragen.Size = new System.Drawing.Size(242, 21);
            this.ComboBoxFragen.TabIndex = 18;
            this.ComboBoxFragen.SelectedIndexChanged += new System.EventHandler(this.ComboBoxFragen_SelectedIndexChanged);
            // 
            // TextBoxSicherheitsfrage
            // 
            this.TextBoxSicherheitsfrage.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxSicherheitsfrage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(73)))), ((int)(((byte)(77)))));
            this.TextBoxSicherheitsfrage.Location = new System.Drawing.Point(178, 436);
            this.TextBoxSicherheitsfrage.Margin = new System.Windows.Forms.Padding(2);
            this.TextBoxSicherheitsfrage.Name = "TextBoxSicherheitsfrage";
            this.TextBoxSicherheitsfrage.Size = new System.Drawing.Size(242, 19);
            this.TextBoxSicherheitsfrage.TabIndex = 19;
            this.TextBoxSicherheitsfrage.MouseEnter += new System.EventHandler(this.TextBoxSicherheitsfrage_MouseEnter);
            this.TextBoxSicherheitsfrage.MouseLeave += new System.EventHandler(this.TextBoxSicherheitsfrage_MouseLeave);
            // 
            // LabelPasswortAnforderungen
            // 
            this.LabelPasswortAnforderungen.AutoSize = true;
            this.LabelPasswortAnforderungen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(26)))), ((int)(((byte)(55)))));
            this.LabelPasswortAnforderungen.ForeColor = System.Drawing.Color.White;
            this.LabelPasswortAnforderungen.Location = new System.Drawing.Point(424, 296);
            this.LabelPasswortAnforderungen.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LabelPasswortAnforderungen.Name = "LabelPasswortAnforderungen";
            this.LabelPasswortAnforderungen.Size = new System.Drawing.Size(149, 52);
            this.LabelPasswortAnforderungen.TabIndex = 22;
            this.LabelPasswortAnforderungen.Text = " Mindestens 8 Zeichen\n Mindestens 1 Zahl\n Mindestens 1 Sonderzeichen\n Mindestens " +
    "1 Großbuchstabe";
            this.LabelPasswortAnforderungen.Visible = false;
            // 
            // LabelPasswortStimmtnichtüberein
            // 
            this.LabelPasswortStimmtnichtüberein.AutoSize = true;
            this.LabelPasswortStimmtnichtüberein.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(26)))), ((int)(((byte)(55)))));
            this.LabelPasswortStimmtnichtüberein.ForeColor = System.Drawing.Color.White;
            this.LabelPasswortStimmtnichtüberein.Location = new System.Drawing.Point(424, 362);
            this.LabelPasswortStimmtnichtüberein.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LabelPasswortStimmtnichtüberein.Name = "LabelPasswortStimmtnichtüberein";
            this.LabelPasswortStimmtnichtüberein.Size = new System.Drawing.Size(167, 13);
            this.LabelPasswortStimmtnichtüberein.TabIndex = 23;
            this.LabelPasswortStimmtnichtüberein.Text = "Passwörter stimmen nicht überein!";
            this.LabelPasswortStimmtnichtüberein.Visible = false;
            // 
            // LabelEmailUngültig
            // 
            this.LabelEmailUngültig.AutoSize = true;
            this.LabelEmailUngültig.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(26)))), ((int)(((byte)(55)))));
            this.LabelEmailUngültig.ForeColor = System.Drawing.Color.White;
            this.LabelEmailUngültig.Location = new System.Drawing.Point(424, 237);
            this.LabelEmailUngültig.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LabelEmailUngültig.Name = "LabelEmailUngültig";
            this.LabelEmailUngültig.Size = new System.Drawing.Size(75, 13);
            this.LabelEmailUngültig.TabIndex = 24;
            this.LabelEmailUngültig.Text = "Email ungültig!";
            this.LabelEmailUngültig.Visible = false;
            // 
            // LabelBereitsVergeben
            // 
            this.LabelBereitsVergeben.AutoSize = true;
            this.LabelBereitsVergeben.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(26)))), ((int)(((byte)(55)))));
            this.LabelBereitsVergeben.ForeColor = System.Drawing.Color.White;
            this.LabelBereitsVergeben.Location = new System.Drawing.Point(222, 218);
            this.LabelBereitsVergeben.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LabelBereitsVergeben.Name = "LabelBereitsVergeben";
            this.LabelBereitsVergeben.Size = new System.Drawing.Size(115, 13);
            this.LabelBereitsVergeben.TabIndex = 25;
            this.LabelBereitsVergeben.Text = "E-mail schon vergeben";
            this.LabelBereitsVergeben.Visible = false;
            // 
            // LabelBenutzerbereitsvergeben
            // 
            this.LabelBenutzerbereitsvergeben.AutoSize = true;
            this.LabelBenutzerbereitsvergeben.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(26)))), ((int)(((byte)(55)))));
            this.LabelBenutzerbereitsvergeben.ForeColor = System.Drawing.Color.White;
            this.LabelBenutzerbereitsvergeben.Location = new System.Drawing.Point(268, 154);
            this.LabelBenutzerbereitsvergeben.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LabelBenutzerbereitsvergeben.Name = "LabelBenutzerbereitsvergeben";
            this.LabelBenutzerbereitsvergeben.Size = new System.Drawing.Size(157, 13);
            this.LabelBenutzerbereitsvergeben.TabIndex = 26;
            this.LabelBenutzerbereitsvergeben.Text = "Benutzername bereits vergeben";
            this.LabelBenutzerbereitsvergeben.Visible = false;
            // 
            // ButtonZurueck
            // 
            this.ButtonZurueck.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(225)))), ((int)(((byte)(229)))));
            this.ButtonZurueck.Font = new System.Drawing.Font("Roboto", 9F);
            this.ButtonZurueck.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(73)))), ((int)(((byte)(77)))));
            this.ButtonZurueck.Location = new System.Drawing.Point(493, 543);
            this.ButtonZurueck.Margin = new System.Windows.Forms.Padding(2);
            this.ButtonZurueck.Name = "ButtonZurueck";
            this.ButtonZurueck.Opacity = 1F;
            this.ButtonZurueck.Size = new System.Drawing.Size(88, 26);
            this.ButtonZurueck.TabIndex = 29;
            this.ButtonZurueck.Text = "Zurück";
            this.ButtonZurueck.UseVisualStyleBackColor = false;
            this.ButtonZurueck.Click += new System.EventHandler(this.ButtonZurueck_Click);
            this.ButtonZurueck.MouseEnter += new System.EventHandler(this.ButtonZurueck_MouseEnter);
            this.ButtonZurueck.MouseLeave += new System.EventHandler(this.ButtonZurueck_MouseLeave);
            // 
            // OpacityRegistrierenButton
            // 
            this.OpacityRegistrierenButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(127)))), ((int)(((byte)(156)))));
            this.OpacityRegistrierenButton.Enabled = false;
            this.OpacityRegistrierenButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OpacityRegistrierenButton.ForeColor = System.Drawing.Color.White;
            this.OpacityRegistrierenButton.Location = new System.Drawing.Point(252, 490);
            this.OpacityRegistrierenButton.Margin = new System.Windows.Forms.Padding(2);
            this.OpacityRegistrierenButton.Name = "OpacityRegistrierenButton";
            this.OpacityRegistrierenButton.Opacity = 0.35F;
            this.OpacityRegistrierenButton.Size = new System.Drawing.Size(83, 29);
            this.OpacityRegistrierenButton.TabIndex = 27;
            this.OpacityRegistrierenButton.Text = "Registrieren";
            this.OpacityRegistrierenButton.UseVisualStyleBackColor = false;
            this.OpacityRegistrierenButton.Click += new System.EventHandler(this.OpacityButton_Click);
            this.OpacityRegistrierenButton.MouseEnter += new System.EventHandler(this.OpacityRegistrierenButton_MouseEnter);
            this.OpacityRegistrierenButton.MouseLeave += new System.EventHandler(this.OpacityRegistrierenButton_MouseLeave);
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(590, 578);
            this.Controls.Add(this.ButtonZurueck);
            this.Controls.Add(this.OpacityRegistrierenButton);
            this.Controls.Add(this.LabelBenutzerbereitsvergeben);
            this.Controls.Add(this.LabelBereitsVergeben);
            this.Controls.Add(this.LabelEmailUngültig);
            this.Controls.Add(this.LabelPasswortStimmtnichtüberein);
            this.Controls.Add(this.LabelPasswortAnforderungen);
            this.Controls.Add(this.TextBoxSicherheitsfrage);
            this.Controls.Add(this.ComboBoxFragen);
            this.Controls.Add(this.LabelSicherheitsfrage);
            this.Controls.Add(this.LabelPasswortBestaetigen);
            this.Controls.Add(this.LabelPasswort);
            this.Controls.Add(this.LabelEmail);
            this.Controls.Add(this.LabelBenutzername);
            this.Controls.Add(this.checkBoxDatenschutz);
            this.Controls.Add(this.LabelName);
            this.Controls.Add(this.TextBoxPasswortbestaetigen);
            this.Controls.Add(this.TextBoxName);
            this.Controls.Add(this.TextBoxBenutzername);
            this.Controls.Add(this.TextBoxEmail);
            this.Controls.Add(this.TextBoxPasswort);
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Register";
            this.Text = "Registrieren";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox TextBoxPasswort;
        private System.Windows.Forms.TextBox TextBoxEmail;
        public System.Windows.Forms.TextBox TextBoxBenutzername;
        private System.Windows.Forms.TextBox TextBoxName;
        private System.Windows.Forms.TextBox TextBoxPasswortbestaetigen;
        private System.Windows.Forms.Label LabelName;
        private System.Windows.Forms.CheckBox checkBoxDatenschutz;
        private System.Windows.Forms.Label LabelBenutzername;
        private System.Windows.Forms.Label LabelEmail;
        private System.Windows.Forms.Label LabelPasswort;
        private System.Windows.Forms.Label LabelPasswortBestaetigen;
        private System.Windows.Forms.Label LabelSicherheitsfrage;
        private System.Windows.Forms.ComboBox ComboBoxFragen;
        private System.Windows.Forms.TextBox TextBoxSicherheitsfrage;
        private System.Windows.Forms.Label LabelPasswortAnforderungen;
        private System.Windows.Forms.Label LabelPasswortStimmtnichtüberein;
        private System.Windows.Forms.Label LabelEmailUngültig;
        private System.Windows.Forms.Label LabelBereitsVergeben;
        private System.Windows.Forms.Label LabelBenutzerbereitsvergeben;
        private TransparentButton OpacityRegistrierenButton;
        private TransparentButton ButtonZurueck;
    }
}