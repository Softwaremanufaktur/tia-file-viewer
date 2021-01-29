using System.Windows;
using Prism.Ioc;
using Prism.Regions;
using Prism.Unity;
using TiaFileViewer.Core.Contract.Dialog;
using TiaFileViewer.Core.Contract.Serialization;
using TiaFileViewer.Core.Serialization;
using TiaFileViewer.Core.Serialization.Deserializer.Xml;
using TiaFileViewer.WPF.Dialogs;
using TiaFileViewer.WPF.Regions;
using TiaFileViewer.WPF.Views;

namespace TiaFileViewer.WPF
{
    /// <summary>
    ///     Interaction logic for App.xaml
    /// </summary>
    public partial class App : PrismApplication
    {
        protected override Window CreateShell()
        {
            return Container.Resolve<MainWindow>();
        }


        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.Register<IDialogService, DialogService>();
            containerRegistry.Register<ISerializerFactory, SerializerFactory>();
            containerRegistry.Register<ITiaFileSerializer, XmlDeserializer>();

            var regionManager = Container.Resolve<IRegionManager>();
            regionManager.RegisterViewWithRegion(RegionNames.MenuRegion, typeof(Menu));
            regionManager.RegisterViewWithRegion(RegionNames.ContentRegion, typeof(TiaVisualizer));
        }
    }
}