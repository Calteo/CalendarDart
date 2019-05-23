using System;
using System.Collections.Generic;
using System.Linq;

namespace Calendar.Dart
{
    internal partial class JokersControl : ThemedControl
    {
        public JokersControl()
        {
            InitializeComponent();

            JokerControls = new List<JokerControl>
            {
                jokerControl1, jokerControl2, jokerControl3, jokerControl4,
                jokerControl5, jokerControl6, jokerControl7, jokerControl8
            };
        }

        private List<JokerControl> JokerControls { get; }

        private void JokersControlResize(object sender, EventArgs e)
        {
            ScaleText(labelCaption);            
            ScaleText(dartButtonNext);
        }

        public override void Activate()
        {
            base.Activate();

            labelCaption.Text = @"Jokers" + Environment.NewLine + Game.CurrentCategory;
            ScaleText(labelCaption);

            for (var i = 0; i < Game.Players.Count; i++)
            {
                JokerControls[i].Game = Game;
                JokerControls[i].Player = Game.Players[i];
            }
            
            JokerControls.Skip(Game.Players.Count).ToList().ForEach(c => c.Visible = false);
        }

        private void ButtonNextClick(object sender, EventArgs e)
        {
            foreach (var player in Game.Players)
            {
                player.Jokers.Remove(player.Joker);
            }

            JokerControls.ForEach(c => c.Player = null);

            NextClicked?.Invoke(this, EventArgs.Empty);
        }

        public event EventHandler NextClicked;
    }
}
