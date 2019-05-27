using System;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;

namespace Calendar.Dart
{
    internal partial class LanguagePanel : ThemedPanel
    {
        public LanguagePanel()
        {
            InitializeComponent();
        }

        private static string[] SupportedCultures = { "en", "de" };

        const int margin = 3;
        const int count = 2;

        public override void Activate()
        {
            base.Activate();

            flowLayoutPanel.Controls.Clear();            

            foreach (var culture in SupportedCultures.Select(n => CultureInfo.GetCultureInfo(n)))
            {
                var control = new DartButton
                {
                    Width = flowLayoutPanel.ClientSize.Width/count - 2*margin,
                    Height = flowLayoutPanel.ClientSize.Height / 10,
                    Text = culture.NativeName,
                    Tag = culture,
                    Margin = new Padding(margin)
                };
                control.Click += CultureButtonClicked;
                ScaleText(control);
                flowLayoutPanel.Controls.Add(control);
            }
        }

        private void CultureButtonClicked(object sender, EventArgs e)
        {
            var button = (DartButton)sender;            
            CultureInfo.CurrentUICulture = (CultureInfo)button.Tag;
            MainForm.ResetPanels();
            NextPanel<TitlePanel>();
        }

        private void ButtonBackClick(object sender, EventArgs e)
        {
            NextPanel<TitlePanel>();
        }

        private void LanguagePanelResize(object sender, EventArgs e)
        {
            ScaleText(labelCaption);
            ScaleText(dartButtonBack);

            foreach (DartButton button in flowLayoutPanel.Controls)
            {
                button.Width = flowLayoutPanel.ClientSize.Width / count - 2 * margin;
                ScaleText(button);
            }
        }
    }
}
