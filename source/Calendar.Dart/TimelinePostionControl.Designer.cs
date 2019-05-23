namespace Calendar.Dart
{
    partial class TimelinePostionControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TimelinePostionControl));
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.verticalLabelControlName = new Calendar.Dart.VerticalLabelControl();
            this.verticalLabelControlGuess = new Calendar.Dart.VerticalLabelControl();
            this.tableLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.ColumnCount = 1;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel.Controls.Add(this.verticalLabelControlName, 0, 1);
            this.tableLayoutPanel.Controls.Add(this.verticalLabelControlGuess, 0, 0);
            this.tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 2;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel.Size = new System.Drawing.Size(417, 371);
            this.tableLayoutPanel.TabIndex = 0;
            // 
            // verticalLabelControlName
            // 
            this.verticalLabelControlName.Alignment = System.Drawing.StringAlignment.Near;
            this.verticalLabelControlName.BackColor = System.Drawing.Color.Transparent;
            this.verticalLabelControlName.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("verticalLabelControlName.BackgroundImage")));
            this.verticalLabelControlName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.verticalLabelControlName.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.verticalLabelControlName.ForeColor = System.Drawing.Color.White;
            this.verticalLabelControlName.Location = new System.Drawing.Point(5, 153);
            this.verticalLabelControlName.Margin = new System.Windows.Forms.Padding(5);
            this.verticalLabelControlName.Name = "verticalLabelControlName";
            this.verticalLabelControlName.Size = new System.Drawing.Size(407, 213);
            this.verticalLabelControlName.TabIndex = 0;
            // 
            // verticalLabelControlGuess
            // 
            this.verticalLabelControlGuess.Alignment = System.Drawing.StringAlignment.Far;
            this.verticalLabelControlGuess.BackColor = System.Drawing.Color.Transparent;
            this.verticalLabelControlGuess.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("verticalLabelControlGuess.BackgroundImage")));
            this.verticalLabelControlGuess.Dock = System.Windows.Forms.DockStyle.Fill;
            this.verticalLabelControlGuess.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.verticalLabelControlGuess.ForeColor = System.Drawing.Color.White;
            this.verticalLabelControlGuess.Location = new System.Drawing.Point(5, 5);
            this.verticalLabelControlGuess.Margin = new System.Windows.Forms.Padding(5);
            this.verticalLabelControlGuess.Name = "verticalLabelControlGuess";
            this.verticalLabelControlGuess.Size = new System.Drawing.Size(407, 138);
            this.verticalLabelControlGuess.TabIndex = 1;
            // 
            // TimelinePostionControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.Controls.Add(this.tableLayoutPanel);
            this.Name = "TimelinePostionControl";
            this.Size = new System.Drawing.Size(417, 371);
            this.Resize += new System.EventHandler(this.TimelinePostionControlResize);
            this.tableLayoutPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private VerticalLabelControl verticalLabelControlName;
        private VerticalLabelControl verticalLabelControlGuess;
    }
}
