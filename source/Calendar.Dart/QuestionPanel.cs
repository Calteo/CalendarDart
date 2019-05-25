using System;
using System.Windows.Forms;

namespace Calendar.Dart
{
    internal partial class QuestionPanel : ThemedPanel
    {
        public QuestionPanel()
        {
            InitializeComponent();
        }

        private void QuestionControlResize(object sender, EventArgs e)
        {
            ScaleText(labelQuestion);
            ScaleText(buttonNext);
        }

        public override void Activate()
        {
            base.Activate();

            Game.CurrentQuestion = Game.Questions.PickQuestion(Game.CurrentCategory);
            labelQuestion.Text = Game.CurrentQuestion.Text;
            ScaleText(labelQuestion);

            uiProgressBar.Value = 0;
            uiProgressBar.Maximum = 20;

            EndTime = DateTime.Now.AddSeconds(uiProgressBar.Maximum);
            timer.Enabled = true;         
        }

        public DateTime EndTime { get; private set; }

        private void TimerTick(object sender, EventArgs e)
        {
            var remain = EndTime - DateTime.Now;
            if (remain.Seconds > 0)
                uiProgressBar.Value = uiProgressBar.Maximum-remain.Seconds;
            else
            {
                uiProgressBar.Value = uiProgressBar.Maximum;
                
                timer.Enabled = false;
            }
        }

        private void ButtonNextClick(object sender, EventArgs e)
        {
            timer.Enabled = false;
            NextPanel<GuessingPanel>();
        }
    }
}
