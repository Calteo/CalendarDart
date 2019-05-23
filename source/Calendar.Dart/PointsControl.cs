using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Calendar.Dart
{
    internal partial class PointsControl : ThemedControl
    {
        public PointsControl()
        {
            InitializeComponent();
        }

        public override void Activate()
        {
            base.Activate();

            PostionControls.ForEach(tableLayoutPanel.Controls.Remove);
            PostionControls.Clear();

            var players = Game.Players.OrderByDescending(p => p.Points).ToArray();

            for (var i = 0; i < players.Length; i++)
            {
                var control = new PositionControl
                {
                    Dock = DockStyle.Fill,
                    Player = players[i],
                    Position = i + 1,
                    InfoText = players[i].Points.ToString("#,##0")
                };
                PostionControls.Add(control);
                tableLayoutPanel.Controls.Add(control);

                if (i < 2)
                {
                    tableLayoutPanel.SetColumnSpan(control, 3);
                    tableLayoutPanel.SetCellPosition(control, new TableLayoutPanelCellPosition(1, 2 + i));
                }
                else
                {
                    var row = 4 + (i - 2) / 2;
                    var col = 1 + 2 * ((i - 2) % 2);
                    tableLayoutPanel.SetCellPosition(control, new TableLayoutPanelCellPosition(col, row));
                }
            }
        }

        private List<PositionControl> PostionControls { get; } = new List<PositionControl>();

        private void DartButtonNextClick(object sender, EventArgs e)
        {
            NextClicked?.Invoke(this, EventArgs.Empty);
        }

        public event EventHandler NextClicked;

        private void PointsControlResize(object sender, EventArgs e)
        {
            ScaleText(labelCaption);
            ScaleText(dartButtonNext);
        }
    }
}
