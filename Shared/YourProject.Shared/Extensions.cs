using System;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using YourProject.Shared.Database;
using YourProject.Shared.Exceptions;
using YourProject.Shared.Swagger;
using YourProject.Shared.Time;

namespace YourProject.Shared;

public static class Extensions
{
    private const string ApiTitle = "NPay API";
    private const string ApiVersion = "v1";
        
    public static IServiceCollection AddSharedFramework(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddMediatR(cfg =>
        {
            cfg.RegisterServicesFromAssemblies(AppDomain.CurrentDomain.GetAssemblies());
        });
        services.AddSqlServer(configuration);
        services.AddSwagger();
        services.AddErrorHandling();
        services.AddControllers();
        services.AddSingleton<IClock, UtcClock>();
        services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();

        return services;
    }
        
    public static IApplicationBuilder UseSharedFramework(this IApplicationBuilder app)
    {
        app.UseErrorHandling();
        app.UseSwaggerUI();
        app.UseReDoc(reDoc =>
        {
            reDoc.RoutePrefix = "docs";
            reDoc.SpecUrl($"/swagger/{ApiVersion}/swagger.json");
            reDoc.DocumentTitle = ApiTitle;
        });
        app.UseRouting();
            
        return app;
    }
}