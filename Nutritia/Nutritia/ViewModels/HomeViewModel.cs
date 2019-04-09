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

        public HomeViewModel()
        {
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
                    var reqExec = new RequestExecuter();
                    var product = await reqExec.GetProduct(barcode);

                    ProductVm.ImgUrl = product.ImageUrl;
                    ProductVm.ProductName = product.ProductName;
                }
                catch(ProductNotFoundException)
                {
                    ProductVm.ImgUrl = string.Empty;
                    ProductVm.ProductName = "Product not found.";
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
