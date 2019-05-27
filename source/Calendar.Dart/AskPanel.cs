using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace Calendar.Dart
{
    internal partial class AskPanel : ThemedPanel
    {
        public AskPanel()
        {
            InitializeComponent();
         }

        public override void Play()
        {
            AskControlResize(this, EventArgs.Empty);
        }

        [Category("Dart"), Localizable(true)]
        public string Message
        {
            get => labelMessage.Text;
            set => labelMessage.Text = value;
        }

        [Category("Dart"), Localizable(true)]
        public string LeftText
        {
            get => buttonLeft.Text;
            set => buttonLeft.Text = value;
        }

        [Category("Dart"), Localizable(true)]
        public string RightText
        {
            get => buttonRight.Text;
            set => buttonRight.Text = value;
        }

        private void AskControlResize(object sender, EventArgs e)
        {
            ScaleText(labelMessage, 1f, 0.8f);
            ScaleText(buttonLeft);
            ScaleText(buttonRight);
        }

        private void ControlTextChanged(object sender, EventArgs e)
        {
            ScaleText((Control)sender);
        }

        protected virtual void ButtonLeftClick(object sender, EventArgs e)
        {
            throw new NotImplementedException("Left Button Click");
        }
        protected virtual void ButtonRightClick(object sender, EventArgs e)
        {
            throw new NotImplementedException("Right Button Click");
        }
    }
}
