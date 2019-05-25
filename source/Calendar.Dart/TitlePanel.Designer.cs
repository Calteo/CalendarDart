namespace Calendar.Dart
{
    partial class TitlePanel
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TitlePanel));
            this.labelTitle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.labelTitle, "labelTitle");
            this.labelTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Click += new System.EventHandler(this.labelTitle_Click);
            this.labelTitle.DoubleClick += new System.EventHandler(this.LabelTitleDoubleClick);
            // 
            // TitleControl
            // 
            resources.ApplyResources(this, "$this");
            this.BottomFraction = 0.3F;
            this.Controls.Add(this.labelTitle);
            this.Name = "TitleControl";
            this.TopFraction = 0.2F;
            this.Resize += new System.EventHandler(this.TitleControlResize);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelTitle;
    }
}
