using System;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Calendar.Dart
{
    internal partial class JokerControl : BasePanel
    {
        public JokerControl()
        {
            InitializeComponent();

            foreach (var joker in Enum.GetValues(typeof(Joker)).Cast<Joker>())
            {
                if (joker == Joker.NoGo)
                {
                    NoGoCommand = new ToolStripMenuItem(joker.ToString());
                    NoGoCommand.Tag = joker;
                    NoGoCommand.DropDownOpening += NoGoCommandPopup;
                    contextMenuStrip.Items.Add(NoGoCommand);
                }
                else
                {
                    var item = contextMenuStrip.Items.Add(joker.ToString());
                    item.Tag = joker;
                    item.Click += JokerClick;
                }
            }
        }

        private void JokerClick(object sender, EventArgs e)
        {
            var command = (ToolStripMenuItem)sender;

            if (Player.Joker == Joker.NoGo)
            {
                Blocked.Active = true;
                Blocked = null;
            }

            Player.Joker = (Joker)command.Tag;
            labelJoker.Text = command.Text;
        }


        private void NoGoCommandPopup(object sender, EventArgs e)
        {            
            foreach (ToolStripItem playerNoGoItem in NoGoCommand.DropDownItems)
            {
                var player = (Player)playerNoGoItem.Tag;
                playerNoGoItem.Available = player.Active && player != Player;
            }
        }

        private ToolStripMenuItem NoGoCommand { get; }


        private Player _player;

        [Browsable(false), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Player Player
        {
            get => _player;
            set
            {
                if (_player != null)
                    _player.PropertyChanged -= PlayerPropertyChanged;

                _player = value;

                if (_player != null)
                {
                    _player.PropertyChanged += PlayerPropertyChanged;

                    if (_player != null)
                    {
                        labelName.Text = _player.Name;
                        labelJoker.Text = _player.Joker.ToString();
                        BackColor = _player.Color;
                        SetLabelColor();
                    }
                    Blocked = null;
                }
            }
        }

        private void PlayerPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            if (e.PropertyName == nameof(Player.Active))
            {
                SetLabelColor();
            }
        }

        private void SetLabelColor()
        {
            labelName.ForeColor = Player.Active ? Color.White : Color.Red;            
        }

        [Browsable(false), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        private Player Blocked { get; set; }

        private Game _game;

        [Browsable(false), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Game Game
        {
            get => _game;
            set
            {
                _game = value;
                if (NoGoCommand.DropDownItems.Count == 0)
                {
                    Game.Players.ForEach(p =>
                    {
                        var noGoItem = NoGoCommand.DropDownItems.Add(p.Name);
                        noGoItem.Tag = p;
                        noGoItem.Click += NoGoCommandClicked;
                    });
                }
            }
        }

        private void NoGoCommandClicked(object sender, EventArgs e)
        {
            var command = (ToolStripItem)sender;

            if (Blocked!=null)
            {
                Blocked.Active = true;
            }

            Blocked = (Player)command.Tag;
            Blocked.Active = false;
            Player.Joker = Joker.NoGo;
            labelJoker.Text = Player.Joker.ToString();
        }

        private void JokerControlResize(object sender, EventArgs e)
        {
            ScaleText(labelName);
            ScaleText(labelJoker);

            var font = labelJoker.Font;
            if (font.Size > 10)
                font = new Font(font.FontFamily, font.Size / 2);
            contextMenuStrip.Font = font;
        }

        private void ContextMenuStripOpening(object sender, CancelEventArgs e)
        {
            foreach (ToolStripItem item in contextMenuStrip.Items)
            {
                var joker = (Joker)item.Tag;
                item.Available =
                    joker == Joker.Nix
                    ||
                    (Player.Active || joker == Joker.NoGo) && Player.Jokers.Contains(joker);
            }
        }

        private void labelJokerClick(object sender, EventArgs e)
        {
            contextMenuStrip.Show(MousePosition);
        }
    }
}
