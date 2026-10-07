using Microsoft.AspNetCore.Diagnostics;

namespace UniversityAcademicApi.Middleware;

public class GlobalExceptionHandler(
    ILogger<GlobalExceptionHandler> logger) : IExceptionHandler
{
    public async ValueTask<bool> TryHandleAsync(
        HttpContext httpContext,
        Exception exception,
        CancellationToken cancellationToken)
    {
        logger.LogError(
            exception,
            "An unhandled exception occurred.");

        httpContext.Response.StatusCode = StatusCodes.Status500InternalServerError;

        await httpContext.Response.WriteAsJsonAsync(new
        {
            success = false,
            message = "An unexpected error occurred.",
            traceId = httpContext.TraceIdentifier
        }, cancellationToken);

        return true;
    }
}