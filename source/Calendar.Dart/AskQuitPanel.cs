using System;
namespace Calendar.Dart
{
    internal partial class AskQuitPanel : AskPanel
    {
        public AskQuitPanel()
        {
            InitializeComponent();
        }

        protected override void ButtonLeftClick(object sender, EventArgs e)
        {
            NextPanel<CreditsPanel>();
        }

        protected override void ButtonRightClick(object sender, EventArgs e)
        {
            NextPanel<ScorePanel>();
        }
    }
}
