using TiaFileViewer.Model;

namespace TiaFileViewer.Core.Contract.Dialog
{
    public interface IDialogService
    {
        TiaFile SelectTiaFileDialog();
    }
}