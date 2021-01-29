using System;
using TiaFileViewer.Core.Contract.Serialization;
using TiaFileViewer.Core.Serialization.Deserializer.Xml;

namespace TiaFileViewer.Core.Serialization
{
    public class SerializerFactory : ISerializerFactory
    {
        public ITiaFileSerializer CreateXmlSerializer()
        {
            return new XmlDeserializer();
        }

        public ITiaFileSerializer CreateCsvSerializer()
        {
            throw new NotImplementedException();
        }
    }
}