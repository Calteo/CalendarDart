namespace Calendar.Dart
{
    partial class GuessingPanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GuessingPanel));
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.labelQuestion = new System.Windows.Forms.Label();
            this.buttonNext = new Calendar.Dart.DartButton();
            this.guessControl1 = new Calendar.Dart.GuessControl();
            this.guessControl2 = new Calendar.Dart.GuessControl();
            this.guessControl3 = new Calendar.Dart.GuessControl();
            this.guessControl4 = new Calendar.Dart.GuessControl();
            this.tableLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel
            // 
            resources.ApplyResources(this.tableLayoutPanel, "tableLayoutPanel");
            this.tableLayoutPanel.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel.Controls.Add(this.labelQuestion, 1, 1);
            this.tableLayoutPanel.Controls.Add(this.buttonNext, 3, 6);
            this.tableLayoutPanel.Controls.Add(this.guessControl1, 1, 2);
            this.tableLayoutPanel.Controls.Add(this.guessControl2, 1, 3);
            this.tableLayoutPanel.Controls.Add(this.guessControl3, 1, 4);
            this.tableLayoutPanel.Controls.Add(this.guessControl4, 1, 5);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            // 
            // labelQuestion
            // 
            resources.ApplyResources(this.labelQuestion, "labelQuestion");
            this.tableLayoutPanel.SetColumnSpan(this.labelQuestion, 3);
            this.labelQuestion.Name = "labelQuestion";
            // 
            // buttonNext
            // 
            resources.ApplyResources(this.buttonNext, "buttonNext");
            this.buttonNext.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.UseVisualStyleBackColor = false;
            this.buttonNext.Click += new System.EventHandler(this.ButtonNextClick);
            // 
            // guessControl1
            // 
            resources.ApplyResources(this.guessControl1, "guessControl1");
            this.guessControl1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel.SetColumnSpan(this.guessControl1, 3);
            this.guessControl1.ForeColor = System.Drawing.Color.White;
            this.guessControl1.Name = "guessControl1";
            this.guessControl1.Guessed += new System.EventHandler(this.GuessControlGuessed);
            // 
            // guessControl2
            // 
            resources.ApplyResources(this.guessControl2, "guessControl2");
            this.guessControl2.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel.SetColumnSpan(this.guessControl2, 3);
            this.guessControl2.ForeColor = System.Drawing.Color.White;
            this.guessControl2.Name = "guessControl2";
            this.guessControl2.Guessed += new System.EventHandler(this.GuessControlGuessed);
            // 
            // guessControl3
            // 
            resources.ApplyResources(this.guessControl3, "guessControl3");
            this.guessControl3.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel.SetColumnSpan(this.guessControl3, 3);
            this.guessControl3.ForeColor = System.Drawing.Color.White;
            this.guessControl3.Name = "guessControl3";
            this.guessControl3.Guessed += new System.EventHandler(this.GuessControlGuessed);
            // 
            // guessControl4
            // 
            resources.ApplyResources(this.guessControl4, "guessControl4");
            this.guessControl4.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel.SetColumnSpan(this.guessControl4, 3);
            this.guessControl4.ForeColor = System.Drawing.Color.White;
            this.guessControl4.Name = "guessControl4";
            this.guessControl4.Guessed += new System.EventHandler(this.GuessControlGuessed);
            // 
            // GuessingPanel
            // 
            resources.ApplyResources(this, "$this");
            this.Controls.Add(this.tableLayoutPanel);
            this.Name = "GuessingPanel";
            this.Resize += new System.EventHandler(this.GuessingControlResize);
            this.tableLayoutPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private System.Windows.Forms.Label labelQuestion;
        private DartButton buttonNext;
        private GuessControl guessControl1;
        private GuessControl guessControl2;
        private GuessControl guessControl3;
        private GuessControl guessControl4;
    }
}
