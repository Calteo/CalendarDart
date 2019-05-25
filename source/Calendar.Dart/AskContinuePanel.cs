using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Calendar.Dart
{
    internal partial class AskContinuePanel : AskPanel
    {
        public AskContinuePanel()
        {
            InitializeComponent();
        }

        protected override void ButtonLeftClick(object sender, EventArgs e)
        {
            NextPanel<RoundPanel>();
        }

        protected override void ButtonRightClick(object sender, EventArgs e)
        {
            Game = new Game();
            NextPanel<SelectGamePanel>();
        }
    }
}
