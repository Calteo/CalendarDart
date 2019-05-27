using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;

namespace Calendar.Dart
{
    internal partial class TimelinePanel : ThemedPanel
    {
        public TimelinePanel()
        {
            InitializeComponent();

            SolutionText = buttonNext.Text;
        }

        public bool ShowSolution { get; set; }

        public string SolutionText { get; set; }

        public override void Activate()
        {
            base.Activate();

            ShowSolution = false;
            labelQuestion.Text = Game.CurrentQuestion.Text;
            ScaleText(labelQuestion);
            buttonNext.Text = SolutionText;

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
            var datePattern = CultureInfo.CurrentUICulture.DateTimeFormat.ShortDatePattern.Replace("yyyy", "\r\nyyyy");

            foreach (var player in players)
            {
                var control = new TimelinePostionControl
                {
                    Dock = DockStyle.Fill,
                    BackColor = player.Color,
                    NameText = player.Name,
                    GuessText = player.Guess.ToString(datePattern, CultureInfo.CurrentUICulture)
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

                var solution = new Player { Color = Color.White, Name = "--»", Guess = Game.CurrentQuestion.Solution };

                var players = Game.Players.Where(p=>p.Active).Concat(new[] {solution}).OrderBy(p => p.Guess).ToList();
                InsertPlayers(players);

                buttonNext.Text = MainForm.GetPanel<PointsPanel>().Caption;

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