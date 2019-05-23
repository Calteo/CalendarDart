namespace Calendar.Dart
{
    partial class RoundControl
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
            this.dartButtonNext = new Calendar.Dart.DartButton();
            this.labelPoints = new System.Windows.Forms.Label();
            this.labelRound = new System.Windows.Forms.Label();
            this.tableLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel.ColumnCount = 4;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel.Controls.Add(this.dartButtonNext, 2, 4);
            this.tableLayoutPanel.Controls.Add(this.labelPoints, 1, 2);
            this.tableLayoutPanel.Controls.Add(this.labelRound, 1, 1);
            this.tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 6;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 21.37742F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17.63637F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17.10193F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18.52709F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.44643F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.91075F));
            this.tableLayoutPanel.Size = new System.Drawing.Size(794, 558);
            this.tableLayoutPanel.TabIndex = 0;
            // 
            // dartButtonNext
            //             
            this.dartButtonNext.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dartButtonNext.Location = new System.Drawing.Point(399, 418);
            this.dartButtonNext.Name = "dartButtonNext";
            this.dartButtonNext.Size = new System.Drawing.Size(351, 52);
            this.dartButtonNext.TabIndex = 0;
            this.dartButtonNext.Text = "Weiter »";
            this.dartButtonNext.Click += new System.EventHandler(this.DartButtonNextClick);
            // 
            // labelPoints
            // 
            this.tableLayoutPanel.SetColumnSpan(this.labelPoints, 2);
            this.labelPoints.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelPoints.Location = new System.Drawing.Point(42, 217);
            this.labelPoints.Name = "labelPoints";
            this.labelPoints.Size = new System.Drawing.Size(708, 95);
            this.labelPoints.TabIndex = 2;
            this.labelPoints.Text = "1.000 Punkte";
            this.labelPoints.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelRound
            // 
            this.tableLayoutPanel.SetColumnSpan(this.labelRound, 2);
            this.labelRound.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelRound.Location = new System.Drawing.Point(42, 119);
            this.labelRound.Name = "labelRound";
            this.labelRound.Size = new System.Drawing.Size(708, 98);
            this.labelRound.TabIndex = 1;
            this.labelRound.Text = "Runde 1";
            this.labelRound.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // RoundControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.Controls.Add(this.tableLayoutPanel);
            this.Name = "RoundControl";
            this.Size = new System.Drawing.Size(794, 558);
            this.Resize += new System.EventHandler(this.RoundControlResize);
            this.tableLayoutPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private DartButton dartButtonNext;
        private System.Windows.Forms.Label labelPoints;
        private System.Windows.Forms.Label labelRound;
    }
}
