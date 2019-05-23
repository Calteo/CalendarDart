using System;

namespace Calendar.Dart
{
    internal partial class CreditsControl : ThemedControl
    {
        public CreditsControl()
        {
            InitializeComponent();
        }

        private void LabelCreditsDoubleClick(object sender, EventArgs e)
        {
            NextClicked?.Invoke(this, EventArgs.Empty);
        }

        public event EventHandler NextClicked;

        private void CreditsControlResize(object sender, EventArgs e)
        {
            ScaleText(labelCredits, 1.0f, 0.9f);
        }

        private void TimerTick(object sender, EventArgs e)
        {
            timer.Enabled = false;
            NextClicked?.Invoke(this, EventArgs.Empty);
        }

        public override void Activate()
        {
            base.Activate();
            timer.Enabled = true;
        }
    }
}
