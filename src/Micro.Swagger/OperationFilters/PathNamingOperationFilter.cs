using Microsoft.OpenApi.Models;
using Swashbuckle.AspNetCore.SwaggerGen;

namespace Micro.Swagger.OperationFilters
{
    public class PathNamingOperationFilter : IOperationFilter
    {
        public void Apply(OpenApiOperation operation, OperationFilterContext context)
        {
            context.ApiDescription.RelativePath = context.ApiDescription.RelativePath.ToLower();
        }
    }
}
