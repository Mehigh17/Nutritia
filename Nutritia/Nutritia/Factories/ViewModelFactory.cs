using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using Nutritia.Models;
using Nutritia.ViewModels;
using Xamarin.Forms;

namespace Nutritia.Factories
{
    public class ViewModelFactory : IViewModelFactory
    {
        public ProductDetailViewModel CreateProductDetailViewModel(Product product)
        {
            var vm = new ProductDetailViewModel
            {
                ImageUrl = product.ImageUrl,
                ProductName = product.GenericName,
                BrandName = product.BrandTags.FirstOrDefault() ?? "Unknown",
                ServingSize = string.IsNullOrEmpty(product.ServingSize) ? "Unknown" : product.ServingSize,
                Allergens = string.IsNullOrEmpty(product.Allergens) ? "Unknown" : product.Allergens,
                CreatedOn = product.CreatedDateTime,
                Keywords = new ObservableCollection<string>(product.Keywords ?? new List<string>()),
                Quantity = string.IsNullOrEmpty(product.Quantity) ? "Unknown" : product.Quantity
            };

            return vm;
        }

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
