using Nutritia.Models;
using System.Threading.Tasks;

namespace Nutritia.Services
{
    public interface IRequestExecuter
    {

        /// <summary>
        /// Get a product information by passing the barcode.
        /// </summary>
        /// <param name="barCode">The barcode of the product</param>
        /// <returns>A product</returns>
        Task<Product> GetProduct(string barCode);

    }
}
