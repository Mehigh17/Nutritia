using Nutritia.Exceptions;
using Nutritia.Services;
using Nutritia.Views;
using System;
using Xamarin.Forms;

namespace Nutritia.ViewModels
{
    public class HomeViewModel : PageViewModel
    {

        private ProductDetailViewModel _productVm;
        public ProductDetailViewModel ProductVm
        {
            get => _productVm;
            set => SetProperty(ref _productVm, value);
        }

        private readonly IRequestExecuter _requestExecuter;

        public HomeViewModel()
        {
            _requestExecuter = DependencyService.Resolve<RequestExecuter>() ?? throw new ArgumentNullException(nameof(_requestExecuter));

            Title = "Home";
            ProductVm = new ProductDetailViewModel();

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

                    ProductVm.ImgUrl = product.ImageUrl;
                    ProductVm.ProductName = product.ProductName;
                }
                catch(ProductNotFoundException)
                {
                    ProductVm = null;
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
