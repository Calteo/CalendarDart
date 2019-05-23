using System;

namespace Calendar.Dart
{
    internal partial class OptionsControl : ThemedControl
    {
        public OptionsControl()
        {
            InitializeComponent();
        }

        private void OptionsControlResize(object sender, EventArgs e)
        {
            ScaleText(labelCaption);
            ScaleText(dartButtonConstant);
            ScaleText(dartButtonLinear);
            ScaleText(dartButtonFactor);
        }

        public event EventHandler NextClicked;

        private void DartButtonConstantClick(object sender, EventArgs e)
        {
            NextClicked?.Invoke(this, EventArgs.Empty);
        }

        private void DartButtonLinearClick(object sender, EventArgs e)
        {
            Game.PointsAdd = 100;
            NextClicked?.Invoke(this, EventArgs.Empty);
        }

        private void DartButtonFactorClick(object sender, EventArgs e)
        {
            Game.PointsFactor = 1.1f;
            NextClicked?.Invoke(this, EventArgs.Empty);
        }
    }
}
