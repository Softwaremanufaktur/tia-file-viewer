using System;
using System.Collections.Generic;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using TiaFileViewer.Core.Contract.Serialization;
using TiaFileViewer.Core.Serialization.Deserializer.Xml.Model;
using TiaFileViewer.Model;

namespace TiaFileViewer.Core.Serialization.Deserializer.Xml
{
    public class XmlDeserializer : ITiaFileSerializer
    {
        public TiaFile Read(string pathToTiaFile)
        {
            var tiaFileInfo = new FileInfo(pathToTiaFile);

            TiaSelectionTool tiaSelectionTool;

            var serializer = new XmlSerializer(typeof(TiaSelectionTool));

            using (var reader = XmlReader.Create(tiaFileInfo.OpenRead()))
            {
                tiaSelectionTool = (TiaSelectionTool) serializer.Deserialize(reader);
            }

            var result = new TiaFile {Name = tiaFileInfo.Name};
            var tiaNodesDictionary = new Dictionary<string, List<TiaNode>>();
            foreach (var business in tiaSelectionTool.Businesses)
            foreach (var graph in business.Graphs)
            foreach (var node in graph.Nodes)
            {
                var tiaNode = new TiaNode {Type = node.Type};
                foreach (var nodeProperty in node.Properties)
                {
                    var tiaProperty = new TiaProperty {Key = nodeProperty.Key, Value = nodeProperty.Value};
                    tiaNode.TiaProperties.Add(tiaProperty);
                }

                if (tiaNodesDictionary.ContainsKey(node.Type))
                {
                    var existingNodes = tiaNodesDictionary[node.Type];
                    existingNodes.Add(tiaNode);
                }
                else
                {
                    var newTiaNodes = new List<TiaNode> {tiaNode};
                    tiaNodesDictionary.Add(node.Type, newTiaNodes);
                }
            }

            result.TiaNodes = tiaNodesDictionary;

            return result;
        }

        public void Write(TiaFile tiaFileToSerializer)
        {
            throw new NotImplementedException();
        }
    }
}