using System;
using Beers.Core.ViewModels;
using Foundation;
using MvvmCross.Binding.BindingContext;
using MvvmCross.Platforms.Ios.Binding.Views;
using MvvmCross.Platforms.Ios.Views;
using UIKit;

namespace Beers.iOS.Views
{
    public partial class BeersListView : MvxViewController<BeersListViewModel>
    {
        public BeersListView() : base("BeersListView", null)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            SetupBindings();
        }

        private void SetupBindings()
        {
            var source = new BeersTableViewSource(TableView, ViewModel);
            var bindingSet = this.CreateBindingSet<BeersListView, BeersListViewModel>();

            bindingSet.Bind(source).To(vm => vm.BeersList);
            
            bindingSet.Apply();

            TableView.Source = source;
            TableView.ReloadData();
        }

        private class BeersTableViewSource : MvxTableViewSource
        {
            private readonly BeersListViewModel _viewModel;
            public BeersTableViewSource(UITableView tableView, BeersListViewModel viewModel) : base(tableView)
            {
                _viewModel = viewModel;
                tableView.RegisterNibForCellReuse(BeerCell.Nib, BeerCell.Key);
                tableView.EstimatedRowHeight = 90;
            }

            protected override UITableViewCell GetOrCreateCellFor(UITableView tableView, NSIndexPath indexPath, object item)
            {
                return tableView.DequeueReusableCell(BeerCell.Key, indexPath);
            }

            public override void RowSelected(UITableView tableView, NSIndexPath indexPath)
            {
                var cell = tableView.CellAt(indexPath) as BeerCell;

                _viewModel.ItemClicked.ExecuteAsync(cell?.DataContext as BeerItem);
            }
        }
    }
}

