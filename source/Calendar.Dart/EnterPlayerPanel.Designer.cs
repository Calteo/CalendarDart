namespace Calendar.Dart
{
    partial class EnterPlayerPanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EnterPlayerPanel));
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.labelHeader = new System.Windows.Forms.Label();
            this.playerNameControl = new Calendar.Dart.PlayerNameControl();
            this.buttonStart = new Calendar.Dart.DartButton();
            this.buttonNext = new Calendar.Dart.DartButton();
            this.tableLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel
            // 
            resources.ApplyResources(this.tableLayoutPanel, "tableLayoutPanel");
            this.tableLayoutPanel.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel.Controls.Add(this.labelHeader, 1, 1);
            this.tableLayoutPanel.Controls.Add(this.playerNameControl, 1, 2);
            this.tableLayoutPanel.Controls.Add(this.buttonStart, 1, 3);
            this.tableLayoutPanel.Controls.Add(this.buttonNext, 3, 3);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            // 
            // labelHeader
            // 
            resources.ApplyResources(this.labelHeader, "labelHeader");
            this.tableLayoutPanel.SetColumnSpan(this.labelHeader, 3);
            this.labelHeader.Name = "labelHeader";
            // 
            // playerNameControl
            // 
            resources.ApplyResources(this.playerNameControl, "playerNameControl");
            this.playerNameControl.BackColor = System.Drawing.Color.Black;
            this.tableLayoutPanel.SetColumnSpan(this.playerNameControl, 3);
            this.playerNameControl.ForeColor = System.Drawing.Color.White;
            this.playerNameControl.Name = "playerNameControl";
            this.playerNameControl.PlayerName = "";
            this.playerNameControl.PlayerNameChanged += new System.EventHandler(this.PlayerNameControlPlayerNameChanged);
            // 
            // buttonStart
            // 
            resources.ApplyResources(this.buttonStart, "buttonStart");
            this.buttonStart.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.UseVisualStyleBackColor = false;
            this.buttonStart.Click += new System.EventHandler(this.ButtonStartClick);
            // 
            // buttonNext
            // 
            resources.ApplyResources(this.buttonNext, "buttonNext");
            this.buttonNext.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.UseVisualStyleBackColor = false;
            this.buttonNext.Click += new System.EventHandler(this.ButtonNextClick);
            // 
            // EnterPlayerPanel
            // 
            resources.ApplyResources(this, "$this");
            this.Controls.Add(this.tableLayoutPanel);
            this.Name = "EnterPlayerPanel";
            this.Resize += new System.EventHandler(this.EnterPlayerControlResize);
            this.tableLayoutPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private System.Windows.Forms.Label labelHeader;
        private PlayerNameControl playerNameControl;
        private DartButton buttonNext;
        private DartButton buttonStart;
    }
}
