using System;
using System.Collections.Generic;
using System.Text;
using Prism.Ioc;
using Prism.Modularity;
using Prism.Regions;
using CustomPrismApp.Core;
using CustomPrismApp.Modules.Feature1.Views;

namespace CustomPrismApp.Modules.Feature1
{
    public class Feature1Module: IModule
    {
        private readonly IRegionManager _regionManager;

        public Feature1Module(IRegionManager regionManager)
        {
            _regionManager = regionManager;
        }

        public void OnInitialized(IContainerProvider containerProvider)
        {
            _regionManager.RequestNavigate(RegionNames.ContentRegion, "Feature1View");
        }

        public void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<Feature1View>();
        }
    }
}
