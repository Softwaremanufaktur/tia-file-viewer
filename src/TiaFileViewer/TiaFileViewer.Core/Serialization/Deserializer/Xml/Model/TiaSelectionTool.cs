using System.Collections.Generic;
using System.Xml.Serialization;

namespace TiaFileViewer.Core.Serialization.Deserializer.Xml.Model
{
    [XmlRoot("tiaselectiontool")]
    public class TiaSelectionTool
    {
        internal TiaSelectionTool()
        {
            Businesses = new List<Business>();
        }

        [XmlElement("business")] public List<Business> Businesses { get; set; }
    }
}