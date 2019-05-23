namespace Calendar.Dart
{
    partial class EnterPlayerControl
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
            this.tableLayoutPanel.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel.ColumnCount = 5;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel.Controls.Add(this.labelHeader, 1, 1);
            this.tableLayoutPanel.Controls.Add(this.playerNameControl, 1, 2);
            this.tableLayoutPanel.Controls.Add(this.buttonStart, 1, 3);
            this.tableLayoutPanel.Controls.Add(this.buttonNext, 3, 3);
            this.tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel.Margin = new System.Windows.Forms.Padding(5);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 5;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel.Size = new System.Drawing.Size(642, 435);
            this.tableLayoutPanel.TabIndex = 0;
            // 
            // labelHeader
            // 
            this.tableLayoutPanel.SetColumnSpan(this.labelHeader, 3);
            this.labelHeader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelHeader.Location = new System.Drawing.Point(37, 43);
            this.labelHeader.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelHeader.Name = "labelHeader";
            this.labelHeader.Size = new System.Drawing.Size(566, 174);
            this.labelHeader.TabIndex = 0;
            this.labelHeader.Text = "Neuer Spieler";
            this.labelHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // playerNameControl
            // 
            this.playerNameControl.BackColor = System.Drawing.Color.Black;
            this.tableLayoutPanel.SetColumnSpan(this.playerNameControl, 3);
            this.playerNameControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.playerNameControl.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playerNameControl.ForeColor = System.Drawing.Color.White;
            this.playerNameControl.Location = new System.Drawing.Point(37, 222);
            this.playerNameControl.Margin = new System.Windows.Forms.Padding(5);
            this.playerNameControl.Name = "playerNameControl";
            this.playerNameControl.PlayerName = "";
            this.playerNameControl.Size = new System.Drawing.Size(566, 55);
            this.playerNameControl.TabIndex = 1;
            this.playerNameControl.PlayerNameChanged += new System.EventHandler(this.PlayerNameControlPlayerNameChanged);
            // 
            // buttonStart
            // 
            this.buttonStart.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.buttonStart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonStart.Enabled = false;
            this.buttonStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonStart.Location = new System.Drawing.Point(35, 285);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(250, 59);
            this.buttonStart.TabIndex = 3;
            this.buttonStart.Text = "Start";
            this.buttonStart.UseVisualStyleBackColor = false;
            this.buttonStart.Click += new System.EventHandler(this.ButtonStartClick);
            // 
            // buttonNext
            // 
            this.buttonNext.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.buttonNext.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonNext.Enabled = false;
            this.buttonNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonNext.Location = new System.Drawing.Point(355, 285);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(250, 59);
            this.buttonNext.TabIndex = 2;
            this.buttonNext.Text = "Nächster »";
            this.buttonNext.UseVisualStyleBackColor = false;
            this.buttonNext.Click += new System.EventHandler(this.ButtonNextClick);
            // 
            // EnterPlayerControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.Controls.Add(this.tableLayoutPanel);
            this.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.Name = "EnterPlayerControl";
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
