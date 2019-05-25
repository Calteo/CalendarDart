using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace Calendar.Dart
{
    internal partial class ThemedPanel : BasePanel
    {
        protected ThemedPanel()
        {
            InitializeComponent();
        }

        private const float TopFrachtionDefault = 0.1f;
        private const float BottomFrachtionDefault = 0.15f;

        [Browsable(false), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public MainForm MainForm { get; set; }

        [Browsable(false), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Game Game
        {
            get => MainForm.Game;
            set => MainForm.Game = value;
        }

        protected void NextPanel<T>() where T : ThemedPanel
        {
            MainForm.NextPanel<T>();
        }

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
                // RequestRestart?.Invoke(this, EventArgs.Empty);
                return true;
            }            
            return base.ProcessCmdKey(ref msg, keyData);
        }

    }
}
