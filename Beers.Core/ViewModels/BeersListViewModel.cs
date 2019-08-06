using System.Linq;
using System.Threading.Tasks;
using Beers.Core.Models;
using Beers.Core.Services;
using MvvmCross.Commands;
using MvvmCross.Navigation;
using MvvmCross.ViewModels;

namespace Beers.Core.ViewModels
{
    public class BeersListViewModel : MvxViewModel
    {
        private readonly IMvxNavigationService _navigationService;
        private readonly IRestService _restService;
        public MvxObservableCollection<BeerItem> BeersList { get; }

        public BeersListViewModel(IMvxNavigationService navigationService, IRestService restService)
        {
            _navigationService = navigationService;
            _restService = restService;
            
            BeersList = new MvxObservableCollection<BeerItem>();
            ItemClicked = new MvxAsyncCommand<BeerItem>(OnItemClicked);
        }

        public override async Task Initialize()
        {
            await base.Initialize();

            var beers = await _restService.GetBeers();
            
            BeersList.ReplaceWith(beers.Select(b => new BeerItem(b)));
        }

        private async Task OnItemClicked(BeerItem arg)
        {
            if (arg == null)
                return;
                
            await _navigationService.Navigate<DetailsViewModel, BeerItem>(arg);
        }

        public MvxAsyncCommand<BeerItem> ItemClicked { get; }
    }
}