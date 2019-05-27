using System;

namespace Calendar.Dart
{
    internal partial class EnterPlayerPanel : ThemedPanel
    {
        public EnterPlayerPanel()
        {
            InitializeComponent();
        }

        private void EnterPlayerControlResize(object sender, EventArgs e)
        {
            ScaleText(labelHeader, 0.6f);
            ScaleText(buttonNext);
            ScaleText(buttonStart);
        }

        private void InitPlayer()
        {
            playerNameControl.BackColor = Player.Colors[Game.Players.Count];
            playerNameControl.PlayerName = "";
            playerNameControl.Focus();
        }

        public override void Activate()
        {
            base.Activate();

            InitPlayer();
        }

        private void CreatePlayer()
        {
            var player = new Player
            {
                Color = playerNameControl.BackColor,
                Name = playerNameControl.PlayerName
            };

            Game.Players.Add(player);
        }

        private void ButtonNextClick(object sender, EventArgs e)
        {
            CreatePlayer();

            if (Game.Players.Count == Player.Colors.Length - 1)
                buttonNext.Visible = false;
            
            InitPlayer();
        }

        private void ButtonStartClick(object sender, EventArgs e)
        {
            CreatePlayer();
            Game.Save();
            NextPanel<RoundPanel>();
        }

        private void PlayerNameControlPlayerNameChanged(object sender, EventArgs e)
        {
            buttonNext.Enabled = buttonStart.Enabled = playerNameControl.PlayerName != "";
        }
    }
}
