using Prism.Commands;
using Prism.Regions;
using TiaFileViewer.Core.Contract.Dialog;
using TiaFileViewer.WPF.Regions;

namespace TiaFileViewer.WPF.ViewModels
{
    internal class MenuViewModel : BaseViewModel
    {
        private readonly IDialogService _dialogService;

        public MenuViewModel(IDialogService dialogService, IRegionManager regionManager) : base(regionManager)
        {
            _dialogService = dialogService;
            SelectFileCommand = new DelegateCommand(OpenTiaFile);
        }

        public string Title { get; } = "Menu";

        public DelegateCommand SelectFileCommand { get; }

        private void OpenTiaFile()
        {
            var tiaFile = _dialogService.SelectTiaFileDialog();
            if (tiaFile != null)
            {
                var parameters = new NavigationParameters {{"tiafile", tiaFile}};
                _regionManager.RequestNavigate(RegionNames.ContentRegion, "TiaVisualizer", parameters);
            }
        }
    }
}