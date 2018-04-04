using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Formatting;
using System.Threading.Tasks;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.Azure.WebJobs.Host;
using ProductManage;

namespace ProductsAPI
{
    public static class ProductManage
    {
        [FunctionName("GetVersion")]
        public static async Task<HttpResponseMessage> Run([HttpTrigger(AuthorizationLevel.Function, "get",  Route = "products/version")]HttpRequestMessage req, TraceWriter log)
        {
          
            return req.CreateResponse(HttpStatusCode.OK, new { version = ProductManager.GetProducManagerVersion()}, JsonMediaTypeFormatter.DefaultMediaType);
        }
    }
}
