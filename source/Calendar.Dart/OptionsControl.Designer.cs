namespace Calendar.Dart
{
    partial class OptionsControl
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
            this.dartButtonConstant = new Calendar.Dart.DartButton();
            this.dartButtonLinear = new Calendar.Dart.DartButton();
            this.dartButtonFactor = new Calendar.Dart.DartButton();
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
            this.tableLayoutPanel.Controls.Add(this.dartButtonConstant, 1, 2);
            this.tableLayoutPanel.Controls.Add(this.dartButtonLinear, 2, 2);
            this.tableLayoutPanel.Controls.Add(this.dartButtonFactor, 3, 2);
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
            // dartButtonConstant
            // 
            this.dartButtonConstant.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dartButtonConstant.Location = new System.Drawing.Point(44, 276);
            this.dartButtonConstant.Name = "dartButtonConstant";
            this.dartButtonConstant.Size = new System.Drawing.Size(240, 65);
            this.dartButtonConstant.TabIndex = 0;
            this.dartButtonConstant.Text = "1.000";
            this.dartButtonConstant.Click += new System.EventHandler(this.DartButtonConstantClick);
            // 
            // dartButtonLinear
            // 
            this.dartButtonLinear.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dartButtonLinear.Location = new System.Drawing.Point(290, 276);
            this.dartButtonLinear.Name = "dartButtonLinear";
            this.dartButtonLinear.Size = new System.Drawing.Size(240, 65);
            this.dartButtonLinear.TabIndex = 1;
            this.dartButtonLinear.Text = "+100";
            this.dartButtonLinear.UseVisualStyleBackColor = false;
            this.dartButtonLinear.Click += new System.EventHandler(this.DartButtonLinearClick);
            // 
            // dartButtonFactor
            // 
            this.dartButtonFactor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dartButtonFactor.Location = new System.Drawing.Point(536, 276);
            this.dartButtonFactor.Name = "dartButtonFactor";
            this.dartButtonFactor.Size = new System.Drawing.Size(240, 65);
            this.dartButtonFactor.TabIndex = 2;
            this.dartButtonFactor.Text = "+10%";
            this.dartButtonFactor.Click += new System.EventHandler(this.DartButtonFactorClick);
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
            // OptionsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.Controls.Add(this.tableLayoutPanel);
            this.Name = "OptionsControl";
            this.Size = new System.Drawing.Size(821, 534);
            this.Resize += new System.EventHandler(this.OptionsControlResize);
            this.tableLayoutPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private DartButton dartButtonConstant;
        private DartButton dartButtonLinear;
        private DartButton dartButtonFactor;
        private System.Windows.Forms.Label labelCaption;
    }
}
