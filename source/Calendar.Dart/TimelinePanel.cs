using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Calendar.Dart
{
    internal partial class TimelinePanel : ThemedPanel
    {
        public TimelinePanel()
        {
            InitializeComponent();
        }

        public bool ShowSolution { get; set; }

        public override void Activate()
        {
            base.Activate();

            ShowSolution = false;
            labelQuestion.Text = Game.CurrentQuestion.Text;
            ScaleText(labelQuestion);
            buttonNext.Text = @"Lösung »";

            InsertPlayers(Game.Players.Where(p => p.Active).OrderBy(p => p.Guess).ToList());
        }

        public List<TimelinePostionControl> PostionControls { get; } = new List<TimelinePostionControl>();

        private void InsertPlayers(List<Player> players)
        {
            SuspendLayout();
            tableLayoutPanel.SuspendLayout();
            PostionControls.ForEach(tableLayoutPanel.Controls.Remove);
            PostionControls.Clear();

            var offset = (8 - players.Count) / 2 + 1;

            foreach (var player in players)
            {
                var control = new TimelinePostionControl
                {
                    Dock = DockStyle.Fill,
                    BackColor = player.Color,
                    NameText = player.Name,
                    GuessText = player.Guess.ToString("dd.MM.\r\nyyyy")
                };

                if (player.Color == Color.White)
                    control.ForeColor = Color.Black;

                tableLayoutPanel.Controls.Add(control);
                tableLayoutPanel.SetCellPosition(control, new TableLayoutPanelCellPosition(offset++, 2));
                PostionControls.Add(control);
            }
            tableLayoutPanel.ResumeLayout();
            ResumeLayout();
        }

        private void ButtonNextClick(object sender, EventArgs e)
        {
            if (ShowSolution == false)
            {
                SendToBack();

                ShowSolution = true;

                var solution = new Player { Color = Color.White, Name ="Lösung", Guess = Game.CurrentQuestion.Solution };

                var players = Game.Players.Where(p=>p.Active).Concat(new[] {solution}).OrderBy(p => p.Guess).ToList();
                InsertPlayers(players);

                buttonNext.Text = @"Punkte »";

                BringToFront();
            }
            else
            {
                Game.CalculatePoints();
                NextPanel<PointsPanel>();
            }
        }        

        private void TimelineControlResize(object sender, EventArgs e)
        {
            ScaleText(labelQuestion);
            ScaleText(buttonNext);
        }
    }
}