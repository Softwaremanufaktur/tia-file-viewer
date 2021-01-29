using System.Collections.Generic;
using System.Xml.Serialization;

namespace TiaFileViewer.Core.Serialization.Deserializer.Xml.Model
{
    public class Node
    {
        [XmlAttribute("Type")] public string Type { get; set; }

        [XmlArray("properties")]
        [XmlArrayItem("property")]
        public List<Property> Properties { get; set; }
    }
}