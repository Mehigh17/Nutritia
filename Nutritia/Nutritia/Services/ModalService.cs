using System.Threading.Tasks;
using Nutritia.ViewModels;
using Nutritia.Views;
using Xamarin.Forms;

namespace Nutritia.Services
{
    public class ModalService : IModalService
    {

        public static INavigation NavigationInstance { get; set; }

        public async Task ShowProductDetail(ProductDetailViewModel vm)
        {
            if (NavigationInstance != null)
            {
                await NavigationInstance.PushAsync(new ProductDetailPage
                {
                    BindingContext = vm
                });
            }
        }

    }
}
