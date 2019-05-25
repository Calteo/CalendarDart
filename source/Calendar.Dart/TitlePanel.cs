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

            ScaleText(buttonLanguage);
            ScaleText(buttonStart);
        }

        private void ButtonStartClick(object sender, EventArgs e)
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

        private void ButtonLanguageClick(object sender, EventArgs e)
        {
            NextPanel<LanguagePanel>();
        }
    }
}
