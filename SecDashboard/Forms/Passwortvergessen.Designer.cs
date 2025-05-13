namespace SecDashboard.Forms
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
            this.LabelPWAnforderung = new System.Windows.Forms.Label();
            this.LabelPWÜbereinstimmung = new System.Windows.Forms.Label();
            this.SendenButton = new SecDashboard.TransparentButton();
            this.ButtonÄndern = new SecDashboard.TransparentButton();
            this.SuspendLayout();
            // 
            // LabelSicherheitsFragen
            // 
            this.LabelSicherheitsFragen.AutoSize = true;
            this.LabelSicherheitsFragen.Font = new System.Drawing.Font("Roboto", 10F);
            this.LabelSicherheitsFragen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(115)))), ((int)(((byte)(122)))));
            this.LabelSicherheitsFragen.Location = new System.Drawing.Point(77, 122);
            this.LabelSicherheitsFragen.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LabelSicherheitsFragen.Name = "LabelSicherheitsFragen";
            this.LabelSicherheitsFragen.Size = new System.Drawing.Size(117, 17);
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
            this.ComboBoxSicherheitsFragen.Location = new System.Drawing.Point(80, 141);
            this.ComboBoxSicherheitsFragen.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ComboBoxSicherheitsFragen.Name = "ComboBoxSicherheitsFragen";
            this.ComboBoxSicherheitsFragen.Size = new System.Drawing.Size(230, 22);
            this.ComboBoxSicherheitsFragen.TabIndex = 3;
            // 
            // TextBoxBenutzerName
            // 
            this.TextBoxBenutzerName.BackColor = System.Drawing.SystemColors.Window;
            this.TextBoxBenutzerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxBenutzerName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(73)))), ((int)(((byte)(77)))));
            this.TextBoxBenutzerName.Location = new System.Drawing.Point(34, 70);
            this.TextBoxBenutzerName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TextBoxBenutzerName.Name = "TextBoxBenutzerName";
            this.TextBoxBenutzerName.Size = new System.Drawing.Size(134, 19);
            this.TextBoxBenutzerName.TabIndex = 4;
            this.TextBoxBenutzerName.TextChanged += new System.EventHandler(this.TextBoxBenutzerName_TextChanged);
            this.TextBoxBenutzerName.Enter += new System.EventHandler(this.TextBoxBenutzerName_Enter);
            this.TextBoxBenutzerName.Leave += new System.EventHandler(this.TextBoxBenutzerName_Leave);
            this.TextBoxBenutzerName.MouseEnter += new System.EventHandler(this.TextBoxBenutzerName_MouseEnter);
            this.TextBoxBenutzerName.MouseLeave += new System.EventHandler(this.TextBoxBenutzerName_MouseLeave);
            // 
            // LabelBenutzerName
            // 
            this.LabelBenutzerName.AutoSize = true;
            this.LabelBenutzerName.Font = new System.Drawing.Font("Roboto", 10F);
            this.LabelBenutzerName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(115)))), ((int)(((byte)(122)))));
            this.LabelBenutzerName.Location = new System.Drawing.Point(31, 52);
            this.LabelBenutzerName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LabelBenutzerName.Name = "LabelBenutzerName";
            this.LabelBenutzerName.Size = new System.Drawing.Size(99, 17);
            this.LabelBenutzerName.TabIndex = 5;
            this.LabelBenutzerName.Text = "Benutzername";
            // 
            // TextBoxAntwort
            // 
            this.TextBoxAntwort.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(73)))), ((int)(((byte)(77)))));
            this.TextBoxAntwort.Location = new System.Drawing.Point(80, 165);
            this.TextBoxAntwort.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TextBoxAntwort.Name = "TextBoxAntwort";
            this.TextBoxAntwort.Size = new System.Drawing.Size(230, 20);
            this.TextBoxAntwort.TabIndex = 6;
            this.TextBoxAntwort.TextChanged += new System.EventHandler(this.TextBoxAntwort_TextChanged);
            this.TextBoxAntwort.MouseEnter += new System.EventHandler(this.TextBoxAntwort_MouseEnter);
            this.TextBoxAntwort.MouseLeave += new System.EventHandler(this.TextBoxAntwort_MouseLeave);
            // 
            // TextBoxEmail
            // 
            this.TextBoxEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(73)))), ((int)(((byte)(77)))));
            this.TextBoxEmail.Location = new System.Drawing.Point(224, 70);
            this.TextBoxEmail.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TextBoxEmail.Name = "TextBoxEmail";
            this.TextBoxEmail.Size = new System.Drawing.Size(132, 19);
            this.TextBoxEmail.TabIndex = 7;
            this.TextBoxEmail.TextChanged += new System.EventHandler(this.TextBoxEmail_TextChanged);
            this.TextBoxEmail.Enter += new System.EventHandler(this.TextBoxEmail_Enter);
            this.TextBoxEmail.Leave += new System.EventHandler(this.TextBoxEmail_Leave);
            this.TextBoxEmail.MouseEnter += new System.EventHandler(this.TextBoxEmail_MouseEnter);
            this.TextBoxEmail.MouseLeave += new System.EventHandler(this.TextBoxEmail_MouseLeave);
            // 
            // LabelEmail
            // 
            this.LabelEmail.AutoSize = true;
            this.LabelEmail.Font = new System.Drawing.Font("Roboto", 10F);
            this.LabelEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(115)))), ((int)(((byte)(122)))));
            this.LabelEmail.Location = new System.Drawing.Point(220, 52);
            this.LabelEmail.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LabelEmail.Name = "LabelEmail";
            this.LabelEmail.Size = new System.Drawing.Size(42, 17);
            this.LabelEmail.TabIndex = 8;
            this.LabelEmail.Text = "Email";
            // 
            // LabelErkannt
            // 
            this.LabelErkannt.AutoSize = true;
            this.LabelErkannt.Font = new System.Drawing.Font("Roboto", 12F);
            this.LabelErkannt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(161)))), ((int)(((byte)(105)))));
            this.LabelErkannt.Location = new System.Drawing.Point(133, 103);
            this.LabelErkannt.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LabelErkannt.Name = "LabelErkannt";
            this.LabelErkannt.Size = new System.Drawing.Size(129, 19);
            this.LabelErkannt.TabIndex = 9;
            this.LabelErkannt.Text = "Account Erkannt!";
            this.LabelErkannt.Visible = false;
            // 
            // LabelEmailUngültig
            // 
            this.LabelEmailUngültig.AutoSize = true;
            this.LabelEmailUngültig.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(26)))), ((int)(((byte)(55)))));
            this.LabelEmailUngültig.ForeColor = System.Drawing.Color.White;
            this.LabelEmailUngültig.Location = new System.Drawing.Point(221, 90);
            this.LabelEmailUngültig.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LabelEmailUngültig.Name = "LabelEmailUngültig";
            this.LabelEmailUngültig.Size = new System.Drawing.Size(78, 13);
            this.LabelEmailUngültig.TabIndex = 10;
            this.LabelEmailUngültig.Text = "E-Mail Ungültig";
            this.LabelEmailUngültig.Visible = false;
            // 
            // ButtonZurueck
            // 
            this.ButtonZurueck.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(225)))), ((int)(((byte)(229)))));
            this.ButtonZurueck.Font = new System.Drawing.Font("Roboto", 9F);
            this.ButtonZurueck.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(73)))), ((int)(((byte)(77)))));
            this.ButtonZurueck.Location = new System.Drawing.Point(314, 327);
            this.ButtonZurueck.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ButtonZurueck.Name = "ButtonZurueck";
            this.ButtonZurueck.Size = new System.Drawing.Size(80, 20);
            this.ButtonZurueck.TabIndex = 11;
            this.ButtonZurueck.Text = "Zurück";
            this.ButtonZurueck.UseVisualStyleBackColor = false;
            this.ButtonZurueck.Click += new System.EventHandler(this.ButtonZurueck_Click);
            this.ButtonZurueck.MouseEnter += new System.EventHandler(this.ButtonZurueck_MouseEnter);
            this.ButtonZurueck.MouseLeave += new System.EventHandler(this.ButtonZurueck_MouseLeave);
            // 
            // TextBoxNeuesPasswortBestätigen
            // 
            this.TextBoxNeuesPasswortBestätigen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(73)))), ((int)(((byte)(77)))));
            this.TextBoxNeuesPasswortBestätigen.Location = new System.Drawing.Point(80, 287);
            this.TextBoxNeuesPasswortBestätigen.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TextBoxNeuesPasswortBestätigen.Name = "TextBoxNeuesPasswortBestätigen";
            this.TextBoxNeuesPasswortBestätigen.Size = new System.Drawing.Size(230, 20);
            this.TextBoxNeuesPasswortBestätigen.TabIndex = 12;
            this.TextBoxNeuesPasswortBestätigen.Visible = false;
            this.TextBoxNeuesPasswortBestätigen.TextChanged += new System.EventHandler(this.TextBoxNeuesPasswortBestätigen_TextChanged);
            this.TextBoxNeuesPasswortBestätigen.MouseEnter += new System.EventHandler(this.TextBoxNeuesPasswortBestätigen_MouseEnter);
            this.TextBoxNeuesPasswortBestätigen.MouseLeave += new System.EventHandler(this.TextBoxNeuesPasswortBestätigen_MouseLeave);
            // 
            // TextBoxNeuesPasswort
            // 
            this.TextBoxNeuesPasswort.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(73)))), ((int)(((byte)(77)))));
            this.TextBoxNeuesPasswort.Location = new System.Drawing.Point(80, 229);
            this.TextBoxNeuesPasswort.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TextBoxNeuesPasswort.Name = "TextBoxNeuesPasswort";
            this.TextBoxNeuesPasswort.Size = new System.Drawing.Size(230, 20);
            this.TextBoxNeuesPasswort.TabIndex = 13;
            this.TextBoxNeuesPasswort.Visible = false;
            this.TextBoxNeuesPasswort.TextChanged += new System.EventHandler(this.TextBoxNeuesPasswort_TextChanged);
            this.TextBoxNeuesPasswort.MouseEnter += new System.EventHandler(this.TextBoxNeuesPasswort_MouseEnter);
            this.TextBoxNeuesPasswort.MouseLeave += new System.EventHandler(this.TextBoxNeuesPasswort_MouseLeave);
            // 
            // LabelNeuesPasswort
            // 
            this.LabelNeuesPasswort.AutoSize = true;
            this.LabelNeuesPasswort.Font = new System.Drawing.Font("Roboto", 10F);
            this.LabelNeuesPasswort.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(115)))), ((int)(((byte)(122)))));
            this.LabelNeuesPasswort.Location = new System.Drawing.Point(77, 210);
            this.LabelNeuesPasswort.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LabelNeuesPasswort.Name = "LabelNeuesPasswort";
            this.LabelNeuesPasswort.Size = new System.Drawing.Size(110, 17);
            this.LabelNeuesPasswort.TabIndex = 14;
            this.LabelNeuesPasswort.Text = "Neues Passwort";
            this.LabelNeuesPasswort.Visible = false;
            // 
            // LabelNeuesPasswortBestaetigen
            // 
            this.LabelNeuesPasswortBestaetigen.AutoSize = true;
            this.LabelNeuesPasswortBestaetigen.Font = new System.Drawing.Font("Roboto", 10F);
            this.LabelNeuesPasswortBestaetigen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(115)))), ((int)(((byte)(122)))));
            this.LabelNeuesPasswortBestaetigen.Location = new System.Drawing.Point(77, 268);
            this.LabelNeuesPasswortBestaetigen.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LabelNeuesPasswortBestaetigen.Name = "LabelNeuesPasswortBestaetigen";
            this.LabelNeuesPasswortBestaetigen.Size = new System.Drawing.Size(180, 17);
            this.LabelNeuesPasswortBestaetigen.TabIndex = 15;
            this.LabelNeuesPasswortBestaetigen.Text = "Neues Passwort Bestätigen";
            this.LabelNeuesPasswortBestaetigen.Visible = false;
            // 
            // LabelGeschafft
            // 
            this.LabelGeschafft.AutoSize = true;
            this.LabelGeschafft.Font = new System.Drawing.Font("Roboto", 10F);
            this.LabelGeschafft.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(161)))), ((int)(((byte)(105)))));
            this.LabelGeschafft.Location = new System.Drawing.Point(310, 165);
            this.LabelGeschafft.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LabelGeschafft.Name = "LabelGeschafft";
            this.LabelGeschafft.Size = new System.Drawing.Size(74, 17);
            this.LabelGeschafft.TabIndex = 16;
            this.LabelGeschafft.Text = "Geschafft!";
            this.LabelGeschafft.Visible = false;
            // 
            // LabelPWAnforderung
            // 
            this.LabelPWAnforderung.AutoSize = true;
            this.LabelPWAnforderung.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(26)))), ((int)(((byte)(55)))));
            this.LabelPWAnforderung.ForeColor = System.Drawing.Color.White;
            this.LabelPWAnforderung.Location = new System.Drawing.Point(78, 249);
            this.LabelPWAnforderung.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LabelPWAnforderung.Name = "LabelPWAnforderung";
            this.LabelPWAnforderung.Size = new System.Drawing.Size(222, 13);
            this.LabelPWAnforderung.TabIndex = 18;
            this.LabelPWAnforderung.Text = "Passwort entspricht nicht den Anforderungen!";
            this.LabelPWAnforderung.Visible = false;
            // 
            // LabelPWÜbereinstimmung
            // 
            this.LabelPWÜbereinstimmung.AutoSize = true;
            this.LabelPWÜbereinstimmung.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(26)))), ((int)(((byte)(55)))));
            this.LabelPWÜbereinstimmung.ForeColor = System.Drawing.Color.White;
            this.LabelPWÜbereinstimmung.Location = new System.Drawing.Point(78, 307);
            this.LabelPWÜbereinstimmung.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LabelPWÜbereinstimmung.Name = "LabelPWÜbereinstimmung";
            this.LabelPWÜbereinstimmung.Size = new System.Drawing.Size(167, 13);
            this.LabelPWÜbereinstimmung.TabIndex = 19;
            this.LabelPWÜbereinstimmung.Text = "Passwörter stimmen nicht überein!";
            this.LabelPWÜbereinstimmung.Visible = false;
            // 
            // SendenButton
            // 
            this.SendenButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(127)))), ((int)(((byte)(156)))));
            this.SendenButton.Font = new System.Drawing.Font("Roboto", 9F);
            this.SendenButton.ForeColor = System.Drawing.Color.White;
            this.SendenButton.Location = new System.Drawing.Point(155, 188);
            this.SendenButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.SendenButton.Name = "SendenButton";
            this.SendenButton.Opacity = 0.35F;
            this.SendenButton.Size = new System.Drawing.Size(79, 19);
            this.SendenButton.TabIndex = 22;
            this.SendenButton.Text = "Senden";
            this.SendenButton.UseVisualStyleBackColor = false;
            this.SendenButton.Click += new System.EventHandler(this.SendenButton_Click);
            this.SendenButton.MouseEnter += new System.EventHandler(this.SendenButton_MouseEnter);
            this.SendenButton.MouseLeave += new System.EventHandler(this.SendenButton_MouseLeave);
            // 
            // ButtonÄndern
            // 
            this.ButtonÄndern.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(127)))), ((int)(((byte)(156)))));
            this.ButtonÄndern.Enabled = false;
            this.ButtonÄndern.Font = new System.Drawing.Font("Roboto", 10F);
            this.ButtonÄndern.ForeColor = System.Drawing.Color.White;
            this.ButtonÄndern.Location = new System.Drawing.Point(155, 328);
            this.ButtonÄndern.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ButtonÄndern.Name = "ButtonÄndern";
            this.ButtonÄndern.Opacity = 0.35F;
            this.ButtonÄndern.Size = new System.Drawing.Size(79, 19);
            this.ButtonÄndern.TabIndex = 23;
            this.ButtonÄndern.Text = "Ändern";
            this.ButtonÄndern.UseVisualStyleBackColor = false;
            this.ButtonÄndern.Visible = false;
            this.ButtonÄndern.Click += new System.EventHandler(this.ButtonÄndern_Click_1);
            this.ButtonÄndern.MouseEnter += new System.EventHandler(this.ButtonÄndern_MouseEnter);
            this.ButtonÄndern.MouseLeave += new System.EventHandler(this.ButtonÄndern_MouseLeave);
            // 
            // Passwortvergessen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(402, 357);
            this.Controls.Add(this.ButtonÄndern);
            this.Controls.Add(this.SendenButton);
            this.Controls.Add(this.LabelPWÜbereinstimmung);
            this.Controls.Add(this.LabelPWAnforderung);
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
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Passwortvergessen";
            this.Text = "Passwortvergessen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
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
        private System.Windows.Forms.Label LabelPWAnforderung;
        private System.Windows.Forms.Label LabelPWÜbereinstimmung;
        private TransparentButton SendenButton;
        private TransparentButton ButtonÄndern;
    }
}