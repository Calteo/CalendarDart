using System;

namespace Calendar.Dart
{
    internal partial class RoundControl : ThemedControl
    {
        public RoundControl()
        {
            InitializeComponent();
        }

        public override void Activate()
        {
            base.Activate();

            labelRound.Text = $@"Runde {Game.Round}";
            labelPoints.Text = $@"{Game.Points:#,##0} Punkte";

            ScaleText(labelRound);
            ScaleText(labelPoints);
        }

        private void RoundControlResize(object sender, EventArgs e)
        {
            ScaleText(labelRound);
            ScaleText(labelPoints);

            ScaleText(dartButtonNext);
        }

        private void DartButtonNextClick(object sender, EventArgs e)
        {
            NextClicked?.Invoke(this, EventArgs.Empty);
        }

        public event EventHandler NextClicked;
    }
}
