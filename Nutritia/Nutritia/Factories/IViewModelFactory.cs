using Nutritia.Models;
using Nutritia.ViewModels;

namespace Nutritia.Factories
{
    public interface IViewModelFactory
    {

        ProductRecordViewModel CreateProductRecordViewModel(ProductRecord record, Product product);
        ProductDetailViewModel CreateProductDetailViewModel(Product product);

    }
}
