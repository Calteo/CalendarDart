using System;
using System.ComponentModel;

namespace Calendar.Dart
{
    internal partial class PositionControl : BaseControl
    {
        public PositionControl()
        {
            InitializeComponent();
        }

        private Player _player;

        [Browsable(false), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Player Player
        {
            get => _player;
            set
            {
                _player = value;
                BackColor = _player.Color;
                labelName.Text = _player.Name;
            }
        }

        private int _position;

        [Browsable(false), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public int Position
        {
            get => _position;
            set
            {
                _position = value;
                labelPosition.Text = _position.ToString();
                ScaleText(labelPosition);
            }
        }

        [Browsable(false), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string InfoText
        {
            get => labelInfo.Text;
            set
            {
                labelInfo.Text = value;
                ScaleText(labelInfo, 0.8f);
            }
        }

        private void PositionControlResize(object sender, EventArgs e)
        {
            ScaleText(labelName);
            ScaleText(labelPosition);
            ScaleText(labelInfo, 0.8f);
        }
    }
}
