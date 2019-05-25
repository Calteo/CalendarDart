using System;

namespace Calendar.Dart
{
    internal partial class CreditsPanel : ThemedPanel
    {
        public CreditsPanel()
        {
            InitializeComponent();
        }

        private void LabelCreditsDoubleClick(object sender, EventArgs e)
        {
            EndGame();
        }

        private void CreditsControlResize(object sender, EventArgs e)
        {
            ScaleText(labelCredits, 1.0f, 0.9f);
        }

        private void TimerTick(object sender, EventArgs e)
        {
            timer.Enabled = false;
            EndGame();
        }                

        public override void Activate()
        {
            base.Activate();
            timer.Enabled = true;
        }

        private void EndGame()
        {
            Game.Delete();
            MainForm.Close();
        }
    }
}
