using System;
using System.Linq;

namespace Calendar.Dart
{
    internal partial class GuessingPanel : ThemedPanel
    {
        public GuessingPanel()
        {
            InitializeComponent();

            GuessControls = new[]
            {
                guessControl1, guessControl2, guessControl3, guessControl4
            };
        }

        private GuessControl[] GuessControls { get; }

        private void GuessingControlResize(object sender, EventArgs e)
        {
            ScaleText(labelQuestion);            
            ScaleText(buttonNext);
        }

        public override void Activate()
        {
            base.Activate();

            labelQuestion.Text = Game.CurrentQuestion.Text;
            ScaleText(labelQuestion);

            Offset = 0;
            Init();
        }

        private void Init()
        {
            for (var i = 0; i < GuessControls.Length; i++)
            {
                if (Offset + i < Game.Players.Count)
                {
                    GuessControls[i].Solution = Game.CurrentQuestion.Solution;
                    GuessControls[i].Visible = true;
                    GuessControls[i].Game = Game;
                    GuessControls[i].Player = Game.Players[Offset + i];
                }
                else
                {
                    GuessControls[i].Visible = false;
                }
            }
            GuessControlGuessed(this, EventArgs.Empty);            
        }

        public override void Play()
        {
            base.Play();
            GuessControls[0].Focus();
        }

        private int Offset { get; set; }

        private void ButtonNextClick(object sender, EventArgs e)
        {
            Offset += GuessControls.Length;
            if (Offset < Game.Players.Count)
                Init();
            else
            {
                var guessed = Game.Players.Where(p => p.Active && p.Joker != Joker.Dice).ToList();
                var min = guessed.Min(p => p.Guess);
                var max = guessed.Max(p => p.Guess);

                Game.Players.Where(p => p.Active && p.Joker==Joker.Dice).ToList()
                    .ForEach(p => p.RollDice(min, max));

                NextPanel<TimelinePanel>();
            }
        }

        private void GuessControlGuessed(object sender, EventArgs e)
        {
            buttonNext.Enabled
                = GuessControls.Where(c => c.Visible).All(c => c.Player.HasGuessed);
        }
    }
}
