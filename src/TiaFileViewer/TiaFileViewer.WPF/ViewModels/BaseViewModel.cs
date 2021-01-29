using Prism.Mvvm;
using Prism.Regions;

namespace TiaFileViewer.WPF.ViewModels
{
    internal abstract class BaseViewModel : BindableBase, INavigationAware
    {
        protected readonly IRegionManager _regionManager;

        public BaseViewModel(IRegionManager regionManager)
        {
            _regionManager = regionManager;
        }

        public virtual bool IsNavigationTarget(NavigationContext navigationContext)
        {
            return true;
        }

        public virtual void OnNavigatedFrom(NavigationContext navigationContext)
        {
        }

        public virtual void OnNavigatedTo(NavigationContext navigationContext)
        {
        }
    }
}