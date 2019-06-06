using System;
using System.ComponentModel;
using System.Drawing;
using System.Globalization;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Calendar.Dart
{
    internal partial class GuessControl : BasePanel
    {
        public GuessControl()
        {
            InitializeComponent();

            var separator = CultureInfo.CurrentUICulture.DateTimeFormat.DateSeparator.Replace(".", @"\.");
            
            DatePattern = new Regex($@"\d{1,2}{separator}\d{1,2}{separator}\d{1,4}", RegexOptions.Compiled | RegexOptions.Singleline);
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
                editBox2.Text = editBox1.Text = editBoxYear.Text = "";
                editBox1.Visible = editBox2.Visible
                    = editBoxYear.Visible = Player.Active;

                editBox1.ReadOnly = editBox2.ReadOnly
                    = editBoxYear.ReadOnly = false;

                editBox1.TabStop = editBox2.TabStop = editBoxYear.TabStop = true;

                switch (Player.Joker)
                {
                    case Joker.Oracle:
                    {
                        editBoxYear.Text = @"????";
                        editBoxYear.ReadOnly = true;
                        editBoxYear.TabStop = false;
                        break;
                    }
                    case Joker.Lucky:
                    {
                        editBox1.Text = editBox2.Text = @"??";
                        editBox1.ReadOnly = editBox2.ReadOnly = true;
                        editBox1.TabStop = editBox2.TabStop = false;
                        break;
                    }

                    case Joker.Dice:
                    {
                        editBox1.Text = editBox2.Text = @"??";
                        editBoxYear.Text = @"????";

                        editBox1.ReadOnly = editBox2.ReadOnly = editBoxYear.ReadOnly = true;
                        editBox1.TabStop = editBox2.TabStop = editBoxYear.TabStop = false;
                        break;
                    }
                }
            }
        }

        public void SetFocus()
        {
            editBox1.Focus();
        }

        private void GuessControlResize(object sender, EventArgs e)
        {
            ScaleText(labelPlayer);

            ScaleToCell(editBoxYear, tableLayoutPanel, "00");
            ScaleToCell(editBox1, tableLayoutPanel, "0");
            ScaleToCell(editBox2, tableLayoutPanel, "0");

            editBox1.Margin = new Padding(3, (tableLayoutPanel.ClientSize.Height - editBox1.Height) / 2, 10, 0);
            editBox2.Margin = new Padding(3, (tableLayoutPanel.Height - editBox2.Height) / 2, 10, 0);
            editBoxYear.Margin = new Padding(3, (tableLayoutPanel.Height - editBoxYear.Height) / 2, 10, 0);
        }

        private Regex DatePattern { get; set; }

        private void EditBoxTextChanged(object sender, EventArgs e)
        {
            if (!Player.Active) return;

            var color = Color.DarkOrange;

            var culture = CultureInfo.CurrentUICulture;
            var parts = culture.DateTimeFormat.ShortDatePattern.Split(culture.DateTimeFormat.DateSeparator.ToCharArray());

            var text = $"{editBox1.Text}.{editBox2.Text}.{editBoxYear.Text}";
            if (Player.Joker == Joker.Oracle)
            {
                text = $"{editBox1.Text}.{editBox2.Text}.{Solution.Year}";
            }
            else if (Player.Joker == Joker.Lucky)
            {
                text = $"{Solution.Day}.{Solution.Month}.{editBoxYear.Text}";
            }
            if (Player.Joker == Joker.Dice)
            {
                color = Color.ForestGreen;
            }
            else if (DateTime.TryParse(text, out DateTime guess) && DatePattern.IsMatch(text))
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
                if (editBox1.Text != "" || editBox2.Text != "")
                    color = Color.Red;
            }
            else
            {                
                if (editBox1.Text != ""
                    || editBox2.Text != ""
                    || editBoxYear.Text != "")
                {
                    color = Color.Red;
                }
            }

            Guessed?.Invoke(this, EventArgs.Empty);

            editBox1.BackColor = color;
            editBox2.BackColor = color;
            editBoxYear.BackColor = color;
        }

        public event EventHandler Guessed;
    }
}