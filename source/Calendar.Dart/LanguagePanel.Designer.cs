namespace Calendar.Dart
{
    partial class LanguagePanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LanguagePanel));
            this.dartButtonBack = new Calendar.Dart.DartButton();
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.labelCaption = new System.Windows.Forms.Label();
            this.flowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.tableLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // dartButtonBack
            // 
            resources.ApplyResources(this.dartButtonBack, "dartButtonBack");
            this.dartButtonBack.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.dartButtonBack.FlatAppearance.BorderSize = 0;
            this.dartButtonBack.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Green;
            this.dartButtonBack.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Orange;
            this.dartButtonBack.Name = "dartButtonBack";
            this.dartButtonBack.Tag = "";
            this.dartButtonBack.UseVisualStyleBackColor = false;
            // 
            // tableLayoutPanel
            // 
            resources.ApplyResources(this.tableLayoutPanel, "tableLayoutPanel");
            this.tableLayoutPanel.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel.Controls.Add(this.dartButtonBack, 1, 3);
            this.tableLayoutPanel.Controls.Add(this.labelCaption, 1, 1);
            this.tableLayoutPanel.Controls.Add(this.flowLayoutPanel, 1, 2);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            // 
            // labelCaption
            // 
            resources.ApplyResources(this.labelCaption, "labelCaption");
            this.tableLayoutPanel.SetColumnSpan(this.labelCaption, 3);
            this.labelCaption.Name = "labelCaption";
            // 
            // flowLayoutPanel
            // 
            resources.ApplyResources(this.flowLayoutPanel, "flowLayoutPanel");
            this.tableLayoutPanel.SetColumnSpan(this.flowLayoutPanel, 3);
            this.flowLayoutPanel.Name = "flowLayoutPanel";
            // 
            // LanguagePanel
            // 
            resources.ApplyResources(this, "$this");
            this.Controls.Add(this.tableLayoutPanel);
            this.Name = "LanguagePanel";
            this.Resize += new System.EventHandler(this.LanguagePanelResize);
            this.tableLayoutPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private DartButton dartButtonBack;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private System.Windows.Forms.Label labelCaption;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel;
    }
}
