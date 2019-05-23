using System;
using System.ComponentModel;
using System.IO;

namespace Calendar.Dart
{
    internal partial class SelectGameControl : ThemedControl
    {
        public SelectGameControl()
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
            Questions = new Questions((string)button.Tag);

            Selected?.Invoke(this, EventArgs.Empty);
        }

        [Browsable(false), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Questions Questions { get; set; }

        public event EventHandler Selected;

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
