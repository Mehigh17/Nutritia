using Nutritia.Exceptions;
using Nutritia.Factories;
using Nutritia.Services;
using Nutritia.Views;
using System;
using System.Collections.ObjectModel;
using Xamarin.Forms;

namespace Nutritia.ViewModels
{
    public class HomeViewModel : PageViewModel
    {

        private ObservableCollection<ProductRecordViewModel> _productRecords = new ObservableCollection<ProductRecordViewModel>();
        public ObservableCollection<ProductRecordViewModel> ProductRecords
        {
            get => _productRecords;
            set => SetProperty(ref _productRecords, value);
        }

        private readonly IRequestExecuter _requestExecuter;
        private readonly IViewModelFactory _viewModelFactory;

        public HomeViewModel()
        {
            _requestExecuter = DependencyService.Resolve<RequestExecuter>() ?? throw new ArgumentNullException(nameof(_requestExecuter));
            _viewModelFactory = DependencyService.Resolve<IViewModelFactory>() ?? throw new ArgumentNullException(nameof(_requestExecuter));

            Title = "Home";

            MessagingCenter.Subscribe<HomePage, string>(this, "BarcodeScanned", OnBarcodeReceived);
        }

        private async void OnBarcodeReceived(object sender, string barcode)
        {
            if(!string.IsNullOrEmpty(barcode))
            {
                IsBusy = true;
                try
                {
                    var product = await _requestExecuter.GetProduct(barcode);
                    //ProductVm = _viewModelFactory.CreateProductDetailViewModel(product);
                }
                catch(ProductNotFoundException)
                {
                    //ProductVm = null;
                }
                catch(Exception e)
                {
                    throw e;
                }
                finally
                {
                    IsBusy = false;
                }
            }
        }

    }
}
