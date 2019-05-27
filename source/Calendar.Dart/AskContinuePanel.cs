using System;

namespace Calendar.Dart
{
    internal partial class AskContinuePanel : AskPanel
    {
        public AskContinuePanel()
        {
            InitializeComponent();
        }

        protected override void ButtonLeftClick(object sender, EventArgs e)
        {
            NextPanel<RoundPanel>();
        }

        protected override void ButtonRightClick(object sender, EventArgs e)
        {
            Game = new Game();
            NextPanel<SelectGamePanel>();
        }
    }
}
