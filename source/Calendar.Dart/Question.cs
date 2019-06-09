using System;
using System.Globalization;
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
            Text = element.RequiredAttribute("text").Value;
            Solution = DateTime.Parse(element.RequiredAttribute("solution").Value, CultureInfo.CurrentUICulture);
        }

        public string Text { get; }
        public DateTime Solution { get; }
    }
}
