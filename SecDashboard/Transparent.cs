using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SecDashboard
{

    public class TransparentButton : Button
    {
        private float opacity = 0.35f;
        public float Opacity
        {
            get { return opacity; }
            set
            {
                opacity = value;
                this.Invalidate();
            }
        }

        public TransparentButton()
        {
            this.SetStyle(ControlStyles.SupportsTransparentBackColor |
                          ControlStyles.Opaque |
                          ControlStyles.ResizeRedraw |                        
                          ControlStyles.UserMouse, true);
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);


            Graphics g = pe.Graphics;
            g.Clear(Parent.BackColor); 

            using (Brush b = new SolidBrush(Color.FromArgb((int)(255 * opacity), BackColor)))
            {
                g.FillRectangle(b, ClientRectangle); 
            }

            using (Brush b = new SolidBrush(Color.FromArgb((int)(255 * opacity), ForeColor)))
            {
                SizeF textSize = g.MeasureString(Text, Font); 
                PointF textPoint = new PointF((Width - textSize.Width) / 2, (Height - textSize.Height) / 2);
                g.DrawString(Text, Font, b, textPoint);
            }
        }
    }
}
