using System;

namespace Calendar.Dart
{
    internal partial class TitlePanel : ThemedPanel
    {
        public TitlePanel()
        {
            InitializeComponent();
        }

        private void TitleControlResize(object sender, EventArgs e)
        {
            ScaleText(labelTitle, 0.7f, 0.5f);
        }

        private void LabelTitleDoubleClick(object sender, EventArgs e)
        {
            Game = Game.Load();
            if (Game != null)
                NextPanel<AskContinuePanel>();
            else
            {
                Game = new Game();
                NextPanel<SelectGamePanel>();
            }
        }

        private void labelTitle_Click(object sender, EventArgs e)
        {

        }
    }
}
