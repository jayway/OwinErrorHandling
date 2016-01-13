using System;
using System.Web.Http;

namespace OwinErrorHandling.Controllers
{
    public class PingController : ApiController
    {
        [Route(""), HttpGet]
        public IHttpActionResult Ping()
        {
            return Ok(DateTime.UtcNow);
        }

        [Route("oops"), HttpGet]
        public IHttpActionResult Oops()
        {
            throw new Exception("oops!");
        }
    }
}
