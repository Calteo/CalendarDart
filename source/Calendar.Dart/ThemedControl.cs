using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace Calendar.Dart
{
    internal partial class ThemedControl : BaseControl
    {
        protected ThemedControl()
        {
            InitializeComponent();
        }

        private const float TopFrachtionDefault = 0.1f;
        private const float BottomFrachtionDefault = 0.15f;

        [DefaultValue(TopFrachtionDefault)]
        public float TopFraction { get; set; } = TopFrachtionDefault;

        [DefaultValue(BottomFrachtionDefault)]
        public float BottomFraction { get; set; } = BottomFrachtionDefault;

        private void ThemedControlPaint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawImage(Properties.Resources.Top,
                ClientRectangle.X, ClientRectangle.Y, ClientRectangle.Width, ClientRectangle.Height * TopFraction);

            e.Graphics.DrawImage(Properties.Resources.Bottom,
                ClientRectangle.X, ClientRectangle.Height * (1 - BottomFraction), ClientRectangle.Width,
                ClientRectangle.Height * BottomFraction);
        }

        [Browsable(false), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Game Game { get; set; }

        public virtual void Activate()
        {            
        }

        public virtual void Play()
        {
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == (Keys.Control | Keys.Shift | Keys.Q))
            {
                RequestRestart?.Invoke(this, EventArgs.Empty);
                return true;
            }            
            return base.ProcessCmdKey(ref msg, keyData);
        }

        public event EventHandler RequestRestart;
    }
}
