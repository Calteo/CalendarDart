namespace Calendar.Dart
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.titleControl = new Calendar.Dart.TitleControl();
            this.optionsControl = new Calendar.Dart.OptionsControl();
            this.roundControl = new Calendar.Dart.RoundControl();
            this.guessingControl = new Calendar.Dart.GuessingControl();
            this.questionControl = new Calendar.Dart.QuestionControl();
            this.jokersControl = new Calendar.Dart.JokersControl();
            this.categoryControl = new Calendar.Dart.CategoryControl();
            this.enterPlayerControl = new Calendar.Dart.EnterPlayerControl();
            this.askControl = new Calendar.Dart.AskControl();
            this.timelineControl = new Calendar.Dart.TimelineControl();
            this.pointsControl = new Calendar.Dart.PointsControl();
            this.scoreControl = new Calendar.Dart.ScoreControl();
            this.creditsControl = new Calendar.Dart.CreditsControl();
            this.selectGameControl = new Calendar.Dart.SelectGameControl();
            this.SuspendLayout();
            // 
            // titleControl
            // 
            this.titleControl.BackColor = System.Drawing.Color.Black;
            this.titleControl.BottomFraction = 0.3F;
            this.titleControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.titleControl.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleControl.ForeColor = System.Drawing.Color.White;
            this.titleControl.Location = new System.Drawing.Point(0, 0);
            this.titleControl.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.titleControl.Name = "titleControl";
            this.titleControl.Size = new System.Drawing.Size(802, 456);
            this.titleControl.TabIndex = 0;
            this.titleControl.TopFraction = 0.2F;
            this.titleControl.StartGame += new System.EventHandler(this.TitleControlStartGame);
            // 
            // optionsControl
            // 
            this.optionsControl.BackColor = System.Drawing.Color.Black;
            this.optionsControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.optionsControl.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optionsControl.ForeColor = System.Drawing.Color.White;
            this.optionsControl.Location = new System.Drawing.Point(0, 0);
            this.optionsControl.Margin = new System.Windows.Forms.Padding(5);
            this.optionsControl.Name = "optionsControl";
            this.optionsControl.Size = new System.Drawing.Size(802, 456);
            this.optionsControl.TabIndex = 13;
            this.optionsControl.NextClicked += new System.EventHandler(this.OptionsControlNextClicked);
            // 
            // roundControl
            // 
            this.roundControl.BackColor = System.Drawing.Color.Black;
            this.roundControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.roundControl.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roundControl.ForeColor = System.Drawing.Color.White;
            this.roundControl.Location = new System.Drawing.Point(0, 0);
            this.roundControl.Margin = new System.Windows.Forms.Padding(5);
            this.roundControl.Name = "roundControl";
            this.roundControl.Size = new System.Drawing.Size(802, 456);
            this.roundControl.TabIndex = 12;
            this.roundControl.NextClicked += new System.EventHandler(this.RoundControlNextClicked);
            // 
            // guessingControl
            // 
            this.guessingControl.BackColor = System.Drawing.Color.Black;
            this.guessingControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guessingControl.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guessingControl.ForeColor = System.Drawing.Color.White;
            this.guessingControl.Location = new System.Drawing.Point(0, 0);
            this.guessingControl.Margin = new System.Windows.Forms.Padding(5);
            this.guessingControl.Name = "guessingControl";
            this.guessingControl.Size = new System.Drawing.Size(802, 456);
            this.guessingControl.TabIndex = 6;
            this.guessingControl.NextClicked += new System.EventHandler(this.GuessingControlNextClicked);
            this.guessingControl.RequestRestart += new System.EventHandler(this.ControlRequestRestart);
            // 
            // questionControl
            // 
            this.questionControl.BackColor = System.Drawing.Color.Black;
            this.questionControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.questionControl.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.questionControl.ForeColor = System.Drawing.Color.White;
            this.questionControl.Location = new System.Drawing.Point(0, 0);
            this.questionControl.Margin = new System.Windows.Forms.Padding(5);
            this.questionControl.Name = "questionControl";
            this.questionControl.Size = new System.Drawing.Size(802, 456);
            this.questionControl.TabIndex = 5;
            this.questionControl.NextClicked += new System.EventHandler(this.QuestionControlNextClicked);
            this.questionControl.RequestRestart += new System.EventHandler(this.ControlRequestRestart);
            // 
            // jokersControl
            // 
            this.jokersControl.BackColor = System.Drawing.Color.Black;
            this.jokersControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.jokersControl.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jokersControl.ForeColor = System.Drawing.Color.White;
            this.jokersControl.Location = new System.Drawing.Point(0, 0);
            this.jokersControl.Margin = new System.Windows.Forms.Padding(5);
            this.jokersControl.Name = "jokersControl";
            this.jokersControl.Size = new System.Drawing.Size(802, 456);
            this.jokersControl.TabIndex = 4;
            this.jokersControl.NextClicked += new System.EventHandler(this.JokersControlNextClicked);
            this.jokersControl.RequestRestart += new System.EventHandler(this.ControlRequestRestart);
            // 
            // categoryControl
            // 
            this.categoryControl.BackColor = System.Drawing.Color.Black;
            this.categoryControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.categoryControl.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categoryControl.ForeColor = System.Drawing.Color.White;
            this.categoryControl.Location = new System.Drawing.Point(0, 0);
            this.categoryControl.Margin = new System.Windows.Forms.Padding(5);
            this.categoryControl.Name = "categoryControl";
            this.categoryControl.Size = new System.Drawing.Size(802, 456);
            this.categoryControl.TabIndex = 3;
            this.categoryControl.CategoryClicked += new System.EventHandler(this.CategoryControlCategoryClicked);
            this.categoryControl.RequestRestart += new System.EventHandler(this.ControlRequestRestart);
            // 
            // enterPlayerControl
            // 
            this.enterPlayerControl.BackColor = System.Drawing.Color.Black;
            this.enterPlayerControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.enterPlayerControl.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enterPlayerControl.ForeColor = System.Drawing.Color.White;
            this.enterPlayerControl.Location = new System.Drawing.Point(0, 0);
            this.enterPlayerControl.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.enterPlayerControl.Name = "enterPlayerControl";
            this.enterPlayerControl.Size = new System.Drawing.Size(802, 456);
            this.enterPlayerControl.TabIndex = 2;
            this.enterPlayerControl.StartClicked += new System.EventHandler(this.EnterPlayerControlStartClicked);
            this.enterPlayerControl.RequestRestart += new System.EventHandler(this.ControlRequestRestart);
            // 
            // askControl
            // 
            this.askControl.BackColor = System.Drawing.Color.Black;
            this.askControl.BottomFraction = 0.2F;
            this.askControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.askControl.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.askControl.ForeColor = System.Drawing.Color.White;
            this.askControl.Location = new System.Drawing.Point(0, 0);
            this.askControl.Margin = new System.Windows.Forms.Padding(5);
            this.askControl.Name = "askControl";
            this.askControl.Size = new System.Drawing.Size(802, 456);
            this.askControl.TabIndex = 1;
            this.askControl.LeftClicked += new System.EventHandler(this.AskControlLeftClicked);
            this.askControl.RightClicked += new System.EventHandler(this.AskControlRightClicked);
            this.askControl.RequestRestart += new System.EventHandler(this.ControlRequestRestart);
            // 
            // timelineControl
            // 
            this.timelineControl.BackColor = System.Drawing.Color.Black;
            this.timelineControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.timelineControl.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timelineControl.ForeColor = System.Drawing.Color.White;
            this.timelineControl.Location = new System.Drawing.Point(0, 0);
            this.timelineControl.Margin = new System.Windows.Forms.Padding(5);
            this.timelineControl.Name = "timelineControl";
            this.timelineControl.ShowSolution = false;
            this.timelineControl.Size = new System.Drawing.Size(802, 456);
            this.timelineControl.TabIndex = 7;
            this.timelineControl.NextClicked += new System.EventHandler(this.TimelineControlNextClicked);
            this.timelineControl.RequestRestart += new System.EventHandler(this.ControlRequestRestart);
            // 
            // pointsControl
            // 
            this.pointsControl.BackColor = System.Drawing.Color.Black;
            this.pointsControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pointsControl.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pointsControl.ForeColor = System.Drawing.Color.White;
            this.pointsControl.Location = new System.Drawing.Point(0, 0);
            this.pointsControl.Margin = new System.Windows.Forms.Padding(5);
            this.pointsControl.Name = "pointsControl";
            this.pointsControl.Size = new System.Drawing.Size(802, 456);
            this.pointsControl.TabIndex = 8;
            this.pointsControl.NextClicked += new System.EventHandler(this.PointsControlNextClicked);
            this.pointsControl.RequestRestart += new System.EventHandler(this.ControlRequestRestart);
            // 
            // scoreControl
            // 
            this.scoreControl.BackColor = System.Drawing.Color.Black;
            this.scoreControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scoreControl.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoreControl.ForeColor = System.Drawing.Color.White;
            this.scoreControl.Location = new System.Drawing.Point(0, 0);
            this.scoreControl.Margin = new System.Windows.Forms.Padding(5);
            this.scoreControl.Name = "scoreControl";
            this.scoreControl.Size = new System.Drawing.Size(802, 456);
            this.scoreControl.TabIndex = 9;
            this.scoreControl.ExitClicked += new System.EventHandler(this.ScoreControlExitClicked);
            this.scoreControl.NextClicked += new System.EventHandler(this.ScoreControlNextClicked);
            this.scoreControl.RequestRestart += new System.EventHandler(this.ControlRequestRestart);
            // 
            // creditsControl
            // 
            this.creditsControl.BackColor = System.Drawing.Color.Black;
            this.creditsControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.creditsControl.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.creditsControl.ForeColor = System.Drawing.Color.White;
            this.creditsControl.Location = new System.Drawing.Point(0, 0);
            this.creditsControl.Margin = new System.Windows.Forms.Padding(5);
            this.creditsControl.Name = "creditsControl";
            this.creditsControl.Size = new System.Drawing.Size(802, 456);
            this.creditsControl.TabIndex = 10;
            this.creditsControl.NextClicked += new System.EventHandler(this.CreditsControlNextClicked);
            this.creditsControl.RequestRestart += new System.EventHandler(this.ControlRequestRestart);
            // 
            // selectGameControl
            // 
            this.selectGameControl.BackColor = System.Drawing.Color.Black;
            this.selectGameControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.selectGameControl.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectGameControl.ForeColor = System.Drawing.Color.White;
            this.selectGameControl.Location = new System.Drawing.Point(0, 0);
            this.selectGameControl.Margin = new System.Windows.Forms.Padding(5);
            this.selectGameControl.Name = "selectGameControl";
            this.selectGameControl.Size = new System.Drawing.Size(802, 456);
            this.selectGameControl.TabIndex = 11;
            this.selectGameControl.Selected += new System.EventHandler(this.SelectGameControlSelected);
            this.selectGameControl.RequestRestart += new System.EventHandler(this.ControlRequestRestart);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(802, 456);
            this.Controls.Add(this.titleControl);
            this.Controls.Add(this.optionsControl);
            this.Controls.Add(this.roundControl);
            this.Controls.Add(this.guessingControl);
            this.Controls.Add(this.questionControl);
            this.Controls.Add(this.jokersControl);
            this.Controls.Add(this.categoryControl);
            this.Controls.Add(this.enterPlayerControl);
            this.Controls.Add(this.askControl);
            this.Controls.Add(this.timelineControl);
            this.Controls.Add(this.pointsControl);
            this.Controls.Add(this.scoreControl);
            this.Controls.Add(this.creditsControl);
            this.Controls.Add(this.selectGameControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Kaleder Dart";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Shown += new System.EventHandler(this.MainFormShown);
            this.ResumeLayout(false);

        }

        #endregion

        private TitleControl titleControl;
        private AskControl askControl;
        private EnterPlayerControl enterPlayerControl;
        private CategoryControl categoryControl;
        private JokersControl jokersControl;
        private QuestionControl questionControl;
        private GuessingControl guessingControl;
        private TimelineControl timelineControl;
        private PointsControl pointsControl;
        private ScoreControl scoreControl;
        private CreditsControl creditsControl;
        private SelectGameControl selectGameControl;
        private RoundControl roundControl;
        private OptionsControl optionsControl;
    }
}

