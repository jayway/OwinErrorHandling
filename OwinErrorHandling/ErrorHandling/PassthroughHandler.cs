using System.Runtime.ExceptionServices;
using System.Web.Http.ExceptionHandling;

namespace OwinErrorHandling.ErrorHandling
{
    public class PassthroughHandler : ExceptionHandler
    {
        public override void Handle(ExceptionHandlerContext context)
        {
            var info = ExceptionDispatchInfo.Capture(context.Exception);
            info.Throw();
        }
    }
}