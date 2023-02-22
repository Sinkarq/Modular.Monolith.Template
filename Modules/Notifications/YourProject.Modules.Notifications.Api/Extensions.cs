using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using YourProject.Modules.Notifications.Api.Services;
using YourProject.Modules.Notifications.Shared;

namespace YourProject.Modules.Notifications.Api;

public static class Extensions
{
    public static IServiceCollection AddNotificationsModule(this IServiceCollection services)
    {
        services.AddTransient<INotificationsModuleApi, NotificationsModuleApi>();
        services.AddSingleton<IEmailSender, EmailSender>();
        services.AddSingleton<IEmailResolver, EmailResolver>();
            
        return services;
    }
        
    public static IApplicationBuilder UseNotificationsModule(this IApplicationBuilder app)
    {
        return app;
    }
}