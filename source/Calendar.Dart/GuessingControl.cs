using System;
using System.Linq;

namespace Calendar.Dart
{
    internal partial class GuessingControl : ThemedControl
    {
        public GuessingControl()
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
            ScaleText(labelCaption);            
            ScaleText(dartButtonNext);
        }

        public override void Activate()
        {
            base.Activate();

            labelCaption.Text = Game.CurrentQuestion.Text;
            ScaleText(labelCaption);

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
                var guessed = Game.Players.Where(p => p.Active && p.Joker != Joker.Würfel).ToList();
                var min = guessed.Min(p => p.Guess);
                var max = guessed.Max(p => p.Guess);

                Game.Players.Where(p => p.Active && p.Joker==Joker.Würfel).ToList()
                    .ForEach(p => p.RollDice(min, max));

                NextClicked?.Invoke(this, EventArgs.Empty);
            }
        }

        public event EventHandler NextClicked;

        private void GuessControlGuessed(object sender, EventArgs e)
        {
            dartButtonNext.Enabled
                = GuessControls.Where(c => c.Visible).All(c => c.Player.HasGuessed);
        }
    }
}
