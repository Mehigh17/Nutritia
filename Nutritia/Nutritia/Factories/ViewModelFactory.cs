using System;
using System.Linq;
using Nutritia.Models;
using Nutritia.ViewModels;
using Xamarin.Forms;

namespace Nutritia.Factories
{
    public class ViewModelFactory : IViewModelFactory
    {
        public ProductRecordViewModel CreateProductRecordViewModel(ProductRecord record, Product product)
        {
            var vm = new ProductRecordViewModel(record.Bardcode)
            {
                ProductName = product.ProductName,
                BrandName = product.BrandTags.FirstOrDefault() ?? "Unknown",
                ImageSource = product.ImageUrl ?? ImageSource.FromResource("Nutritia.Assets.Icons.question.png"),
                SearchDate = new DateTime(record.SearchedOn.Ticks),
                Allergens = string.IsNullOrEmpty(product.Allergens) ? "None" : product.Allergens,
                ServingSize = string.IsNullOrEmpty(product.ServingSize) ? "Unknown" : product.ServingSize,
            };

            return vm;
        }
    }
}
