using Nutritia.Models;
using Nutritia.ViewModels;
using System;
using System.Collections.ObjectModel;
using System.Linq;

namespace Nutritia.Factories
{
    public class ViewModelFactory : IViewModelFactory
    {
        public ProductDetailViewModel CreateProductDetailViewModel(Product product)
        {
            var vm = new ProductDetailViewModel
            {
                ImgUrl = product.ImageUrl,
                ProductName = product.ProductName,
                NutritionGradeTag = product.NutritionGradeTags.FirstOrDefault(),
            };

            var nutriments = new ObservableCollection<Tuple<string, string>>(product.Nutriments.Where(n => !string.IsNullOrEmpty(n.Value.ToString()))
                                                                                               .Select(n => new Tuple<string, string>(n.Key.ToString(), n.Value.ToString())));

            
            vm.Nutriments = nutriments;

            return vm;
        }
    }
}
