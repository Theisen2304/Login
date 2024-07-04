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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.TextBoxEmail = new System.Windows.Forms.TextBox();
            this.LabelEmail = new System.Windows.Forms.Label();
            this.LabelErkannt = new System.Windows.Forms.Label();
            this.LabelEmailUngültig = new System.Windows.Forms.Label();
            this.ButtonZurueck = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // EDLabel
            // 
            this.EDLabel.AutoSize = true;
            this.EDLabel.Font = new System.Drawing.Font("Times New Roman", 24F);
            this.EDLabel.ForeColor = System.Drawing.Color.Red;
            this.EDLabel.Location = new System.Drawing.Point(21, 9);
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
            this.LabelPasswortVergessen.Location = new System.Drawing.Point(121, 9);
            this.LabelPasswortVergessen.Name = "LabelPasswortVergessen";
            this.LabelPasswortVergessen.Size = new System.Drawing.Size(318, 46);
            this.LabelPasswortVergessen.TabIndex = 1;
            this.LabelPasswortVergessen.Text = "Passwortvergessen";
            // 
            // LabelSicherheitsFragen
            // 
            this.LabelSicherheitsFragen.AutoSize = true;
            this.LabelSicherheitsFragen.ForeColor = System.Drawing.SystemColors.Control;
            this.LabelSicherheitsFragen.Location = new System.Drawing.Point(71, 154);
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
            this.ComboBoxSicherheitsFragen.Location = new System.Drawing.Point(74, 173);
            this.ComboBoxSicherheitsFragen.Name = "ComboBoxSicherheitsFragen";
            this.ComboBoxSicherheitsFragen.Size = new System.Drawing.Size(305, 24);
            this.ComboBoxSicherheitsFragen.TabIndex = 3;
            // 
            // TextBoxBenutzerName
            // 
            this.TextBoxBenutzerName.BackColor = System.Drawing.SystemColors.Window;
            this.TextBoxBenutzerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxBenutzerName.ForeColor = System.Drawing.Color.Silver;
            this.TextBoxBenutzerName.Location = new System.Drawing.Point(12, 86);
            this.TextBoxBenutzerName.Name = "TextBoxBenutzerName";
            this.TextBoxBenutzerName.Size = new System.Drawing.Size(178, 22);
            this.TextBoxBenutzerName.TabIndex = 4;
            this.TextBoxBenutzerName.Text = "e.g ma.mustermann";
            this.TextBoxBenutzerName.Enter += new System.EventHandler(this.TextBoxBenutzerName_Enter);
            this.TextBoxBenutzerName.Leave += new System.EventHandler(this.TextBoxBenutzerName_Leave);
            // 
            // LabelBenutzerName
            // 
            this.LabelBenutzerName.AutoSize = true;
            this.LabelBenutzerName.ForeColor = System.Drawing.Color.Snow;
            this.LabelBenutzerName.Location = new System.Drawing.Point(12, 67);
            this.LabelBenutzerName.Name = "LabelBenutzerName";
            this.LabelBenutzerName.Size = new System.Drawing.Size(93, 16);
            this.LabelBenutzerName.TabIndex = 5;
            this.LabelBenutzerName.Text = "Benutzername";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(74, 203);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(305, 22);
            this.textBox1.TabIndex = 6;
            // 
            // TextBoxEmail
            // 
            this.TextBoxEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxEmail.ForeColor = System.Drawing.Color.Silver;
            this.TextBoxEmail.Location = new System.Drawing.Point(265, 86);
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
            this.LabelEmail.Location = new System.Drawing.Point(262, 67);
            this.LabelEmail.Name = "LabelEmail";
            this.LabelEmail.Size = new System.Drawing.Size(41, 16);
            this.LabelEmail.TabIndex = 8;
            this.LabelEmail.Text = "Email";
            // 
            // LabelErkannt
            // 
            this.LabelErkannt.AutoSize = true;
            this.LabelErkannt.ForeColor = System.Drawing.Color.Lime;
            this.LabelErkannt.Location = new System.Drawing.Point(170, 134);
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
            this.LabelEmailUngültig.Location = new System.Drawing.Point(271, 111);
            this.LabelEmailUngültig.Name = "LabelEmailUngültig";
            this.LabelEmailUngültig.Size = new System.Drawing.Size(97, 16);
            this.LabelEmailUngültig.TabIndex = 10;
            this.LabelEmailUngültig.Text = "E-Mail Ungültig";
            this.LabelEmailUngültig.Visible = false;
            // 
            // ButtonZurueck
            // 
            this.ButtonZurueck.Location = new System.Drawing.Point(364, 249);
            this.ButtonZurueck.Name = "ButtonZurueck";
            this.ButtonZurueck.Size = new System.Drawing.Size(75, 23);
            this.ButtonZurueck.TabIndex = 11;
            this.ButtonZurueck.Text = "Zurück";
            this.ButtonZurueck.UseVisualStyleBackColor = true;
            this.ButtonZurueck.Click += new System.EventHandler(this.ButtonZurueck_Click);
            // 
            // Passwortvergessen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(451, 284);
            this.Controls.Add(this.ButtonZurueck);
            this.Controls.Add(this.LabelEmailUngültig);
            this.Controls.Add(this.LabelErkannt);
            this.Controls.Add(this.LabelEmail);
            this.Controls.Add(this.TextBoxEmail);
            this.Controls.Add(this.textBox1);
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
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox TextBoxEmail;
        private System.Windows.Forms.Label LabelEmail;
        private System.Windows.Forms.Label LabelErkannt;
        private System.Windows.Forms.Label LabelEmailUngültig;
        private System.Windows.Forms.Button ButtonZurueck;
    }
}