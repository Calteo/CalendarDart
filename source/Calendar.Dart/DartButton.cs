using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Windows.Forms;

namespace Calendar.Dart
{
    internal class DartButton : Button
    {
        public DartButton()
        {
            BackColor = Color.DarkSlateBlue;
            FlatStyle = FlatStyle.Flat;
            FlatAppearance.MouseOverBackColor = Color.Orange;
            FlatAppearance.MouseDownBackColor = Color.Green;
            FlatAppearance.BorderSize = 0;
        }

        protected override void OnPaintBackground(PaintEventArgs pevent)
        {
            pevent.Graphics.FillRectangle(
                new LinearGradientBrush(pevent.ClipRectangle, Color.Yellow, Color.Red, 90), pevent.ClipRectangle);
        }

        protected override void OnPaint(PaintEventArgs pevent)
        {
            var color1 = Color.DarkOrange;
            var color2 = Color.DarkRed;

            if (!Enabled)
            {
                color1 = Color.Gray;
                color2 = Color.DarkSlateGray;
            }
            else
            {
                if (ClientRectangle.Contains(PointToClient(MousePosition)))
                {
                    color1 = Color.LimeGreen;
                    color2 = Color.DarkGreen;
                }

                if (MouseButtons == MouseButtons.Left)
                {
                    color1 = Color.LightGreen;
                    color2 = Color.Green;
                }
            }

            pevent.Graphics.FillRectangle(new LinearGradientBrush(pevent.ClipRectangle, color1, color2, 90), pevent.ClipRectangle);
            pevent.Graphics.CompositingQuality = CompositingQuality.HighQuality;
            pevent.Graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
            pevent.Graphics.TextRenderingHint = TextRenderingHint.AntiAlias;
            var f = new StringFormat { Alignment = StringAlignment.Center, LineAlignment = StringAlignment.Center };
            pevent.Graphics.DrawString(Text, Font, new SolidBrush(ForeColor), pevent.ClipRectangle, f);
        }
    }
}
