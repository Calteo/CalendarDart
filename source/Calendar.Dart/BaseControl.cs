using System.Drawing;
using System.Windows.Forms;

namespace Calendar.Dart
{
    public partial class BaseControl : UserControl
    {
        protected BaseControl()
        {
            InitializeComponent();
        }

        protected void ScaleToCell(Control control, TableLayoutPanel tableLayoutPanel, string text = null)
        {
            var rowHeights = tableLayoutPanel.GetRowHeights();
            var columnWidths = tableLayoutPanel.GetColumnWidths();

            var position = tableLayoutPanel.GetCellPosition(control);
            var rectangle = new Rectangle(0, 0, columnWidths[position.Column], rowHeights[position.Row]);
            rectangle.Width = (int)(rectangle.Width * 0.9f);
            rectangle.Height = (int)(rectangle.Height * 0.9f);

            Scale(control, rectangle, text);
        }

        protected void ScaleText(Control control, float scaleX = 1.0f, float scaleY = 1.0f, string text = null)
        {
            text = text ?? control.Text;

            var maxRect = control.ClientRectangle;
            maxRect.Width = (int)(control.ClientRectangle.Width * scaleX);
            maxRect.Height = (int) (control.ClientRectangle.Height * scaleY);

            Scale(control, maxRect, text);
        }

        protected void Scale(Control control, Rectangle rectangle, string text = null)
        {
            text = text ?? control.Text;
            var font = control.Font;

            if (string.IsNullOrEmpty(text)) return;
            
            using (var gc = control.CreateGraphics())
            {
                var size = gc.MeasureString(text, font, rectangle.Width, StringFormat.GenericTypographic);

                while (size.Height > rectangle.Height)
                {
                    font = new Font(font.FontFamily, font.Size / 1.1f);
                    size = gc.MeasureString(text, font, rectangle.Width, StringFormat.GenericTypographic);
                }

                while (size.Height < rectangle.Height)
                {
                    font = new Font(font.FontFamily, font.Size * 1.1f);
                    size = gc.MeasureString(text, font, rectangle.Width, StringFormat.GenericTypographic);
                }

                font = new Font(font.FontFamily, font.Size / 1.1f);
                control.Font = font;
            }
        }
    }
}