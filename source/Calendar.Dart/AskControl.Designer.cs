namespace Calendar.Dart
{
    partial class AskControl
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
            this.dartButtonLeft = new Calendar.Dart.DartButton();
            this.dartButtonRight = new Calendar.Dart.DartButton();
            this.labelMessage = new System.Windows.Forms.Label();
            this.tableLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel.ColumnCount = 5;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.692307F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 38.46154F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.692307F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 38.46154F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.692307F));
            this.tableLayoutPanel.Controls.Add(this.dartButtonLeft, 1, 2);
            this.tableLayoutPanel.Controls.Add(this.dartButtonRight, 3, 2);
            this.tableLayoutPanel.Controls.Add(this.labelMessage, 1, 1);
            this.tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel.Font = new System.Drawing.Font("Calibri", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel.Margin = new System.Windows.Forms.Padding(5);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 4;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.692307F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 53.91499F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.88367F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 22.37136F));
            this.tableLayoutPanel.Size = new System.Drawing.Size(642, 435);
            this.tableLayoutPanel.TabIndex = 0;
            // 
            // dartButtonLeft
            // 
            this.dartButtonLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dartButtonLeft.Location = new System.Drawing.Point(54, 272);
            this.dartButtonLeft.Margin = new System.Windows.Forms.Padding(5);
            this.dartButtonLeft.Name = "dartButtonLeft";
            this.dartButtonLeft.Size = new System.Drawing.Size(236, 59);
            this.dartButtonLeft.TabIndex = 0;
            this.dartButtonLeft.Text = "dartButton1";
            this.dartButtonLeft.TextChanged += new System.EventHandler(this.ControlTextChanged);
            this.dartButtonLeft.Click += new System.EventHandler(this.DartButtonLeftClick);
            // 
            // dartButtonRight
            // 
            this.dartButtonRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dartButtonRight.Location = new System.Drawing.Point(349, 272);
            this.dartButtonRight.Margin = new System.Windows.Forms.Padding(5);
            this.dartButtonRight.Name = "dartButtonRight";
            this.dartButtonRight.Size = new System.Drawing.Size(236, 59);
            this.dartButtonRight.TabIndex = 1;
            this.dartButtonRight.Text = "dartButton2";
            this.dartButtonRight.TextChanged += new System.EventHandler(this.ControlTextChanged);
            this.dartButtonRight.Click += new System.EventHandler(this.DartButtonRightClick);
            // 
            // labelMessage
            // 
            this.tableLayoutPanel.SetColumnSpan(this.labelMessage, 3);
            this.labelMessage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelMessage.Location = new System.Drawing.Point(54, 33);
            this.labelMessage.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelMessage.Name = "labelMessage";
            this.labelMessage.Size = new System.Drawing.Size(531, 234);
            this.labelMessage.TabIndex = 2;
            this.labelMessage.Text = "Message";
            this.labelMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelMessage.TextChanged += new System.EventHandler(this.ControlTextChanged);
            // 
            // AskControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.Controls.Add(this.tableLayoutPanel);
            this.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.Name = "AskControl";
            this.Resize += new System.EventHandler(this.AskControlResize);
            this.tableLayoutPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private DartButton dartButtonLeft;
        private DartButton dartButtonRight;
        private System.Windows.Forms.Label labelMessage;
    }
}
