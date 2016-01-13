using System;
using System.Threading.Tasks;
using Microsoft.Owin;

namespace OwinErrorHandling.ErrorHandling
{
    public class OopsHandlerMiddleware : OwinMiddleware
    {
        public OopsHandlerMiddleware(OwinMiddleware next) : base(next)
        {
        }

        public override async Task Invoke(IOwinContext context)
        {
            try
            {
                await Next.Invoke(context);
            }
            catch (Exception ex)
            {
                context.Response.StatusCode = 500;
                await context.Response.WriteAsync($"Phew, we handled that too!\n\nThe state of the captured exception is untouched:\n{ex}");
            }
        }
    }
}