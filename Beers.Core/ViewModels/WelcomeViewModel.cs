using System.Threading.Tasks;
using MvvmCross.Commands;
using MvvmCross.Navigation;
using MvvmCross.ViewModels;

namespace Beers.Core.ViewModels
{
    public class WelcomeViewModel : MvxViewModel
    {
        private readonly IMvxNavigationService _navigationService;

        public WelcomeViewModel(IMvxNavigationService navigationService)
        {
            _navigationService = navigationService;
            Title = "This is beer repository";
            Description = "Click button and go to list of beers";
            ButtonText = "Beers!";
            GoToBeersList = new MvxAsyncCommand(OnGoToBeersList);
        }

        private Task OnGoToBeersList()
        {
            return _navigationService.Navigate<BeersListViewModel>();
        }

        public string Title { get; }

        public string Description { get; }
        
        public string ButtonText { get; }
        
        public MvxAsyncCommand GoToBeersList { get; }
    }
}
