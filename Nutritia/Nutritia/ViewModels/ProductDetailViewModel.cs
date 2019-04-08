namespace Nutritia.ViewModels
{
    public class ProductDetailViewModel : BaseViewModel
    {

        private string _imgUrl;
        public string ImgUrl
        {
            get => _imgUrl;
            set => SetProperty(ref _imgUrl, value);
        }

        private string _productName;
        public string ProductName
        {
            get => _productName;
            set => SetProperty(ref _productName, value);
        }

        public ProductDetailViewModel()
        {

        }

    }
}
