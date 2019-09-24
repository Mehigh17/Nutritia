using System;
using System.Collections.ObjectModel;

namespace Nutritia.ViewModels
{
    public class ProductDetailViewModel : BaseViewModel
    {

        private string _productName;
        public string ProductName
        {
            get => _productName;
            set => SetProperty(ref _productName, value);
        }

        private string _brandName;
        public string BrandName
        {
            get => _brandName;
            set => SetProperty(ref _brandName, value);
        }

        private string _servingSize;
        public string ServingSize
        {
            get => _servingSize;
            set => SetProperty(ref _servingSize, value);
        }

        private string _quantity;
        public string Quantity
        {
            get => _quantity;
            set => SetProperty(ref _quantity, value);
        }

        private string _allergens;
        public string Allergens
        {
            get => _allergens;
            set => SetProperty(ref _allergens, value);
        }

        private DateTime _createdOn;
        public DateTime CreatedOn
        {
            get => _createdOn;
            set => SetProperty(ref _createdOn, value);
        }

        private ObservableCollection<string> _keywords = new ObservableCollection<string>();
        public ObservableCollection<string> Keywords
        {
            get => _keywords;
            set => SetProperty(ref _keywords, value);
        }

    }
}
