using CustomPrismApp.Modules.Feature1;
using CustomPrismApp.Modules.Feature2;
using CustomPrismApp.Modules.Feature3;
using CustomPrismApp.Modules.Main.Views;
using CustomPrismApp.Services;
using CustomPrismApp.Services.Interfaces;
using Prism.Ioc;
using Prism.Modularity;
using System.Windows;

namespace CustomPrismApp
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App
    {
        protected override Window CreateShell()
        {
            return Container.Resolve<MainWindow>();
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterSingleton<IMessageService, MessageService>();
        }

        protected override void ConfigureModuleCatalog(IModuleCatalog moduleCatalog)
        {
            moduleCatalog.AddModule<Feature1Module>();
            moduleCatalog.AddModule<Feature2Module>();
            moduleCatalog.AddModule<Feature3Module>();
        }
    }
}
