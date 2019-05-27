using System;
using System.ComponentModel;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Calendar.Dart
{
    internal partial class GuessControl : BasePanel
    {
        public GuessControl()
        {
            InitializeComponent();
        }

        [Browsable(false), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public DateTime Solution { get; set; }

        [Browsable(false), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Game Game { get; set; }

        private Player _player;

        [Browsable(false), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Player Player
        {
            get => _player;
            set
            {
                _player = value;
                BackColor = _player.Color;
                labelPlayer.Text = _player.Name;
                editBoxMonth.Text = editBoxDay.Text = editBoxYear.Text = "";
                editBoxDay.Visible = editBoxMonth.Visible
                    = editBoxYear.Visible = Player.Active;

                editBoxDay.ReadOnly = editBoxMonth.ReadOnly
                    = editBoxYear.ReadOnly = false;

                /*
                maskedEditBoxDay.Mask = maskedEditBoxMonth.Mask = "##";
                maskedEditBoxYear.Mask = "####";
                */

                editBoxDay.TabStop = editBoxMonth.TabStop = editBoxYear.TabStop = true;

                switch (Player.Joker)
                {
                    case Joker.Oracle:
                    {
                        // maskedEditBoxYear.Mask = "****";
                        editBoxYear.Text = @"????";
                        editBoxYear.ReadOnly = true;
                        editBoxYear.TabStop = false;
                        break;
                    }
                    case Joker.Lucky:
                    {
                        // maskedEditBoxDay.Mask = maskedEditBoxMonth.Mask = "**";
                        editBoxDay.Text = editBoxMonth.Text = @"??";
                        editBoxDay.ReadOnly = editBoxMonth.ReadOnly = true;
                        editBoxDay.TabStop = editBoxMonth.TabStop = false;
                        break;
                    }

                    case Joker.Dice:
                    {
                        // maskedEditBoxDay.Mask = maskedEditBoxMonth.Mask = "**";
                        // maskedEditBoxDay.Text = maskedEditBoxMonth.Text = @"??";
                        // maskedEditBoxYear.Mask = "****";
                        // maskedEditBoxYear.Text = @"????";

                        editBoxDay.ReadOnly = editBoxMonth.ReadOnly
                            = editBoxYear.ReadOnly = true;
                        editBoxDay.TabStop = editBoxMonth.TabStop = editBoxYear.TabStop = false;
                        break;
                    }
                }
            }
        }

        public void SetFocus()
        {
            editBoxDay.Focus();
        }

        private void GuessControlResize(object sender, EventArgs e)
        {
            ScaleText(labelPlayer);

            ScaleToCell(editBoxYear, tableLayoutPanel, "00");
            ScaleToCell(editBoxDay, tableLayoutPanel, "0");
            ScaleToCell(editBoxMonth, tableLayoutPanel, "0");

            editBoxDay.Margin = new Padding(3, (tableLayoutPanel.ClientSize.Height - editBoxDay.Height) / 2, 10, 0);
            editBoxMonth.Margin = new Padding(3, (tableLayoutPanel.Height - editBoxMonth.Height) / 2, 10, 0);
            editBoxYear.Margin = new Padding(3, (tableLayoutPanel.Height - editBoxYear.Height) / 2, 10, 0);
        }

        private readonly Regex _datePattern = new Regex(@"\d{1,2}\.\d{1,2}\.\d{1,4}",
            RegexOptions.Compiled | RegexOptions.Singleline);

        private void MaskedEditBoxTextChanged(object sender, EventArgs e)
        {
            if (!Player.Active) return;

            var color = Color.DarkOrange;

            var text = $"{editBoxDay.Text}.{editBoxMonth.Text}.{editBoxYear.Text}";
            if (Player.Joker == Joker.Oracle)
            {
                text = $"{editBoxDay.Text}.{editBoxMonth.Text}.{Solution.Year}";
            }
            else if (Player.Joker == Joker.Lucky)
            {
                text = $"{Solution.Day}.{Solution.Month}.{editBoxYear.Text}";
            }
            if (Player.Joker == Joker.Dice)
            {
                color = Color.ForestGreen;
            }
            else if (DateTime.TryParse(text, out DateTime guess) && _datePattern.IsMatch(text))
            {
                color = Color.ForestGreen;
                Player.Guess = guess;
            }
            else if (Player.Joker==Joker.Lucky)
            {
                if (editBoxYear.Text != "")
                    color = Color.Red;
            }
            else if (Player.Joker==Joker.Oracle)
            {
                if (editBoxDay.Text != "" || editBoxMonth.Text != "")
                    color = Color.Red;
            }
            else
            {                
                if (editBoxDay.Text != ""
                    || editBoxMonth.Text != ""
                    || editBoxYear.Text != "")
                {
                    color = Color.Red;
                }
            }

            Guessed?.Invoke(this, EventArgs.Empty);

            editBoxDay.BackColor = color;
            editBoxMonth.BackColor = color;
            editBoxYear.BackColor = color;
        }

        public event EventHandler Guessed;
    }
}