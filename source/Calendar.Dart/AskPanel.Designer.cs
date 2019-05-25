namespace Calendar.Dart
{
    partial class AskPanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AskPanel));
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.buttonLeft = new Calendar.Dart.DartButton();
            this.buttonRight = new Calendar.Dart.DartButton();
            this.labelMessage = new System.Windows.Forms.Label();
            this.tableLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.tableLayoutPanel, "tableLayoutPanel");
            this.tableLayoutPanel.Controls.Add(this.buttonLeft, 1, 2);
            this.tableLayoutPanel.Controls.Add(this.buttonRight, 3, 2);
            this.tableLayoutPanel.Controls.Add(this.labelMessage, 1, 1);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            // 
            // buttonLeft
            // 
            this.buttonLeft.BackColor = System.Drawing.Color.DarkSlateBlue;
            resources.ApplyResources(this.buttonLeft, "buttonLeft");
            this.buttonLeft.Name = "buttonLeft";
            this.buttonLeft.UseVisualStyleBackColor = false;
            this.buttonLeft.TextChanged += new System.EventHandler(this.ControlTextChanged);
            this.buttonLeft.Click += new System.EventHandler(this.ButtonLeftClick);
            // 
            // buttonRight
            // 
            this.buttonRight.BackColor = System.Drawing.Color.DarkSlateBlue;
            resources.ApplyResources(this.buttonRight, "buttonRight");
            this.buttonRight.Name = "buttonRight";
            this.buttonRight.UseVisualStyleBackColor = false;
            this.buttonRight.TextChanged += new System.EventHandler(this.ControlTextChanged);
            this.buttonRight.Click += new System.EventHandler(this.ButtonRightClick);
            // 
            // labelMessage
            // 
            this.tableLayoutPanel.SetColumnSpan(this.labelMessage, 3);
            resources.ApplyResources(this.labelMessage, "labelMessage");
            this.labelMessage.Name = "labelMessage";
            this.labelMessage.TextChanged += new System.EventHandler(this.ControlTextChanged);
            // 
            // AskPanel
            // 
            resources.ApplyResources(this, "$this");
            this.Controls.Add(this.tableLayoutPanel);
            this.Name = "AskPanel";
            this.Resize += new System.EventHandler(this.AskControlResize);
            this.tableLayoutPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private DartButton buttonLeft;
        private DartButton buttonRight;
        private System.Windows.Forms.Label labelMessage;
    }
}
