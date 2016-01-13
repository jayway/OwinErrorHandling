using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Web.Http;

namespace OwinErrorHandling.ErrorHandling
{
    public class OopsResult : IHttpActionResult
    {
        public HttpRequestMessage Request { get; }

        public OopsResult(HttpRequestMessage request)
        {
            Request = request;
        }

        public Task<HttpResponseMessage> ExecuteAsync(CancellationToken cancellationToken)
        {
            return Task.FromResult(new HttpResponseMessage(HttpStatusCode.InternalServerError)
            {
                RequestMessage = Request,
                Content = new StringContent("Phew, we handled that!", Encoding.UTF8)
            });
        }
    }
}