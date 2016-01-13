using System.Web.Http.ExceptionHandling;

namespace OwinErrorHandling.ErrorHandling
{
    public class OopsHandler : ExceptionHandler
    {
        public override void Handle(ExceptionHandlerContext context)
        {
            context.Result = new OopsResult(context.Request);
        }
    }
}