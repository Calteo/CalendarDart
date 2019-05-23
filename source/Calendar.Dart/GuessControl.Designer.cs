namespace Calendar.Dart
{
    partial class GuessControl
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
            this.editBoxMonth = new System.Windows.Forms.TextBox();
            this.editBoxDay = new System.Windows.Forms.TextBox();
            this.labelPlayer = new System.Windows.Forms.Label();
            this.editBoxYear = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel.ColumnCount = 4;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 69F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel.Controls.Add(this.editBoxMonth, 0, 0);
            this.tableLayoutPanel.Controls.Add(this.editBoxDay, 0, 0);
            this.tableLayoutPanel.Controls.Add(this.labelPlayer, 0, 0);
            this.tableLayoutPanel.Controls.Add(this.editBoxYear, 1, 0);
            this.tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 1;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel.Size = new System.Drawing.Size(488, 65);
            this.tableLayoutPanel.TabIndex = 0;
            // 
            // editBoxMonth
            // 
            this.editBoxMonth.BackColor = System.Drawing.Color.Bisque;
            this.editBoxMonth.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.editBoxMonth.Dock = System.Windows.Forms.DockStyle.Fill;
            this.editBoxMonth.ForeColor = System.Drawing.Color.White;
            this.editBoxMonth.Location = new System.Drawing.Point(378, 3);
            this.editBoxMonth.MaxLength = 2;
            this.editBoxMonth.Name = "editBoxMonth";
            this.editBoxMonth.ShortcutsEnabled = false;
            this.editBoxMonth.Size = new System.Drawing.Size(33, 24);
            this.editBoxMonth.TabIndex = 2;
            this.editBoxMonth.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.editBoxMonth.WordWrap = false;
            this.editBoxMonth.TextChanged += new System.EventHandler(this.MaskedEditBoxTextChanged);
            // 
            // editBoxDay
            // 
            this.editBoxDay.BackColor = System.Drawing.Color.Bisque;
            this.editBoxDay.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.editBoxDay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.editBoxDay.ForeColor = System.Drawing.Color.White;
            this.editBoxDay.Location = new System.Drawing.Point(339, 3);
            this.editBoxDay.MaxLength = 2;
            this.editBoxDay.Name = "editBoxDay";
            this.editBoxDay.ShortcutsEnabled = false;
            this.editBoxDay.Size = new System.Drawing.Size(33, 24);
            this.editBoxDay.TabIndex = 1;
            this.editBoxDay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.editBoxDay.WordWrap = false;
            this.editBoxDay.TextChanged += new System.EventHandler(this.MaskedEditBoxTextChanged);
            // 
            // labelPlayer
            // 
            this.labelPlayer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelPlayer.Location = new System.Drawing.Point(3, 0);
            this.labelPlayer.Name = "labelPlayer";
            this.labelPlayer.Size = new System.Drawing.Size(330, 65);
            this.labelPlayer.TabIndex = 0;
            this.labelPlayer.Text = "Player";
            this.labelPlayer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // editBoxYear
            // 
            this.editBoxYear.BackColor = System.Drawing.Color.Bisque;
            this.editBoxYear.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.editBoxYear.Dock = System.Windows.Forms.DockStyle.Fill;
            this.editBoxYear.ForeColor = System.Drawing.Color.White;
            this.editBoxYear.Location = new System.Drawing.Point(417, 3);
            this.editBoxYear.MaxLength = 4;
            this.editBoxYear.Name = "editBoxYear";
            this.editBoxYear.ShortcutsEnabled = false;
            this.editBoxYear.Size = new System.Drawing.Size(68, 24);
            this.editBoxYear.TabIndex = 3;
            this.editBoxYear.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.editBoxYear.WordWrap = false;
            this.editBoxYear.TextChanged += new System.EventHandler(this.MaskedEditBoxTextChanged);
            // 
            // GuessControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.Controls.Add(this.tableLayoutPanel);
            this.Name = "GuessControl";
            this.Size = new System.Drawing.Size(488, 65);
            this.Resize += new System.EventHandler(this.GuessControlResize);
            this.tableLayoutPanel.ResumeLayout(false);
            this.tableLayoutPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private System.Windows.Forms.Label labelPlayer;
        private System.Windows.Forms.TextBox editBoxYear;
        private System.Windows.Forms.TextBox editBoxMonth;
        private System.Windows.Forms.TextBox editBoxDay;
    }
}
