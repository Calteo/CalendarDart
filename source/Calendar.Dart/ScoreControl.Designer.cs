namespace Calendar.Dart
{
    partial class ScoreControl
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
            this.labelCaption = new System.Windows.Forms.Label();
            this.dartButtonExit = new Calendar.Dart.DartButton();
            this.dartButtonNext = new Calendar.Dart.DartButton();
            this.tableLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel.ColumnCount = 5;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2F));
            this.tableLayoutPanel.Controls.Add(this.labelCaption, 1, 1);
            this.tableLayoutPanel.Controls.Add(this.dartButtonExit, 1, 7);
            this.tableLayoutPanel.Controls.Add(this.dartButtonNext, 3, 7);
            this.tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 9;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4.830918F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.62802F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 21.25604F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.94203F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.62802F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.62802F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.62802F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.62802F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4.830918F));
            this.tableLayoutPanel.Size = new System.Drawing.Size(642, 435);
            this.tableLayoutPanel.TabIndex = 0;
            // 
            // labelCaption
            // 
            this.tableLayoutPanel.SetColumnSpan(this.labelCaption, 3);
            this.labelCaption.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelCaption.Font = new System.Drawing.Font("Ravie", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCaption.Location = new System.Drawing.Point(15, 21);
            this.labelCaption.Name = "labelCaption";
            this.labelCaption.Size = new System.Drawing.Size(608, 46);
            this.labelCaption.TabIndex = 1;
            this.labelCaption.Text = "Hall of Fame";
            this.labelCaption.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dartButtonExit
            // 
            this.dartButtonExit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dartButtonExit.Location = new System.Drawing.Point(15, 369);
            this.dartButtonExit.Name = "dartButtonExit";
            this.dartButtonExit.Size = new System.Drawing.Size(282, 40);
            this.dartButtonExit.TabIndex = 0;
            this.dartButtonExit.Text = "Ende";
            this.dartButtonExit.Click += new System.EventHandler(this.ButtonExitClick);
            // 
            // dartButtonNext
            // 
            this.dartButtonNext.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dartButtonNext.Location = new System.Drawing.Point(341, 369);
            this.dartButtonNext.Name = "dartButtonNext";
            this.dartButtonNext.Size = new System.Drawing.Size(282, 40);
            this.dartButtonNext.TabIndex = 1;
            this.dartButtonNext.Text = "Nächste Runde »";
            this.dartButtonNext.Click += new System.EventHandler(this.ButtonNextClick);
            // 
            // ScoreControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.Controls.Add(this.tableLayoutPanel);
            this.Name = "ScoreControl";
            this.Resize += new System.EventHandler(this.ScoreControlResize);
            this.tableLayoutPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private DartButton dartButtonExit;
        private DartButton dartButtonNext;
        private System.Windows.Forms.Label labelCaption;
    }
}
