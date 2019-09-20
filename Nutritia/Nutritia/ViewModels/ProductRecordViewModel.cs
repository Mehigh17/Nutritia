using System;
using System.Windows.Input;

namespace Nutritia.ViewModels
{
    public class ProductRecordViewModel : BaseViewModel
    {

        private string _imageUrl;
        public string ImageUrl
        {
            get => _imageUrl;
            set => SetProperty(ref _imageUrl, value);
        }

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

        private string _allergens;
        public string Allergens
        {
            get => _allergens;
            set => SetProperty(ref _allergens, value);
        }

        private DateTime _searchDate;
        public DateTime SearchDate
        {
            get => _searchDate;
            set => SetProperty(ref _searchDate, value);
        }

        private ICommand _readMoreCommand;
        public ICommand ReadMoreCommand
        {
            get => _readMoreCommand;
            set => SetProperty(ref _readMoreCommand, value);
        }

        private readonly string _barcode;

        public ProductRecordViewModel(string barcode)
        {
            if (string.IsNullOrEmpty(barcode))
            {
                throw new System.ArgumentException("The barcode cannot be empty nor null.", nameof(barcode));
            }

            _barcode = barcode;
        }

    }
}
