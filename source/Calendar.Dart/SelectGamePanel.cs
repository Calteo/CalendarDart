using System;
using System.ComponentModel;
using System.IO;

namespace Calendar.Dart
{
    internal partial class SelectGamePanel : ThemedPanel
    {
        public SelectGamePanel()
        {
            InitializeComponent();
        }

        public override void Activate()
        {
            base.Activate();

            foreach (var filename in Questions.GetGames())
            {
                var control = new DartButton
                {
                    Width = flowLayoutPanel.ClientSize.Width,
                    Height = flowLayoutPanel.ClientSize.Height / 8,
                    Text = Path.GetFileNameWithoutExtension(filename),
                    Tag = filename,             
                };
                control.Click += ButtonClicked;
                ScaleText(control);
                flowLayoutPanel.Controls.Add(control);
            }
        }

        private void ButtonClicked(object sender, EventArgs e)
        {
            var button = (DartButton) sender;
            Game.Questions = new Questions((string)button.Tag);
            NextPanel<OptionsPanel>();
        }

        [Browsable(false), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Questions Questions { get; set; }

        private void SelectGameControlResize(object sender, EventArgs e)
        {
            ScaleText(labelCaption);

            foreach (DartButton button in flowLayoutPanel.Controls)
            {
                button.Width = flowLayoutPanel.ClientSize.Width;
                ScaleText(button);
            }
        }
    }
}
