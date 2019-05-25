using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Calendar.Dart
{
    internal partial class ScorePanel : ThemedPanel
    {
        public ScorePanel()
        {
            InitializeComponent();
        }

        public override void Activate()
        {
            base.Activate();

            buttonNext.Visible = Game.Questions.HasQuestions;

            PostionControls.ForEach(tableLayoutPanel.Controls.Remove);
            PostionControls.Clear();

            var scored = Game.Players.OrderByDescending(p => p.Score).ToArray();

            for (var i = 0; i < scored.Length; i++)
            {
                var control = new PositionControl
                {
                    Dock = DockStyle.Fill,
                    Player = scored[i],
                    Position = i + 1,
                    InfoText = scored[i].Score.ToString("#,##0")
                };
                PostionControls.Add(control);
                tableLayoutPanel.Controls.Add(control);

                if (i < 2)
                {
                    tableLayoutPanel.SetColumnSpan(control, 3);
                    tableLayoutPanel.SetCellPosition(control, new TableLayoutPanelCellPosition(1,2+i));
                }
                else
                {
                    var row = 4 + (i-2)/2;
                    var col = 1 + 2 * ((i-2)%2);
                    tableLayoutPanel.SetCellPosition(control, new TableLayoutPanelCellPosition(col, row));
                }                
            }
        }

        private List<PositionControl> PostionControls { get; } = new List<PositionControl>();

        private void ButtonExitClick(object sender, EventArgs e)
        {
            if (Game.Questions.HasQuestions)
            {
                NextPanel<AskQuitPanel>();
            }
            else
            {
                NextPanel<CreditsPanel>();
            }
        }

        private void ButtonNextClick(object sender, EventArgs e)
        {
            Game.NextRound();
            Game.Save();
            NextPanel<RoundPanel>();
        }

        private void ScoreControlResize(object sender, EventArgs e)
        {
            ScaleText(labelCaption);
            ScaleText(buttonExit);
            ScaleText(buttonNext);
        }
    }
}