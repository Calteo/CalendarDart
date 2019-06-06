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
            this.editBox2 = new System.Windows.Forms.TextBox();
            this.editBox1 = new System.Windows.Forms.TextBox();
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
            this.tableLayoutPanel.Controls.Add(this.editBox2, 0, 0);
            this.tableLayoutPanel.Controls.Add(this.editBox1, 0, 0);
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
            // editBox2
            // 
            this.editBox2.BackColor = System.Drawing.Color.Bisque;
            this.editBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.editBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.editBox2.ForeColor = System.Drawing.Color.White;
            this.editBox2.Location = new System.Drawing.Point(378, 3);
            this.editBox2.MaxLength = 2;
            this.editBox2.Name = "editBox2";
            this.editBox2.ShortcutsEnabled = false;
            this.editBox2.Size = new System.Drawing.Size(33, 24);
            this.editBox2.TabIndex = 2;
            this.editBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.editBox2.WordWrap = false;
            this.editBox2.TextChanged += new System.EventHandler(this.EditBoxTextChanged);
            // 
            // editBox1
            // 
            this.editBox1.BackColor = System.Drawing.Color.Bisque;
            this.editBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.editBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.editBox1.ForeColor = System.Drawing.Color.White;
            this.editBox1.Location = new System.Drawing.Point(339, 3);
            this.editBox1.MaxLength = 2;
            this.editBox1.Name = "editBox1";
            this.editBox1.ShortcutsEnabled = false;
            this.editBox1.Size = new System.Drawing.Size(33, 24);
            this.editBox1.TabIndex = 1;
            this.editBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.editBox1.WordWrap = false;
            this.editBox1.TextChanged += new System.EventHandler(this.EditBoxTextChanged);
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
            this.editBoxYear.TextChanged += new System.EventHandler(this.EditBoxTextChanged);
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
        private System.Windows.Forms.TextBox editBox2;
        private System.Windows.Forms.TextBox editBox1;
    }
}
