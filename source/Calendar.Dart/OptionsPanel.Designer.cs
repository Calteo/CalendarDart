namespace Calendar.Dart
{
    partial class OptionsPanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OptionsPanel));
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.buttonConstant = new Calendar.Dart.DartButton();
            this.buttonLinear = new Calendar.Dart.DartButton();
            this.buttonFactor = new Calendar.Dart.DartButton();
            this.labelCaption = new System.Windows.Forms.Label();
            this.tableLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel
            // 
            resources.ApplyResources(this.tableLayoutPanel, "tableLayoutPanel");
            this.tableLayoutPanel.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel.Controls.Add(this.buttonConstant, 1, 2);
            this.tableLayoutPanel.Controls.Add(this.buttonLinear, 2, 2);
            this.tableLayoutPanel.Controls.Add(this.buttonFactor, 3, 2);
            this.tableLayoutPanel.Controls.Add(this.labelCaption, 1, 1);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            // 
            // buttonConstant
            // 
            resources.ApplyResources(this.buttonConstant, "buttonConstant");
            this.buttonConstant.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.buttonConstant.Name = "buttonConstant";
            this.buttonConstant.UseVisualStyleBackColor = false;
            this.buttonConstant.Click += new System.EventHandler(this.ButtonConstantClick);
            // 
            // buttonLinear
            // 
            resources.ApplyResources(this.buttonLinear, "buttonLinear");
            this.buttonLinear.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.buttonLinear.Name = "buttonLinear";
            this.buttonLinear.UseVisualStyleBackColor = false;
            this.buttonLinear.Click += new System.EventHandler(this.ButtonLinearClick);
            // 
            // buttonFactor
            // 
            resources.ApplyResources(this.buttonFactor, "buttonFactor");
            this.buttonFactor.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.buttonFactor.Name = "buttonFactor";
            this.buttonFactor.UseVisualStyleBackColor = false;
            this.buttonFactor.Click += new System.EventHandler(this.ButtonFactorClick);
            // 
            // labelCaption
            // 
            resources.ApplyResources(this.labelCaption, "labelCaption");
            this.tableLayoutPanel.SetColumnSpan(this.labelCaption, 3);
            this.labelCaption.Name = "labelCaption";
            // 
            // OptionsPanel
            // 
            resources.ApplyResources(this, "$this");
            this.Controls.Add(this.tableLayoutPanel);
            this.Name = "OptionsPanel";
            this.Resize += new System.EventHandler(this.OptionsControlResize);
            this.tableLayoutPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private DartButton buttonConstant;
        private DartButton buttonLinear;
        private DartButton buttonFactor;
        private System.Windows.Forms.Label labelCaption;
    }
}
