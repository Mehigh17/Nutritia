using System.Threading.Tasks;
using Nutritia.ViewModels;

namespace Nutritia.Services
{
    public interface IModalService
    {

        Task ShowProductDetail(ProductDetailViewModel vm);

    }
}
