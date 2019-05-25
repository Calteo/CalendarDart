using System;
using System.ComponentModel;

namespace Calendar.Dart
{
    public partial class TimelinePostionControl : BasePanel
    {
        public TimelinePostionControl()
        {
            InitializeComponent();
        }

        private void TimelinePostionControlResize(object sender, EventArgs e)
        {
        }

        [Browsable(false), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string NameText
        {
            get => verticalLabelControlName.Text;
            set => verticalLabelControlName.Text = value;
        }

        [Browsable(false), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string GuessText
        {
            get => verticalLabelControlGuess.Text;
            set => verticalLabelControlGuess.Text = value;
        }

        protected override void OnForeColorChanged(EventArgs e)
        {
            base.OnForeColorChanged(e);
            if (verticalLabelControlName!=null && verticalLabelControlGuess!=null)
                verticalLabelControlGuess.ForeColor = verticalLabelControlName.ForeColor = ForeColor;
        }
    }
}
