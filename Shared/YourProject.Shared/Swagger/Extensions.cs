using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.OpenApi.Models;

namespace YourProject.Shared.Swagger;

internal static class Extensions
{
    internal static IApplicationBuilder UseSwaggerUI(this IApplicationBuilder app) =>
        app
            .UseSwagger(options => options.RouteTemplate = "docs/{documentName}/docs.json")
            .UseSwaggerUI(options =>
            {
                options.SwaggerEndpoint("/docs/v1/docs.json", "SELLit V1");
                options.RoutePrefix = string.Empty;
            });
    
    internal static IServiceCollection AddSwagger(this IServiceCollection services)
    {
        services.AddSwaggerGen(c =>
        {
            c.SwaggerDoc("v1", new OpenApiInfo
            {
                Title = "SELLit API",
                Version = "v1"
            });

            c.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme()
            {
                Description = "JWT Authorization header using bearer scheme",
                Name = "Authorization",
                In = ParameterLocation.Header,
                Type = SecuritySchemeType.ApiKey
            });

            c.AddSecurityRequirement(new OpenApiSecurityRequirement()
            {
                {
                    new OpenApiSecurityScheme()
                    {
                        Reference = new OpenApiReference()
                        {
                            Id = "Bearer",
                            Type = ReferenceType.SecurityScheme
                        }
                    },
                    new List<string>()
                }
            });

            c.EnableAnnotations();
        });

        return services;
    }
}