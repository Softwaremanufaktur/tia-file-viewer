using Microsoft.Win32;
using TiaFileViewer.Core.Contract.Dialog;
using TiaFileViewer.Core.Contract.Serialization;
using TiaFileViewer.Model;

namespace TiaFileViewer.WPF.Dialogs
{
    public class DialogService : IDialogService
    {
        private readonly ISerializerFactory _serializerFactory;

        public DialogService(ISerializerFactory serializerFactory)
        {
            _serializerFactory = serializerFactory;
        }

        public TiaFile SelectTiaFileDialog()
        {
            var ofd = new OpenFileDialog {Filter = "Tia-Datei (*.tia)|*.tia"};
            ofd.ShowDialog();
            var tiaFile = _serializerFactory.CreateXmlSerializer().Read(ofd.FileName);
            return tiaFile;
        }
    }
}