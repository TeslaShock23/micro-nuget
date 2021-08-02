using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Versioning;
using Microsoft.Extensions.DependencyInjection;

namespace Micro.ApiVersioning
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddMicroApiVersioning(this IServiceCollection services)
        {
            services.AddApiVersioning(x =>
            {
                x.DefaultApiVersion = new ApiVersion(1, 0);
                x.ApiVersionReader = new HeaderApiVersionReader("X-API-Version");
                x.AssumeDefaultVersionWhenUnspecified = true;
                x.ReportApiVersions = true;
            });
            services.AddVersionedApiExplorer(x => x.GroupNameFormat = "'v'VVV");

            return services;
        }
    }
}
