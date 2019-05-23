using System;
using System.Linq;
using System.Windows.Forms;

namespace Calendar.Dart
{
    internal partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainFormShown(object sender, EventArgs e)
        {
            ShowControl(titleControl);
        }

        void ShowControl(ThemedControl control)
        {
            Controls.Clear();
            control.Game = Game;
            control.Activate();
            Controls.Add(control);
            control.Play();
        }

        private Game Game { get; set; }

        enum Prompt
        {
            LoadGame,
            ContinueGame
        };

        private Prompt _prompt;
   
        private void Ask(Prompt prompt, string message, string left, string right)
        {
            _prompt = prompt;
            askControl.Message = message;
            askControl.LeftText = left;
            askControl.RightText = right;
            ShowControl(askControl);
        }

        private void AskControlLeftClicked(object sender, EventArgs e)
        {
            switch (_prompt)
            {
                case Prompt.LoadGame:
                    StartRound();
                    break;
                case Prompt.ContinueGame:
                    ShowControl(creditsControl);
                    break;
            }
        }

        private void AskControlRightClicked(object sender, EventArgs e)
        {
            switch (_prompt)
            {
                case Prompt.LoadGame:
                    Game = new Game();
                    ShowControl(selectGameControl);
                    break;
                case Prompt.ContinueGame:
                    ShowControl(scoreControl);
                    break;
            }
        }

        private void TitleControlStartGame(object sender, EventArgs e)
        {
            Game = Game.Load();

            if (Game != null)
                Ask(Prompt.LoadGame, "Soll das vorhandene Spiel fortgesetzt werden?", "Ja", "Nein");
            else
            {
                Game = new Game();
                ShowControl(selectGameControl);
            }
        }

        private void EnterPlayerControlStartClicked(object sender, EventArgs e)
        {
            Game.Save();
            StartRound();
        }

        private void StartRound()
        {
            Game.Players.ForEach(p => p.InitRound());
            ShowControl(roundControl);
        }

        private void CategoryControlCategoryClicked(object sender, EventArgs e)
        {
            ShowControl(jokersControl);    
        }

        private void JokersControlNextClicked(object sender, EventArgs e)
        {
            ShowControl(questionControl);
        }

        private void QuestionControlNextClicked(object sender, EventArgs e)
        {
            ShowControl(guessingControl);
        }

        private void GuessingControlNextClicked(object sender, EventArgs e)
        {
            ShowControl(timelineControl);
        }

        private void PointsControlNextClicked(object sender, EventArgs e)
        {
            Game.ScorePoints();
            ShowControl(scoreControl);
        }

        private void TimelineControlNextClicked(object sender, EventArgs e)
        {
            Game.CalculatePoints();
            ShowControl(pointsControl);
        }

        private void ScoreControlNextClicked(object sender, EventArgs e)
        {
            Game.NextRound();
            Game.Save();

            StartRound();
        }

        private void CreditsControlNextClicked(object sender, EventArgs e)
        {
            Game.Delete();
            Close();
        }

        private void ScoreControlExitClicked(object sender, EventArgs e)
        {
            if (Game.Questions.HasQuestions)
            {
                Ask(Prompt.ContinueGame, "Spiel wirklich beenden?", "Ja", "Nein");
            }
            else
            {
                ShowControl(creditsControl);
            }
        }

        private void SelectGameControlSelected(object sender, EventArgs e)
        {
            Game.Questions = selectGameControl.Questions;
            var random = new Random();
            var categories = Game.Questions.Categories.Keys.ToList();
            while (categories.Count > 0)
            {
                var index = random.Next(categories.Count);
                var category = categories[index];
                categories.RemoveAt(index);
                Game.Categories.Enqueue(category);
            }
            ShowControl(optionsControl);
        }

        private void ControlRequestRestart(object sender, EventArgs e)
        {            
            ShowControl(titleControl);
        }

        private void RoundControlNextClicked(object sender, EventArgs e)
        {
            ShowControl(categoryControl);
        }

        private void OptionsControlNextClicked(object sender, EventArgs e)
        {
            ShowControl(enterPlayerControl);
        }
    }
}