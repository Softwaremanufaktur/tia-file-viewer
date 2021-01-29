namespace TiaFileViewer.Core.Contract.Serialization
{
    public interface ISerializerFactory
    {
        ITiaFileSerializer CreateXmlSerializer();

        ITiaFileSerializer CreateCsvSerializer();
    }
}