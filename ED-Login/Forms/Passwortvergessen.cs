using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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
    }
}
