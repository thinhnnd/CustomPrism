using CustomPrismApp.Core.Mvvm;
using CustomPrismApp.Services.Interfaces;
using Prism.Regions;

namespace CustomPrismApp.Modules.Feature2.ViewModels
{
    public class Feature2ViewModel: RegionViewModelBase
    {
        private string _message;
        public string Message
        {
            get { return _message; }
            set { SetProperty(ref _message, value); }
        }

        public Feature2ViewModel(IRegionManager regionManager, IMessageService messageService) :
            base(regionManager)
        {
            Message = messageService.GetMessage() + " Feature 2";
        }

        public override void OnNavigatedTo(NavigationContext navigationContext)
        {
            //do something
        }
    }
}
