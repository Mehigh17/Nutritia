using Nutritia.Models;
using Nutritia.ViewModels;

namespace Nutritia.Factories
{
    public interface IViewModelFactory
    {

        ProductDetailViewModel CreateProductDetailViewModel(Product product);

    }
}
