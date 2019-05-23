using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace Calendar.Dart
{
    internal partial class AskControl : ThemedControl
    {
        public AskControl()
        {
            InitializeComponent();
        }

        [Browsable(false), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string Message
        {
            get => labelMessage.Text;
            set => labelMessage.Text = value;
        }

        [Browsable(false), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string LeftText
        {
            get => dartButtonLeft.Text;
            set => dartButtonLeft.Text = value;
        }

        [Browsable(false), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string RightText
        {
            get => dartButtonRight.Text;
            set => dartButtonRight.Text = value;
        }

        private void AskControlResize(object sender, EventArgs e)
        {
            ScaleText(labelMessage);
            ScaleText(dartButtonLeft);
            ScaleText(dartButtonRight);
        }

        private void ControlTextChanged(object sender, EventArgs e)
        {
            ScaleText((Control)sender);
        }

        public event EventHandler LeftClicked;
        public event EventHandler RightClicked;

        private void DartButtonLeftClick(object sender, EventArgs e)
        {
            LeftClicked?.Invoke(this, EventArgs.Empty);
        }
        private void DartButtonRightClick(object sender, EventArgs e)
        {
            RightClicked?.Invoke(this, EventArgs.Empty);
        }
    }
}
