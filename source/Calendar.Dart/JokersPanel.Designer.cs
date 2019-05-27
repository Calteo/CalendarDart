namespace Calendar.Dart
{
    partial class JokersPanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(JokersPanel));
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.labelCaption = new System.Windows.Forms.Label();
            this.buttonNext = new Calendar.Dart.DartButton();
            this.jokerControl1 = new Calendar.Dart.JokerControl();
            this.jokerControl2 = new Calendar.Dart.JokerControl();
            this.jokerControl3 = new Calendar.Dart.JokerControl();
            this.jokerControl4 = new Calendar.Dart.JokerControl();
            this.jokerControl5 = new Calendar.Dart.JokerControl();
            this.jokerControl6 = new Calendar.Dart.JokerControl();
            this.jokerControl7 = new Calendar.Dart.JokerControl();
            this.jokerControl8 = new Calendar.Dart.JokerControl();
            this.tableLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel
            // 
            resources.ApplyResources(this.tableLayoutPanel, "tableLayoutPanel");
            this.tableLayoutPanel.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel.Controls.Add(this.labelCaption, 1, 1);
            this.tableLayoutPanel.Controls.Add(this.buttonNext, 3, 6);
            this.tableLayoutPanel.Controls.Add(this.jokerControl1, 1, 2);
            this.tableLayoutPanel.Controls.Add(this.jokerControl2, 3, 2);
            this.tableLayoutPanel.Controls.Add(this.jokerControl3, 1, 3);
            this.tableLayoutPanel.Controls.Add(this.jokerControl4, 3, 3);
            this.tableLayoutPanel.Controls.Add(this.jokerControl5, 1, 4);
            this.tableLayoutPanel.Controls.Add(this.jokerControl6, 3, 4);
            this.tableLayoutPanel.Controls.Add(this.jokerControl7, 1, 5);
            this.tableLayoutPanel.Controls.Add(this.jokerControl8, 3, 5);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            // 
            // labelCaption
            // 
            resources.ApplyResources(this.labelCaption, "labelCaption");
            this.tableLayoutPanel.SetColumnSpan(this.labelCaption, 3);
            this.labelCaption.Name = "labelCaption";
            // 
            // buttonNext
            // 
            resources.ApplyResources(this.buttonNext, "buttonNext");
            this.buttonNext.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.UseVisualStyleBackColor = false;
            this.buttonNext.Click += new System.EventHandler(this.ButtonNextClick);
            // 
            // jokerControl1
            // 
            resources.ApplyResources(this.jokerControl1, "jokerControl1");
            this.jokerControl1.BackColor = System.Drawing.Color.Black;
            this.jokerControl1.ForeColor = System.Drawing.Color.White;
            this.jokerControl1.Name = "jokerControl1";
            // 
            // jokerControl2
            // 
            resources.ApplyResources(this.jokerControl2, "jokerControl2");
            this.jokerControl2.BackColor = System.Drawing.Color.Black;
            this.jokerControl2.ForeColor = System.Drawing.Color.White;
            this.jokerControl2.Name = "jokerControl2";
            // 
            // jokerControl3
            // 
            resources.ApplyResources(this.jokerControl3, "jokerControl3");
            this.jokerControl3.BackColor = System.Drawing.Color.Black;
            this.jokerControl3.ForeColor = System.Drawing.Color.White;
            this.jokerControl3.Name = "jokerControl3";
            // 
            // jokerControl4
            // 
            resources.ApplyResources(this.jokerControl4, "jokerControl4");
            this.jokerControl4.BackColor = System.Drawing.Color.Black;
            this.jokerControl4.ForeColor = System.Drawing.Color.White;
            this.jokerControl4.Name = "jokerControl4";
            // 
            // jokerControl5
            // 
            resources.ApplyResources(this.jokerControl5, "jokerControl5");
            this.jokerControl5.BackColor = System.Drawing.Color.Black;
            this.jokerControl5.ForeColor = System.Drawing.Color.White;
            this.jokerControl5.Name = "jokerControl5";
            // 
            // jokerControl6
            // 
            resources.ApplyResources(this.jokerControl6, "jokerControl6");
            this.jokerControl6.BackColor = System.Drawing.Color.Black;
            this.jokerControl6.ForeColor = System.Drawing.Color.White;
            this.jokerControl6.Name = "jokerControl6";
            // 
            // jokerControl7
            // 
            resources.ApplyResources(this.jokerControl7, "jokerControl7");
            this.jokerControl7.BackColor = System.Drawing.Color.Black;
            this.jokerControl7.ForeColor = System.Drawing.Color.White;
            this.jokerControl7.Name = "jokerControl7";
            // 
            // jokerControl8
            // 
            resources.ApplyResources(this.jokerControl8, "jokerControl8");
            this.jokerControl8.BackColor = System.Drawing.Color.Black;
            this.jokerControl8.ForeColor = System.Drawing.Color.White;
            this.jokerControl8.Name = "jokerControl8";
            // 
            // JokersPanel
            // 
            resources.ApplyResources(this, "$this");
            this.Controls.Add(this.tableLayoutPanel);
            this.Name = "JokersPanel";
            this.Resize += new System.EventHandler(this.JokersControlResize);
            this.tableLayoutPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private System.Windows.Forms.Label labelCaption;
        private DartButton buttonNext;
        private JokerControl jokerControl1;
        private JokerControl jokerControl2;
        private JokerControl jokerControl3;
        private JokerControl jokerControl4;
        private JokerControl jokerControl5;
        private JokerControl jokerControl6;
        private JokerControl jokerControl7;
        private JokerControl jokerControl8;
    }
}
