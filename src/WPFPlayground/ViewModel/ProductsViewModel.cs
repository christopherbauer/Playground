using System.Collections.ObjectModel;

namespace WPFPlayground.ViewModel
{
    public class ProductsViewModel : ViewModelBase
    {
        private ObservableCollection<ProductViewModel> _products;

        public ObservableCollection<ProductViewModel> Products
        {
            get { return _products; }
            set { SetValue(ref _products, value); }
        }
    }
}
