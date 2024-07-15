using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ED_Login
{
    //public class TransparentButton : Button
    //{
    //    public TransparentButton()
    //    {
    //        this.SetStyle(ControlStyles.SupportsTransparentBackColor, true);
    //        this.BackColor = Color.Transparent;
    //    }

    //    protected override void OnPaint(PaintEventArgs pevent)
    //    {
    //        Graphics graphics = pevent.Graphics;
    //        Rectangle rectangle = new Rectangle(0, 0, this.Width, this.Height);
    //        Color colorWithOpacity = Color.FromArgb(89, this.BackColor); // Alpha auf 89 gesetzt für ca. 35% Transparenz
    //        Brush brush = new SolidBrush(colorWithOpacity);

    //        graphics.FillRectangle(brush, rectangle);
    //        brush.Dispose();

    //        // Zeichne zusätzlich den Text des Buttons
    //        TextRenderer.DrawText(graphics, this.Text, this.Font, rectangle, this.ForeColor, TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter);

    //        base.OnPaint(pevent);
    //    }
    //}

    public class TransparentButton : Button
    {
        private float opacity = 0.35f;
        public float Opacity
        {
            get { return opacity; }
            set
            {
                opacity = value;
                this.Invalidate(); // Sorgt dafür, dass der Button neu gezeichnet wird
            }
        }

        public TransparentButton()
        {
            this.SetStyle(ControlStyles.SupportsTransparentBackColor |
                          ControlStyles.Opaque |
                          ControlStyles.ResizeRedraw |
                          // ControlStyles.UserPaint |
                          ControlStyles.UserMouse, true);
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);


            Graphics g = pe.Graphics;
            g.Clear(Parent.BackColor); // Setze zuerst den Hintergrund auf den des Eltern-Elements.

            using (Brush b = new SolidBrush(Color.FromArgb((int)(255 * opacity), BackColor)))
            {
                g.FillRectangle(b, ClientRectangle); // Zeichne den Hintergrund des Buttons
            }

            using (Brush b = new SolidBrush(Color.FromArgb((int)(255 * opacity), ForeColor)))
            {
                SizeF textSize = g.MeasureString(Text, Font); // Messe die Größe des Textes
                PointF textPoint = new PointF((Width - textSize.Width) / 2, (Height - textSize.Height) / 2);
                g.DrawString(Text, Font, b, textPoint); // Zeichne den Text
            }
        }
    }
}
