using System;
using System.ComponentModel;
using System.Drawing;

namespace Calendar.Dart
{
    public partial class VerticalLabelControl : BasePanel
    {
        public VerticalLabelControl()
        {
            InitializeComponent();
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);

            Scale(this, new Rectangle(0,0,Height, Width), Text);

            GenerateTexture();
        }

        [Browsable(true), DefaultValue(StringAlignment.Center)]
        public StringAlignment Alignment { get; set; } = StringAlignment.Center;

        [Browsable(true), DefaultValue(StringAlignment.Center)]
        public StringAlignment LineAlignment { get; set; } = StringAlignment.Center;

        private void GenerateTexture()
        {
            var format = new StringFormat
            {
                Alignment = Alignment,
                LineAlignment = LineAlignment,
                Trimming = StringTrimming.EllipsisCharacter
            };

            var image = new Bitmap(Height, Width);
            var gc = Graphics.FromImage(image);

            gc.Clear(BackColor);

            using (var brush = new SolidBrush(ForeColor))
            {
                gc.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit;
                gc.DrawString(Text, Font, brush, new Rectangle(0, 0, image.Width, image.Height), format);
            }

            image.RotateFlip(RotateFlipType.Rotate270FlipNone);

            BackgroundImage = image;
        }

        protected override void OnTextChanged(EventArgs e)
        {
            base.OnTextChanged(e);
            GenerateTexture();
        }
    }
}
