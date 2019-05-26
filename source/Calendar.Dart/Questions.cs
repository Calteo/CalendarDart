using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Xml.Linq;

namespace Calendar.Dart
{
    [Serializable]
    class Questions
    {
        public static IEnumerable<string> GetGames()
        {
            var culture = CultureInfo.CurrentUICulture;

            var paths = new List<string>();
            while (culture != CultureInfo.InvariantCulture)
            {
                paths.Insert(0, culture.IetfLanguageTag);
                culture = culture.Parent;
            }

            paths.Insert(0, "Games");
            
            var folder = Path.Combine(paths.ToArray());
            while (!Directory.Exists(folder))
            {
                paths.RemoveAt(paths.Count - 1);
                folder = Path.Combine(paths.ToArray());
            }            
            
            return Directory.GetFiles(folder, "*.xml");
        }

        /// <summary>
        /// Initialisiert einen neue Instanz der <see cref="Questions"/>-Klasse.
        /// </summary>
        public Questions(string filename)
        {
            var document = XDocument.Load(filename);
            var root = document.RequiredElement("questions");
            Categories = root.Elements("question").Select(e => new Question(e))
                .GroupBy(q => q.Category)
                .ToDictionary(g => g.Key, g => g.ToList());
        }

        public Dictionary<string, List<Question>> Categories { get; }

        public bool HasQuestions => Categories.Any(kvp => kvp.Value.Count > 0);

        public Question PickQuestion(string category)
        {
            var categoryQuestions = Categories[category];
            var random = new Random();
            var index = random.Next(categoryQuestions.Count);
            var question = categoryQuestions[index];
            categoryQuestions.Remove(question);
            return question;
        }
    }
}
