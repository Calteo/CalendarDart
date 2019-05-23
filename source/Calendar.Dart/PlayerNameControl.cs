using System;
using System.Windows.Forms;

namespace Calendar.Dart
{
    public partial class PlayerNameControl : BaseControl
    {
        public PlayerNameControl()
        {
            InitializeComponent();
        }

        private void PlayerNameControlResize(object sender, EventArgs e)
        {
            ScaleText(labelName);

            editBoxName.Font = labelName.Font;
            editBoxName.Margin = new Padding(3, (ClientSize.Height - editBoxName.Height) / 2, 10, 0);
        }

        public string PlayerName
        {
            get => editBoxName.Text;
            set => editBoxName.Text = value;
        }

        public event EventHandler PlayerNameChanged;

        private void EditBoxNameTextChanged(object sender, EventArgs e)
        {
            PlayerNameChanged?.Invoke(this, EventArgs.Empty);
        }
    }
}
