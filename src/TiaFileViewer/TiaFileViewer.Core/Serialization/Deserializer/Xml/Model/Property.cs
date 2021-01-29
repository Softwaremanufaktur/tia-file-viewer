using System.Xml.Serialization;

namespace TiaFileViewer.Core.Serialization.Deserializer.Xml.Model
{
    public class Property
    {
        [XmlElement("key")] public string Key { get; set; }

        [XmlElement("value")] public string Value { get; set; }
    }
}