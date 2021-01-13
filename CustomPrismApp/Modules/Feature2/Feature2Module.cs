using System;
using System.Collections.Generic;
using System.Text;
using Prism.Ioc;
using Prism.Modularity;
using Prism.Regions;
using CustomPrismApp.Core;
using CustomPrismApp.Modules.Feature2.Views;

namespace CustomPrismApp.Modules.Feature2
{
    public class Feature2Module: IModule
    {
        private readonly IRegionManager _regionManager;

        public Feature2Module(IRegionManager regionManager)
        {
            _regionManager = regionManager;
        }

        public void OnInitialized(IContainerProvider containerProvider)
        {
            //_regionManager.RequestNavigate(RegionNames.ContentRegion, "Feature2View");
            //_regionManager.RegisterViewWithRegion(RegionNames.ContentRegion, "Feature2View")
        }

        public void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<Feature2View>();
        }
    }
}
