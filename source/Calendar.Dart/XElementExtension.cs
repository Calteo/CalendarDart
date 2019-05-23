using System.Xml.Linq;

namespace Calendar.Dart
{
    /// <summary>
    /// Erweiterungen der <see cref="XElement"/>-Klasse.
    /// </summary>
    public static class XElementExtension
    {
        /// <summary>
        /// Ruft den Wert eines Attributes ab.
        /// </summary>
        /// <param name="xElement">Element, welches das Attribute enthält.</param>
        /// <param name="name">Name des Attributes</param>
        /// <returns>Das Attribute</returns>
        /// <exception cref="XObjectException">Falls das Attribute nicht existiert.</exception>
        public static XAttribute RequiredAttribute(this XElement xElement, string name)
        {
            var attribute = xElement.Attribute(name);
            if (attribute == null)
                throw new XObjectException($"Notwendiges Attribut {name}.", xElement);

            return attribute;
        }

        /// <summary>
        /// Ruft den Wert eines Attributes ab.
        /// </summary>
        /// <param name="xElement">Element, welches das Attribute enthält.</param>
        /// <param name="name">Name des Attributes</param>
        /// <returns>Den Wert des Attributes oder <c>null</c>, wenn diesen nicht exisitert.</returns>
        public static string GetAttribute(this XElement xElement, string name)
        {
            var attribute = xElement.Attribute(name);
            return attribute?.Value;
        }
    }
}
