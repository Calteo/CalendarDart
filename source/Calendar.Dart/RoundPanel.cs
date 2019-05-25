using System;

namespace Calendar.Dart
{
    internal partial class RoundPanel : ThemedPanel
    {
        public RoundPanel()
        {
            InitializeComponent();
        }

        public override void Activate()
        {
            base.Activate();

            Game.Players.ForEach(p => p.InitRound());

            labelRound.Text = $@"Runde {Game.Round}";
            labelPoints.Text = $@"{Game.Points:#,##0} Punkte";

            ScaleText(labelRound);
            ScaleText(labelPoints);
        }

        private void RoundControlResize(object sender, EventArgs e)
        {
            ScaleText(labelRound);
            ScaleText(labelPoints);

            ScaleText(buttonNext);
        }

        private void ButtonNextClick(object sender, EventArgs e)
        {
            NextPanel<CategoryPanel>();
        }
    }
}
