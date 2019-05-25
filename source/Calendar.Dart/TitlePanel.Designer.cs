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
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.buttonLanguage = new Calendar.Dart.DartButton();
            this.buttonStart = new Calendar.Dart.DartButton();
            this.tableLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel.SetColumnSpan(this.labelTitle, 3);
            resources.ApplyResources(this.labelTitle, "labelTitle");
            this.labelTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.labelTitle.Name = "labelTitle";
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.tableLayoutPanel, "tableLayoutPanel");
            this.tableLayoutPanel.Controls.Add(this.labelTitle, 1, 0);
            this.tableLayoutPanel.Controls.Add(this.buttonLanguage, 1, 1);
            this.tableLayoutPanel.Controls.Add(this.buttonStart, 3, 1);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            // 
            // buttonLanguage
            // 
            this.buttonLanguage.BackColor = System.Drawing.Color.DarkSlateBlue;
            resources.ApplyResources(this.buttonLanguage, "buttonLanguage");
            this.buttonLanguage.FlatAppearance.BorderSize = 0;
            this.buttonLanguage.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Green;
            this.buttonLanguage.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Orange;
            this.buttonLanguage.Name = "buttonLanguage";
            this.buttonLanguage.UseVisualStyleBackColor = false;
            this.buttonLanguage.Click += new System.EventHandler(this.ButtonLanguageClick);
            // 
            // buttonStart
            // 
            this.buttonStart.BackColor = System.Drawing.Color.DarkSlateBlue;
            resources.ApplyResources(this.buttonStart, "buttonStart");
            this.buttonStart.FlatAppearance.BorderSize = 0;
            this.buttonStart.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Green;
            this.buttonStart.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Orange;
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.UseVisualStyleBackColor = false;
            this.buttonStart.Click += new System.EventHandler(this.ButtonStartClick);
            // 
            // TitlePanel
            // 
            resources.ApplyResources(this, "$this");
            this.BottomFraction = 0.3F;
            this.Controls.Add(this.tableLayoutPanel);
            this.Name = "TitlePanel";
            this.TopFraction = 0.2F;
            this.Resize += new System.EventHandler(this.TitleControlResize);
            this.tableLayoutPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private DartButton buttonLanguage;
        private DartButton buttonStart;
    }
}
