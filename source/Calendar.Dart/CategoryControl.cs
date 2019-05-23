using System;
using System.Collections.Generic;

namespace Calendar.Dart
{
    internal partial class CategoryControl : ThemedControl
    {
        public CategoryControl()
        {
            InitializeComponent();
        }

        public override void Activate()
        {
            base.Activate();

            var player = Game.Players[Game.Round % Game.Players.Count];

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
                SetButton(dartButton1, categories[0]);
            else
                dartButton1.Visible = false;

            if (categories.Count > 1)
                SetButton(dartButton2, categories[1]);
            else
                dartButton2.Visible = false;

            if (categories.Count > 2)
                SetButton(dartButton3, categories[2]);
            else
                dartButton3.Visible = false;

            if (categories.Count > 3)
                SetButton(dartButton4, categories[3]);
            else
                dartButton4.Visible = false;
        }

        private void SetButton(DartButton button, string text)
        {
            button.Text = text;
            button.Visible = true;
            ScaleText(button, 0.9f);
        }

        public event EventHandler CategoryClicked;

        private void ButtonCategoryClicked(object sender, EventArgs e)
        {
            var button = (DartButton) sender;
            Game.CurrentCategory = button.Text;
            CategoryClicked?.Invoke(this, EventArgs.Empty);
        }

        private void CategoryControlResize(object sender, EventArgs e)
        {
            ScaleText(labelCaption, 0.6f);
            ScaleText(dartButton1);
            ScaleText(dartButton2);
            ScaleText(dartButton3);
            ScaleText(dartButton4);
        }
    }
}
