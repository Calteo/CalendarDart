namespace Calendar.Dart
{
    partial class GuessingControl
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
            this.dartButtonNext = new Calendar.Dart.DartButton();
            this.guessControl1 = new Calendar.Dart.GuessControl();
            this.guessControl2 = new Calendar.Dart.GuessControl();
            this.guessControl3 = new Calendar.Dart.GuessControl();
            this.guessControl4 = new Calendar.Dart.GuessControl();
            this.tableLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel.ColumnCount = 5;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 47F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 47F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2F));
            this.tableLayoutPanel.Controls.Add(this.labelCaption, 1, 1);
            this.tableLayoutPanel.Controls.Add(this.dartButtonNext, 3, 6);
            this.tableLayoutPanel.Controls.Add(this.guessControl1, 1, 2);
            this.tableLayoutPanel.Controls.Add(this.guessControl2, 1, 3);
            this.tableLayoutPanel.Controls.Add(this.guessControl3, 1, 4);
            this.tableLayoutPanel.Controls.Add(this.guessControl4, 1, 5);
            this.tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 8;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.347594F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.40107F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.36898F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.36898F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.36898F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.36898F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.69519F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.080214F));
            this.tableLayoutPanel.Size = new System.Drawing.Size(642, 435);
            this.tableLayoutPanel.TabIndex = 0;
            // 
            // labelCaption
            // 
            this.tableLayoutPanel.SetColumnSpan(this.labelCaption, 3);
            this.labelCaption.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelCaption.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCaption.Location = new System.Drawing.Point(15, 23);
            this.labelCaption.Name = "labelCaption";
            this.labelCaption.Size = new System.Drawing.Size(608, 110);
            this.labelCaption.TabIndex = 1;
            this.labelCaption.Text = "Jokers";
            this.labelCaption.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dartButtonNext
            // 
            this.dartButtonNext.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dartButtonNext.Location = new System.Drawing.Point(328, 368);
            this.dartButtonNext.Name = "dartButtonNext";
            this.dartButtonNext.Size = new System.Drawing.Size(295, 40);
            this.dartButtonNext.TabIndex = 2;
            this.dartButtonNext.Text = "Weiter »";
            this.dartButtonNext.Click += new System.EventHandler(this.ButtonNextClick);
            // 
            // guessControl1
            // 
            this.guessControl1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel.SetColumnSpan(this.guessControl1, 3);
            this.guessControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guessControl1.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guessControl1.ForeColor = System.Drawing.Color.White;
            this.guessControl1.Location = new System.Drawing.Point(17, 138);
            this.guessControl1.Margin = new System.Windows.Forms.Padding(5);
            this.guessControl1.Name = "guessControl1";
            this.guessControl1.Size = new System.Drawing.Size(604, 48);
            this.guessControl1.TabIndex = 3;
            this.guessControl1.Guessed += new System.EventHandler(this.GuessControlGuessed);
            // 
            // guessControl2
            // 
            this.guessControl2.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel.SetColumnSpan(this.guessControl2, 3);
            this.guessControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guessControl2.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guessControl2.ForeColor = System.Drawing.Color.White;
            this.guessControl2.Location = new System.Drawing.Point(17, 196);
            this.guessControl2.Margin = new System.Windows.Forms.Padding(5);
            this.guessControl2.Name = "guessControl2";
            this.guessControl2.Size = new System.Drawing.Size(604, 48);
            this.guessControl2.TabIndex = 4;
            this.guessControl2.Guessed += new System.EventHandler(this.GuessControlGuessed);
            // 
            // guessControl3
            // 
            this.guessControl3.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel.SetColumnSpan(this.guessControl3, 3);
            this.guessControl3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guessControl3.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guessControl3.ForeColor = System.Drawing.Color.White;
            this.guessControl3.Location = new System.Drawing.Point(17, 254);
            this.guessControl3.Margin = new System.Windows.Forms.Padding(5);
            this.guessControl3.Name = "guessControl3";
            this.guessControl3.Size = new System.Drawing.Size(604, 48);
            this.guessControl3.TabIndex = 5;
            this.guessControl3.Guessed += new System.EventHandler(this.GuessControlGuessed);
            // 
            // guessControl4
            // 
            this.guessControl4.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel.SetColumnSpan(this.guessControl4, 3);
            this.guessControl4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guessControl4.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guessControl4.ForeColor = System.Drawing.Color.White;
            this.guessControl4.Location = new System.Drawing.Point(17, 312);
            this.guessControl4.Margin = new System.Windows.Forms.Padding(5);
            this.guessControl4.Name = "guessControl4";
            this.guessControl4.Size = new System.Drawing.Size(604, 48);
            this.guessControl4.TabIndex = 6;
            this.guessControl4.Guessed += new System.EventHandler(this.GuessControlGuessed);
            // 
            // GuessingControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.Controls.Add(this.tableLayoutPanel);
            this.Name = "GuessingControl";
            this.Resize += new System.EventHandler(this.GuessingControlResize);
            this.tableLayoutPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private System.Windows.Forms.Label labelCaption;
        private DartButton dartButtonNext;
        private GuessControl guessControl1;
        private GuessControl guessControl2;
        private GuessControl guessControl3;
        private GuessControl guessControl4;
    }
}
