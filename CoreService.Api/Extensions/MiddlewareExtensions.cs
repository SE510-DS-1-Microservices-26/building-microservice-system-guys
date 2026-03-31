using CoreService.Api.Middleware;

namespace CoreService.Api.Extensions;

public static class MiddlewareExtensions
{
    public static IApplicationBuilder UseCustomExceptionHandling(this IApplicationBuilder app)
    {
        return app.UseMiddleware<ExceptionHandlingMiddleware>();
    }

    public static IApplicationBuilder UseCorrelationId(this IApplicationBuilder app)
    {
        return app.UseMiddleware<CorrelationIdMiddleware>();
    }
}