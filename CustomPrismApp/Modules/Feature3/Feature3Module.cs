using System;
using System.Collections.Generic;
using System.Text;
using Prism.Ioc;
using Prism.Modularity;
using Prism.Regions;
using CustomPrismApp.Core;
using CustomPrismApp.Modules.Feature3.Views;

namespace CustomPrismApp.Modules.Feature3
{
    public class Feature3Module : IModule
    {
        private readonly IRegionManager _regionManager;

        public Feature3Module(IRegionManager regionManager)
        {
            _regionManager = regionManager;
        }

        public void OnInitialized(IContainerProvider containerProvider)
        {
            //_regionManager.RequestNavigate(RegionNames.ContentRegion, "Feature3View");
        }

        public void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<Feature3View>();
        }
    }
}
