using System.Globalization;

namespace DotNetTrainingBatch4.MiddlewareApp.Middlewares
{
    public class SessionMiddleware
    {
        private readonly RequestDelegate _next;

        public SessionMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            if (context.Request.Path == "/" || context.Request.Path.ToString().ToLower() == "/Login".ToLower())
                goto result;

            string name = context.Session.GetString("name")!;
            if (name == null)
            {
                context.Response.Redirect("/");
                return;
            }

        result:

            // Call the next delegate/middleware in the pipeline.
            await _next(context);
        }
    }
}
