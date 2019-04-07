using Nutritia.Services;
using System.Threading.Tasks;
using Xunit;

namespace Nutritia.Test
{
    public class RequestExecuterTests : IClassFixture<RequestExecuter>
    {

        private readonly RequestExecuter _requestExecuter;

        public RequestExecuterTests(RequestExecuter requestExecuter)
        {
            _requestExecuter = requestExecuter;
        }

        [Fact]
        public async Task GetProduct_ValidBarcodeGiven_ShouldPass()
        {
            var product = await _requestExecuter.GetProduct("3274080005003");
            Assert.NotNull(product);
        }

    }
}
