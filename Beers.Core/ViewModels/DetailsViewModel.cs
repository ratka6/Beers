using System;
using System.Threading.Tasks;
using Beers.Core.Models;
using MvvmCross.Commands;
using MvvmCross.ViewModels;

namespace Beers.Core.ViewModels
{
    public class DetailsViewModel : MvxViewModel<BeerItem>
    {
        private BeerItem _beer;

        public DetailsViewModel()
        {
            ChangeText = new MvxCommand(OnChangeText);
        }

        public override void Prepare(BeerItem parameter)
        {
            _beer = parameter;
            Tips = _beer.beer.Description;
        }

        private void OnChangeText()
        {

            Tips = Tips == _beer.beer.Description ? _beer.beer.BrewersTips : _beer.beer.Description;
        }

        public Uri ImageUri => _beer.beer.ImageUrl;
        private string _tips;
        public string Tips
        {
            get => _tips;
            set => SetProperty(ref _tips, value);
        }
        
        public MvxCommand ChangeText { get; } 
    }
}