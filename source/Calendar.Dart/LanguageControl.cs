using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Text;
using System.Windows.Forms;

namespace Calendar.Dart
{
    internal partial class LanguageControl : ThemedPanel
    {
        public LanguageControl()
        {
            InitializeComponent();
        }

        private void dartButton1_Click(object sender, EventArgs e)
        {
            var button = (DartButton)sender;
            CultureInfo.CurrentUICulture = CultureInfo.GetCultureInfo((string)button.Tag);
            StartGame?.Invoke(this, EventArgs.Empty);
        }

        public event EventHandler StartGame;
    }
}
