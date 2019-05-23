using System;
using System.Xml;
using System.Xml.Linq;

namespace Calendar.Dart
{
    /// <summary>
    /// Stellt eine Ausnahme auf einen <see cref="XObject"/> dar.
    /// </summary>
    public class XObjectException : Exception
    {
        /// <summary>
        /// Initialisiert eine neue Instanz der <see cref="XObjectException"/>-Klasse.
        /// </summary>
        public XObjectException(string message, XObject xObject)
            :base(message)
        {
            var xmlLineInfo = (IXmlLineInfo) xObject;
            if (xmlLineInfo.HasLineInfo())
            {
                Details += $"Zeile {xmlLineInfo.LineNumber}, Spalte {xmlLineInfo.LinePosition}.";
            }
            if (xObject.Document != null)
                Details += xObject.ToString();
        }

        public string Details { get; } = "";
    }
}
