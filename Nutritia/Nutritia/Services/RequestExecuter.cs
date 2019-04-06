using Newtonsoft.Json;
using Nutritia.Exceptions;
using Nutritia.Models;
using System.Net.Http;
using System.Threading.Tasks;

namespace Nutritia.Services
{
    public class RequestExecuter : IRequestExecuter
    {

        private const string ApiEndpoint = "https://world.openpetfoodfacts.org/api/v0/product";

        private readonly HttpClient _httpClient;

        public RequestExecuter()
        {
            _httpClient = new HttpClient();
        }

        public async Task<Product> GetProduct(string barCode)
        {
            var result = await _httpClient.GetAsync($"{ApiEndpoint}/{barCode}.json");
            if(result.IsSuccessStatusCode)
            {
                var jsonResult = await result.Content.ReadAsStringAsync();
                var response = JsonConvert.DeserializeObject<ApiResponse>(jsonResult);
                if(response.StatusVerbose.Equals("product found"))
                {
                    return response.Product;
                }
                else
                {
                    throw new ProductNotFoundException();
                }
            }

            throw new ApiRequestException($"API Error: {result.ReasonPhrase}");
        }

    }
}
