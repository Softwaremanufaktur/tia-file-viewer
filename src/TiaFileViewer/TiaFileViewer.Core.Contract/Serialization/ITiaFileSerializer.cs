using TiaFileViewer.Model;

namespace TiaFileViewer.Core.Contract.Serialization
{
    public interface ITiaFileSerializer
    {
        TiaFile Read(string pathToTiaFile);

        void Write(TiaFile tiaFileToSerializer);
    }
}