using System;
using Beers.Core.Models;

namespace Beers.Core.ViewModels
{
    public class BeerItem
    {
        internal readonly Beer beer;

        public string Name => beer.Name;

        public string Tagline => beer.Tagline;

        public BeerItem(Beer beer)
        {
            this.beer = beer;
        }
    }
}