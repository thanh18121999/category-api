using MediatR;
using Microsoft.Extensions.DependencyInjection;
using XLog.Category.Infrastructure.Validation;

namespace XLog.Category.Infrastructure.ServiceCollection
{
    public static class CustomRequestValidationExtenstion
    {
        public static IServiceCollection AddCustomRequestValidation(this IServiceCollection services)
        {
            services.AddScoped(typeof(IPipelineBehavior<,>), typeof(RequestValidationBehavior<,>));
            return services;
        }
    }
}
