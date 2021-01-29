using System.Collections.Generic;
using System.Xml.Serialization;

namespace TiaFileViewer.Core.Serialization.Deserializer.Xml.Model
{
    public class Graph
    {
        public Graph()
        {
            Nodes = new List<Node>();
        }

        [XmlArray("nodes")]
        [XmlArrayItem("node")]
        public List<Node> Nodes { get; set; }
    }
}