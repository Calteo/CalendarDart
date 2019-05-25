using System;

namespace Calendar.Dart
{
    internal partial class OptionsPanel : ThemedPanel
    {
        public OptionsPanel()
        {
            InitializeComponent();
        }

        private void OptionsControlResize(object sender, EventArgs e)
        {
            ScaleText(labelCaption);
            ScaleText(buttonConstant);
            ScaleText(buttonLinear);
            ScaleText(buttonFactor);
        }
        
        private void ButtonConstantClick(object sender, EventArgs e)
        {
            NextPanel();
        }

        private void ButtonLinearClick(object sender, EventArgs e)
        {
            Game.PointsAdd = 100;
            NextPanel();
        }

        private void ButtonFactorClick(object sender, EventArgs e)
        {
            Game.PointsFactor = 1.1f;
            NextPanel();
        }

        private void NextPanel()
        {
            Game.Save();
            NextPanel<EnterPlayerPanel>();
        }
    }
}
