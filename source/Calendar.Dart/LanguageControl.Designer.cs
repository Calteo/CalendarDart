namespace Calendar.Dart
{
    partial class LanguageControl
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
            this.dartButton1 = new Calendar.Dart.DartButton();
            this.dartButton2 = new Calendar.Dart.DartButton();
            this.SuspendLayout();
            // 
            // dartButton1
            // 
            this.dartButton1.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.dartButton1.FlatAppearance.BorderSize = 0;
            this.dartButton1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Green;
            this.dartButton1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Orange;
            this.dartButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dartButton1.Location = new System.Drawing.Point(111, 171);
            this.dartButton1.Name = "dartButton1";
            this.dartButton1.Size = new System.Drawing.Size(128, 50);
            this.dartButton1.TabIndex = 0;
            this.dartButton1.Tag = "de";
            this.dartButton1.Text = "dartButton1";
            this.dartButton1.UseVisualStyleBackColor = false;
            this.dartButton1.Click += new System.EventHandler(this.dartButton1_Click);
            // 
            // dartButton2
            // 
            this.dartButton2.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.dartButton2.FlatAppearance.BorderSize = 0;
            this.dartButton2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Green;
            this.dartButton2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Orange;
            this.dartButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dartButton2.Location = new System.Drawing.Point(278, 171);
            this.dartButton2.Name = "dartButton2";
            this.dartButton2.Size = new System.Drawing.Size(128, 50);
            this.dartButton2.TabIndex = 1;
            this.dartButton2.Tag = "en";
            this.dartButton2.Text = "dartButton2";
            this.dartButton2.UseVisualStyleBackColor = false;
            // 
            // LanguageControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.Controls.Add(this.dartButton2);
            this.Controls.Add(this.dartButton1);
            this.Name = "LanguageControl";
            this.Size = new System.Drawing.Size(705, 447);
            this.ResumeLayout(false);

        }

        #endregion

        private DartButton dartButton1;
        private DartButton dartButton2;
    }
}
