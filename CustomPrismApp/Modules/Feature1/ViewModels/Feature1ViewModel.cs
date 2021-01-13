using CustomPrismApp.Core.Mvvm;
using CustomPrismApp.Services.Interfaces;
using Prism.Regions;

namespace CustomPrismApp.Modules.Feature1.ViewModels
{
    public class Feature1ViewModel : RegionViewModelBase
    {
        private string _message;
        public string Message
        {
            get { return _message; }
            set { SetProperty(ref _message, value); }
        }

        public Feature1ViewModel(IRegionManager regionManager, IMessageService messageService) :
            base(regionManager)
        {
            Message = messageService.GetMessage() + " Feature 1";
        }

        public override void OnNavigatedTo(NavigationContext navigationContext)
        {
            //do something
        }
    }
}
