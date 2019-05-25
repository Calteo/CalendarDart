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
            this.tableLayoutPanel.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel.ColumnCount = 5;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel.Controls.Add(this.buttonConstant, 1, 2);
            this.tableLayoutPanel.Controls.Add(this.buttonLinear, 2, 2);
            this.tableLayoutPanel.Controls.Add(this.buttonFactor, 3, 2);
            this.tableLayoutPanel.Controls.Add(this.labelCaption, 1, 1);
            this.tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 5;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.29894F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 41.08004F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.30762F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 19.86499F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.44841F));
            this.tableLayoutPanel.Size = new System.Drawing.Size(821, 534);
            this.tableLayoutPanel.TabIndex = 0;
            // 
            // buttonConstant
            // 
            this.buttonConstant.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.buttonConstant.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonConstant.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonConstant.Location = new System.Drawing.Point(44, 276);
            this.buttonConstant.Name = "buttonConstant";
            this.buttonConstant.Size = new System.Drawing.Size(240, 65);
            this.buttonConstant.TabIndex = 0;
            this.buttonConstant.Text = "1.000";
            this.buttonConstant.UseVisualStyleBackColor = false;
            this.buttonConstant.Click += new System.EventHandler(this.ButtonConstantClick);
            // 
            // buttonLinear
            // 
            this.buttonLinear.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.buttonLinear.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonLinear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLinear.Location = new System.Drawing.Point(290, 276);
            this.buttonLinear.Name = "buttonLinear";
            this.buttonLinear.Size = new System.Drawing.Size(240, 65);
            this.buttonLinear.TabIndex = 1;
            this.buttonLinear.Text = "+100";
            this.buttonLinear.UseVisualStyleBackColor = false;
            this.buttonLinear.Click += new System.EventHandler(this.ButtonLinearClick);
            // 
            // buttonFactor
            // 
            this.buttonFactor.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.buttonFactor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonFactor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonFactor.Location = new System.Drawing.Point(536, 276);
            this.buttonFactor.Name = "buttonFactor";
            this.buttonFactor.Size = new System.Drawing.Size(240, 65);
            this.buttonFactor.TabIndex = 2;
            this.buttonFactor.Text = "+10%";
            this.buttonFactor.UseVisualStyleBackColor = false;
            this.buttonFactor.Click += new System.EventHandler(this.ButtonFactorClick);
            // 
            // labelCaption
            // 
            this.tableLayoutPanel.SetColumnSpan(this.labelCaption, 3);
            this.labelCaption.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelCaption.Location = new System.Drawing.Point(44, 54);
            this.labelCaption.Name = "labelCaption";
            this.labelCaption.Size = new System.Drawing.Size(732, 219);
            this.labelCaption.TabIndex = 3;
            this.labelCaption.Text = "Punkte";
            this.labelCaption.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // OptionsPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.Controls.Add(this.tableLayoutPanel);
            this.Name = "OptionsPanel";
            this.Size = new System.Drawing.Size(821, 534);
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
