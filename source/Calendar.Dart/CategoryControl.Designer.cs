namespace Calendar.Dart
{
    partial class CategoryControl
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
            this.dartButton1 = new Calendar.Dart.DartButton();
            this.dartButton2 = new Calendar.Dart.DartButton();
            this.dartButton3 = new Calendar.Dart.DartButton();
            this.dartButton4 = new Calendar.Dart.DartButton();
            this.labelPlayer = new System.Windows.Forms.Label();
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
            this.tableLayoutPanel.Controls.Add(this.labelCaption, 1, 1);
            this.tableLayoutPanel.Controls.Add(this.dartButton1, 1, 3);
            this.tableLayoutPanel.Controls.Add(this.dartButton2, 3, 3);
            this.tableLayoutPanel.Controls.Add(this.dartButton3, 1, 5);
            this.tableLayoutPanel.Controls.Add(this.dartButton4, 3, 5);
            this.tableLayoutPanel.Controls.Add(this.labelPlayer, 1, 2);
            this.tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 7;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.49425F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.51724F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.51724F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17.24138F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.747126F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17.24138F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17.24138F));
            this.tableLayoutPanel.Size = new System.Drawing.Size(758, 458);
            this.tableLayoutPanel.TabIndex = 0;
            // 
            // labelCaption
            // 
            this.tableLayoutPanel.SetColumnSpan(this.labelCaption, 3);
            this.labelCaption.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelCaption.Location = new System.Drawing.Point(40, 52);
            this.labelCaption.Name = "labelCaption";
            this.labelCaption.Size = new System.Drawing.Size(675, 71);
            this.labelCaption.TabIndex = 0;
            this.labelCaption.Text = "Kategorien";
            this.labelCaption.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dartButton1
            // 
            this.dartButton1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dartButton1.Location = new System.Drawing.Point(40, 197);
            this.dartButton1.Name = "dartButton1";
            this.dartButton1.Size = new System.Drawing.Size(297, 72);
            this.dartButton1.TabIndex = 1;
            this.dartButton1.Text = "dartButton1";
            this.dartButton1.Click += new System.EventHandler(this.ButtonCategoryClicked);
            // 
            // dartButton2
            // 
            this.dartButton2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dartButton2.Location = new System.Drawing.Point(418, 197);
            this.dartButton2.Name = "dartButton2";
            this.dartButton2.Size = new System.Drawing.Size(297, 72);
            this.dartButton2.TabIndex = 2;
            this.dartButton2.Text = "dartButton2";
            this.dartButton2.Click += new System.EventHandler(this.ButtonCategoryClicked);
            // 
            // dartButton3
            // 
            this.dartButton3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dartButton3.Location = new System.Drawing.Point(40, 301);
            this.dartButton3.Name = "dartButton3";
            this.dartButton3.Size = new System.Drawing.Size(297, 72);
            this.dartButton3.TabIndex = 3;
            this.dartButton3.Text = "dartButton3";
            this.dartButton3.Click += new System.EventHandler(this.ButtonCategoryClicked);
            // 
            // dartButton4
            // 
            this.dartButton4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dartButton4.Location = new System.Drawing.Point(418, 301);
            this.dartButton4.Name = "dartButton4";
            this.dartButton4.Size = new System.Drawing.Size(297, 72);
            this.dartButton4.TabIndex = 4;
            this.dartButton4.Text = "dartButton4";
            this.dartButton4.Click += new System.EventHandler(this.ButtonCategoryClicked);
            // 
            // labelPlayer
            // 
            this.tableLayoutPanel.SetColumnSpan(this.labelPlayer, 3);
            this.labelPlayer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelPlayer.Location = new System.Drawing.Point(40, 123);
            this.labelPlayer.Name = "labelPlayer";
            this.labelPlayer.Size = new System.Drawing.Size(675, 71);
            this.labelPlayer.TabIndex = 5;
            this.labelPlayer.Text = "Spieler";
            this.labelPlayer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CategoryControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.Controls.Add(this.tableLayoutPanel);
            this.Name = "CategoryControl";
            this.Size = new System.Drawing.Size(758, 458);
            this.Resize += new System.EventHandler(this.CategoryControlResize);
            this.tableLayoutPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private System.Windows.Forms.Label labelCaption;
        private DartButton dartButton1;
        private DartButton dartButton2;
        private DartButton dartButton3;
        private DartButton dartButton4;
        private System.Windows.Forms.Label labelPlayer;
    }
}
