using System;
using System.Collections.Generic;

namespace Calendar.Dart
{
    internal partial class CategoryPanel : ThemedPanel
    {
        public CategoryPanel()
        {
            InitializeComponent();
        }

        public override void Activate()
        {
            base.Activate();

            var player = Game.Players[(Game.Round-1) % Game.Players.Count];

            labelPlayer.Text = player.Name;
            labelPlayer.BackColor = player.Color;

            ScaleText(labelPlayer);

            var categories = new List<string>();
            while (categories.Count < 4 && Game.Categories.Count > 0)
            {
                var category = Game.Categories.Dequeue();
                if (Game.Questions.Categories.TryGetValue(category, out List<Question> questions))
                {
                    if (questions.Count > 0)
                    {
                        categories.Add(category);           
                    }
                }
            }
            categories.ForEach(Game.Categories.Enqueue);

            if (categories.Count > 0)
                SetButton(button1, categories[0]);
            else
                button1.Visible = false;

            if (categories.Count > 1)
                SetButton(button2, categories[1]);
            else
                button2.Visible = false;

            if (categories.Count > 2)
                SetButton(button3, categories[2]);
            else
                button3.Visible = false;

            if (categories.Count > 3)
                SetButton(button4, categories[3]);
            else
                button4.Visible = false;
        }

        private void SetButton(DartButton button, string text)
        {
            button.Text = text;
            button.Visible = true;
            ScaleText(button, 0.9f);
        }
        
        private void ButtonCategoryClicked(object sender, EventArgs e)
        {
            var button = (DartButton) sender;
            Game.CurrentCategory = button.Text;
            NextPanel<JokersPanel>();
        }

        private void CategoryControlResize(object sender, EventArgs e)
        {
            ScaleText(labelCaption, 0.6f);
            ScaleText(button1);
            ScaleText(button2);
            ScaleText(button3);
            ScaleText(button4);
        }
    }
}
