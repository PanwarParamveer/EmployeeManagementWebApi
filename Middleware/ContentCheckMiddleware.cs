namespace EmployeeManagementWebApi.Middleware
{
    public class ContentCheckMiddleware : IMiddleware
    {
        public Task InvokeAsync(HttpContext context, RequestDelegate next)
        {
            return next(context);
        }
    }
}
