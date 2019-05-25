using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;

namespace Calendar.Dart
{
    [Serializable]
    class Game
    {
        private const string Filename = "game.binary";
        private const string FilenameNew = "game.binary.new";
        private const string FilenameBak = "game.binary.bak";
        private Questions _questions;

        public static Game Load()
        {
            if (!File.Exists(Filename)) return null;
            var formatter = new BinaryFormatter();
            using (var stream = new FileStream(Filename, FileMode.Open, FileAccess.Read, FileShare.Read))
            {
                return (Game)formatter.Deserialize(stream);
            }
        }

        public void Save()
        {
            var formatter = new BinaryFormatter();
            using (var stream = new FileStream(FilenameNew, FileMode.Create, FileAccess.Write, FileShare.None))
            {
                formatter.Serialize(stream, this);
            }

            if (File.Exists(Filename))
                File.Copy(Filename, FilenameBak, true);
            File.Copy(FilenameNew, Filename, true);
            File.Delete(FilenameNew);
        }

        public List<Player> Players { get; } = new List<Player>();
        public Questions Questions
        {
            get => _questions;
            set
            {
                _questions = value;

                var random = new Random();
                var categories = _questions.Categories.Keys.ToList();
                while (categories.Count > 0)
                {
                    var index = random.Next(categories.Count);
                    var category = categories[index];
                    categories.RemoveAt(index);
                    Categories.Enqueue(category);
                }
            }
        }
        public Question CurrentQuestion { get; set; }
        public Queue<string> Categories { get; } = new Queue<string>();
        public string CurrentCategory { get; set; }
        public int Round { get; set; } = 1;
        public int Points { get; set; } = 1000;
        public int PointsAdd { get; set; } = 0;
        public float PointsFactor { get; set; } = 1.0f;

        public void Delete()
        {
            File.Delete(Filename);
        }

        public void CalculatePoints()
        {
            float maxPoints = Points;

            Players.ForEach(p => p.Points = 0);

            var active = Players.Where(p => p.Active).ToList();
            if (active.Count == 0) return;
            if (active.Count == 1)
            {
                active[0].Points = (int)maxPoints;
                return;
            }

            var offsets = active.Select(p => Math.Abs((int)(CurrentQuestion.Solution - p.Guess).TotalDays)).ToArray();
            var max = offsets.Max();
            if (max == 0)
            {
                var score = (int)Math.Round(maxPoints / active.Count);
                active.ForEach(p => p.Points = score);
            }
            else
            {
                var diffs = offsets.Select(o => max - o).ToArray();
                var sum = diffs.Sum();
                var points = diffs.Select(d => (int)Math.Round(d * maxPoints / sum)).ToArray();
                for (var i = 0; i < points.Length; i++)
                {
                    if (active[i].Joker == Joker.Doppelt)
                        active[i].Points = 2 * points[i];
                    if (active[i].Joker == Joker.Dreifach)
                        active[i].Points = 3 * points[i];
                    else
                        active[i].Points = points[i];
                }
            }
        }

        public void ScorePoints()
        {
            Players.ForEach(p => p.Score += p.Points);
        }

        public void NextRound()
        {
            Round++;
            Points = (int)Math.Ceiling(Points * PointsFactor + PointsAdd);
        }
    }
}