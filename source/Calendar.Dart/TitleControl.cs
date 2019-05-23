using System;

namespace Calendar.Dart
{
    internal partial class TitleControl : ThemedControl
    {
        public TitleControl()
        {
            InitializeComponent();
        }

        private void TitleControlResize(object sender, EventArgs e)
        {
            ScaleText(labelTitle, 0.7f, 0.5f);
        }

        private void LabelTitleDoubleClick(object sender, EventArgs e)
        {
            StartGame?.Invoke(this, EventArgs.Empty);
        }

        public event EventHandler StartGame;
    }
}
