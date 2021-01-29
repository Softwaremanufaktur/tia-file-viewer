using System.Collections.Generic;
using Prism.Commands;
using Prism.Regions;
using TiaFileViewer.Model;

namespace TiaFileViewer.WPF.ViewModels
{
    internal class TiaVisualizerViewModel : BaseViewModel
    {
        private TiaFile _selectedTiaFile;

        private List<TiaNode> _tiaNodes;


        public TiaVisualizerViewModel(IRegionManager regionManager) : base(regionManager)
        {
            SelectNodeTypeCommand = new DelegateCommand<object>(SelectNodeType);
        }

        public string Title { get; } = "TiaVisualizer";

        public TiaFile SelectedTiaFile
        {
            get => _selectedTiaFile;
            set => SetProperty(ref _selectedTiaFile, value);
        }

        public DelegateCommand<object> SelectNodeTypeCommand { get; }

        public List<TiaNode> TiaNodes
        {
            get => _tiaNodes;
            set => SetProperty(ref _tiaNodes, value);
        }

        private void SelectNodeType(object obj)
        {
            if (obj is KeyValuePair<string, List<TiaNode>> selectedNodeType) TiaNodes = selectedNodeType.Value;
        }

        public override bool IsNavigationTarget(NavigationContext navigationContext)
        {
            return navigationContext.Parameters["tiafile"] is TiaFile;
        }

        public override void OnNavigatedTo(NavigationContext navigationContext)
        {
            if (navigationContext.Parameters["tiafile"] is TiaFile tiaFile) SelectedTiaFile = tiaFile;
        }
    }
}