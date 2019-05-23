using System;
using System.Xml.Linq;

namespace Calendar.Dart
{
    [Serializable]
    class Question
    {
        /// <summary>
        /// Initialisiert einen neue Instanz der <see cref="Question"/>-Klasse.
        /// </summary>
        public Question(XElement element)
        {
            Category = element.RequiredAttribute("category").Value;
            Text = element.RequiredAttribute("text").Value;
            Solution = DateTime.Parse(element.RequiredAttribute("solution").Value);
        }

        public string Category { get; }
        public string Text { get; }
        public DateTime Solution { get; }
    }
}
