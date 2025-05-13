using System.Drawing;

namespace SecDashboard
{
    partial class Login
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
            this.TextboxEmailBenutzerEingabe = new System.Windows.Forms.TextBox();
            this.TextboxPasswortEingabe = new System.Windows.Forms.TextBox();
            this.LabelEmailOderBenutzerName = new System.Windows.Forms.Label();
            this.LabelPasswort = new System.Windows.Forms.Label();
            this.RedirectRegistrieren = new System.Windows.Forms.LinkLabel();
            this.RedirectPasswortVergessen = new System.Windows.Forms.LinkLabel();
            this.LabelBenutzerEmailFalsch = new System.Windows.Forms.Label();
            this.LabelPasswortfalsch = new System.Windows.Forms.Label();
            this.LabelLoginErfolgreich = new System.Windows.Forms.Label();
            this.NeuerLoginButton = new SecDashboard.TransparentButton();
            this.SuspendLayout();
            // 
            // TextboxEmailBenutzerEingabe
            // 
            this.TextboxEmailBenutzerEingabe.BackColor = System.Drawing.Color.White;
            this.TextboxEmailBenutzerEingabe.CausesValidation = false;
            this.TextboxEmailBenutzerEingabe.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextboxEmailBenutzerEingabe.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(139)))), ((int)(((byte)(153)))));
            this.TextboxEmailBenutzerEingabe.Location = new System.Drawing.Point(220, 119);
            this.TextboxEmailBenutzerEingabe.Margin = new System.Windows.Forms.Padding(2);
            this.TextboxEmailBenutzerEingabe.Name = "TextboxEmailBenutzerEingabe";
            this.TextboxEmailBenutzerEingabe.Size = new System.Drawing.Size(159, 19);
            this.TextboxEmailBenutzerEingabe.TabIndex = 5;
            this.TextboxEmailBenutzerEingabe.TextChanged += new System.EventHandler(this.TextboxEmailBenutzerEingabe_TextChanged);
            this.TextboxEmailBenutzerEingabe.Enter += new System.EventHandler(this.TextboxEmailBenutzerEingabe_Enter);
            this.TextboxEmailBenutzerEingabe.Leave += new System.EventHandler(this.TextboxEmailBenutzerEingabe_Leave);
            this.TextboxEmailBenutzerEingabe.MouseEnter += new System.EventHandler(this.TextboxEmailBenutzerEingabe_MouseEnter);
            this.TextboxEmailBenutzerEingabe.MouseLeave += new System.EventHandler(this.TextboxEmailBenutzerEingabe_MouseLeave);
            // 
            // TextboxPasswortEingabe
            // 
            this.TextboxPasswortEingabe.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextboxPasswortEingabe.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(139)))), ((int)(((byte)(153)))));
            this.TextboxPasswortEingabe.Location = new System.Drawing.Point(220, 171);
            this.TextboxPasswortEingabe.Margin = new System.Windows.Forms.Padding(2);
            this.TextboxPasswortEingabe.Name = "TextboxPasswortEingabe";
            this.TextboxPasswortEingabe.Size = new System.Drawing.Size(159, 19);
            this.TextboxPasswortEingabe.TabIndex = 6;
            this.TextboxPasswortEingabe.TextChanged += new System.EventHandler(this.TextboxPasswortEingabe_TextChanged);
            this.TextboxPasswortEingabe.Enter += new System.EventHandler(this.TextboxPasswortEingabe_Enter);
            this.TextboxPasswortEingabe.Leave += new System.EventHandler(this.TextboxPasswortEingabe_Leave);
            this.TextboxPasswortEingabe.MouseEnter += new System.EventHandler(this.TextboxPasswortEingabe_MouseEnter);
            this.TextboxPasswortEingabe.MouseLeave += new System.EventHandler(this.TextboxPasswortEingabe_MouseLeave);
            // 
            // LabelEmailOderBenutzerName
            // 
            this.LabelEmailOderBenutzerName.AutoSize = true;
            this.LabelEmailOderBenutzerName.BackColor = System.Drawing.Color.Transparent;
            this.LabelEmailOderBenutzerName.Font = new System.Drawing.Font("Roboto", 9F);
            this.LabelEmailOderBenutzerName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(115)))), ((int)(((byte)(122)))));
            this.LabelEmailOderBenutzerName.Location = new System.Drawing.Point(218, 100);
            this.LabelEmailOderBenutzerName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LabelEmailOderBenutzerName.Name = "LabelEmailOderBenutzerName";
            this.LabelEmailOderBenutzerName.Size = new System.Drawing.Size(148, 14);
            this.LabelEmailOderBenutzerName.TabIndex = 7;
            this.LabelEmailOderBenutzerName.Text = "E-Mail oder Benutzername";
            // 
            // LabelPasswort
            // 
            this.LabelPasswort.AutoSize = true;
            this.LabelPasswort.BackColor = System.Drawing.Color.Transparent;
            this.LabelPasswort.Font = new System.Drawing.Font("Roboto", 9F);
            this.LabelPasswort.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(115)))), ((int)(((byte)(122)))));
            this.LabelPasswort.Location = new System.Drawing.Point(218, 154);
            this.LabelPasswort.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LabelPasswort.Name = "LabelPasswort";
            this.LabelPasswort.Size = new System.Drawing.Size(58, 14);
            this.LabelPasswort.TabIndex = 8;
            this.LabelPasswort.Text = "Passwort";
            // 
            // RedirectRegistrieren
            // 
            this.RedirectRegistrieren.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(127)))), ((int)(((byte)(156)))));
            this.RedirectRegistrieren.AutoSize = true;
            this.RedirectRegistrieren.Font = new System.Drawing.Font("Roboto", 10F);
            this.RedirectRegistrieren.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(127)))), ((int)(((byte)(156)))));
            this.RedirectRegistrieren.Location = new System.Drawing.Point(242, 262);
            this.RedirectRegistrieren.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.RedirectRegistrieren.Name = "RedirectRegistrieren";
            this.RedirectRegistrieren.Size = new System.Drawing.Size(117, 17);
            this.RedirectRegistrieren.TabIndex = 10;
            this.RedirectRegistrieren.TabStop = true;
            this.RedirectRegistrieren.Text = "Jetzt registrieren!";
            this.RedirectRegistrieren.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.RedirectRegistrieren.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.RedirectRegistrieren_LinkClicked);
            // 
            // RedirectPasswortVergessen
            // 
            this.RedirectPasswortVergessen.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(127)))), ((int)(((byte)(156)))));
            this.RedirectPasswortVergessen.AutoSize = true;
            this.RedirectPasswortVergessen.Font = new System.Drawing.Font("Roboto", 10F);
            this.RedirectPasswortVergessen.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(127)))), ((int)(((byte)(156)))));
            this.RedirectPasswortVergessen.Location = new System.Drawing.Point(218, 191);
            this.RedirectPasswortVergessen.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.RedirectPasswortVergessen.Name = "RedirectPasswortVergessen";
            this.RedirectPasswortVergessen.Size = new System.Drawing.Size(134, 17);
            this.RedirectPasswortVergessen.TabIndex = 11;
            this.RedirectPasswortVergessen.TabStop = true;
            this.RedirectPasswortVergessen.Text = "Passwort vergessen";
            this.RedirectPasswortVergessen.MouseClick += new System.Windows.Forms.MouseEventHandler(this.RedirectPasswortVergessen_MouseClick);
            // 
            // LabelBenutzerEmailFalsch
            // 
            this.LabelBenutzerEmailFalsch.AutoSize = true;
            this.LabelBenutzerEmailFalsch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(26)))), ((int)(((byte)(55)))));
            this.LabelBenutzerEmailFalsch.ForeColor = System.Drawing.Color.White;
            this.LabelBenutzerEmailFalsch.Location = new System.Drawing.Point(382, 121);
            this.LabelBenutzerEmailFalsch.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LabelBenutzerEmailFalsch.Name = "LabelBenutzerEmailFalsch";
            this.LabelBenutzerEmailFalsch.Size = new System.Drawing.Size(132, 13);
            this.LabelBenutzerEmailFalsch.TabIndex = 15;
            this.LabelBenutzerEmailFalsch.Text = "Benutzer oder Email falsch";
            this.LabelBenutzerEmailFalsch.Visible = false;
            // 
            // LabelPasswortfalsch
            // 
            this.LabelPasswortfalsch.AutoSize = true;
            this.LabelPasswortfalsch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(26)))), ((int)(((byte)(55)))));
            this.LabelPasswortfalsch.ForeColor = System.Drawing.Color.White;
            this.LabelPasswortfalsch.Location = new System.Drawing.Point(382, 173);
            this.LabelPasswortfalsch.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LabelPasswortfalsch.Name = "LabelPasswortfalsch";
            this.LabelPasswortfalsch.Size = new System.Drawing.Size(87, 13);
            this.LabelPasswortfalsch.TabIndex = 16;
            this.LabelPasswortfalsch.Text = "Passwort Falsch!";
            this.LabelPasswortfalsch.Visible = false;
            // 
            // LabelLoginErfolgreich
            // 
            this.LabelLoginErfolgreich.AutoSize = true;
            this.LabelLoginErfolgreich.ForeColor = System.Drawing.Color.Snow;
            this.LabelLoginErfolgreich.Location = new System.Drawing.Point(9, 386);
            this.LabelLoginErfolgreich.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LabelLoginErfolgreich.Name = "LabelLoginErfolgreich";
            this.LabelLoginErfolgreich.Size = new System.Drawing.Size(35, 13);
            this.LabelLoginErfolgreich.TabIndex = 17;
            this.LabelLoginErfolgreich.Text = "label1";
            this.LabelLoginErfolgreich.Visible = false;
            // 
            // NeuerLoginButton
            // 
            this.NeuerLoginButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(127)))), ((int)(((byte)(156)))));
            this.NeuerLoginButton.Font = new System.Drawing.Font("Roboto", 13F);
            this.NeuerLoginButton.ForeColor = System.Drawing.Color.White;
            this.NeuerLoginButton.Location = new System.Drawing.Point(245, 228);
            this.NeuerLoginButton.Margin = new System.Windows.Forms.Padding(2);
            this.NeuerLoginButton.Name = "NeuerLoginButton";
            this.NeuerLoginButton.Opacity = 0.35F;
            this.NeuerLoginButton.Size = new System.Drawing.Size(104, 31);
            this.NeuerLoginButton.TabIndex = 18;
            this.NeuerLoginButton.Text = "Login";
            this.NeuerLoginButton.UseVisualStyleBackColor = false;
            this.NeuerLoginButton.Click += new System.EventHandler(this.NeuerLoginButton_Click);
            this.NeuerLoginButton.MouseEnter += new System.EventHandler(this.NeuerLoginButton_MouseEnter);
            this.NeuerLoginButton.MouseLeave += new System.EventHandler(this.NeuerLoginButton_MouseLeave);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(608, 406);
            this.Controls.Add(this.NeuerLoginButton);
            this.Controls.Add(this.LabelLoginErfolgreich);
            this.Controls.Add(this.LabelPasswortfalsch);
            this.Controls.Add(this.LabelBenutzerEmailFalsch);
            this.Controls.Add(this.RedirectPasswortVergessen);
            this.Controls.Add(this.RedirectRegistrieren);
            this.Controls.Add(this.LabelPasswort);
            this.Controls.Add(this.LabelEmailOderBenutzerName);
            this.Controls.Add(this.TextboxPasswortEingabe);
            this.Controls.Add(this.TextboxEmailBenutzerEingabe);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Login";
            this.Text = "SecDashboard Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox TextboxEmailBenutzerEingabe;
        private System.Windows.Forms.TextBox TextboxPasswortEingabe;
        private System.Windows.Forms.Label LabelEmailOderBenutzerName;
        private System.Windows.Forms.Label LabelPasswort;
        private System.Windows.Forms.LinkLabel RedirectRegistrieren;
        private System.Windows.Forms.LinkLabel RedirectPasswortVergessen;
        private System.Windows.Forms.Label LabelBenutzerEmailFalsch;
        private System.Windows.Forms.Label LabelPasswortfalsch;
        private System.Windows.Forms.Label LabelLoginErfolgreich;
        private TransparentButton NeuerLoginButton;
    }
}

