using CustomPrismApp.Core.Mvvm;
using CustomPrismApp.Services.Interfaces;
using Prism.Regions;

namespace CustomPrismApp.Modules.Feature3.ViewModels
{
    public class Feature3ViewModel : RegionViewModelBase
    {
        private string _message;
        public string Message
        {
            get { return _message; }
            set { SetProperty(ref _message, value); }
        }

        public Feature3ViewModel(IRegionManager regionManager, IMessageService messageService) :
            base(regionManager)
        {
            Message = messageService.GetMessage() + " Feature 3";
        }

        public override void OnNavigatedTo(NavigationContext navigationContext)
        {
            //do something
        }
    }
}
