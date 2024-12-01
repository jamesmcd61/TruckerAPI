namespace TuckerAPIProject.Middleware
{
    using TuckerAPIProject.Middleware;

    public class AuthMiddleware : IMiddleware
    {
        public async Task InvokeAsync(HttpContext context, RequestDelegate next)
        {
            var auth = context.Request.Headers.Where(_ => _.Key == "Auth");

            await next(context);
        }
    }
}
