using System.Collections.Generic;
using System.Xml.Serialization;

namespace TiaFileViewer.Core.Serialization.Deserializer.Xml.Model
{
    public class Business
    {
        public Business()
        {
            Graphs = new List<Graph>();
        }

        [XmlElement("graph")] public List<Graph> Graphs { get; set; }
    }
}