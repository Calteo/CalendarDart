using System;
using System.Xml.Linq;

namespace Calendar.Dart
{
    /// <summary>
    /// Erweiterung der <see cref="XContainer"/>-Klasse.
    /// </summary>
    public static class XContainerExtension
    {
        /// <summary>
        /// Ruft ein notwendiges Element ab.
        /// </summary>
        /// <param name="xContainer">Container in dem das Element enthalten ist.</param>
        /// <param name="xname">Name des Elements</param>
        /// <returns>Das erste Element mit dem gewünschten Namen.</returns>
        /// <exception cref="XObjectException">Falls keine Element mit dem Namen exisitert.</exception>
        public static XElement RequiredElement(this XContainer xContainer, XName xname)
        {
            var element = xContainer.Element(xname);
            if (element == null)
                throw new XObjectException($"Notwendiges Element {xname} fehlt.", xContainer);

            return element;
        }

        /// <summary>
        /// Ruft ein notwendiges Element ab.
        /// </summary>
        /// <param name="xContainer">Container in dem das Element enthalten ist.</param>
        /// <param name="name">Name des Elements</param>
        /// <param name="namespaceName"></param>
        /// <returns>Das erste Element mit dem gewünschten Namen.</returns>
        /// <exception cref="XObjectException">Falls keine Element mit dem Namen exisitert.</exception>
        public static XElement RequiredElement(this XContainer xContainer, string name, string namespaceName = "")
        {
            var xname = XName.Get(name, namespaceName);
            return RequiredElement(xContainer, xname);
        }
        
        ///<summary>
        /// Versucht, den Wert (Value) eines XContainer Objektes abzurufen.
        ///</summary>
        ///<param name="xContainer">Container in dem der Wert enthalten ist.</param>
        ///<param name="name">Name des Elements</param>
        ///<returns>Liefert den Wert des Elements zurück. Falls das Element nicht existiert wird string.empty zurückgeliefert.</returns>
        public static string TryGetValue(this XContainer xContainer, string name)
        {
            var element = xContainer.Element(name);
            return element?.Value ?? string.Empty;
        }

        /// <summary>
        ///  Liefert den Wert (Value) eines XContainer Objektes zurück oder den default Wert.
        /// </summary>
        /// <param name="xContainer">Container in dem der Wert enthalten ist.</param>
        /// <param name="name">Name des Elements</param>
        /// <param name="obj"></param>
        /// <returns>Liefert den Wert des Elements zurück. Falls das Element nicht existiert wird string.empty zurückgeliefert.</returns>
        public static T GetElementValue<T>(this XContainer xContainer, string name, T obj = default(T))
        {
            var element = xContainer.Element(name);
            return element != null ? (T)Convert.ChangeType(element.Value, typeof (T)) : obj;
        }
    }
}
