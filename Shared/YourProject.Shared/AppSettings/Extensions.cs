using System;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace YourProject.Shared.AppSettings;

public static class Extensions
{
    private const string SectionName = "ApplicationSettings";
    
    public static YourProject.Shared.AppSettings.AppSettings GetApplicationSettings(
        this IServiceCollection services, 
        IConfiguration configuration)
    {
        var applicationSettingsConfiguration = configuration.GetSection(SectionName);
        services.Configure<YourProject.Shared.AppSettings.AppSettings>(applicationSettingsConfiguration);

        return applicationSettingsConfiguration.Get<YourProject.Shared.AppSettings.AppSettings>()
               ?? throw new InvalidOperationException("App settings can't be bound to model");
    }
}