using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace YourProject.Shared.Database;

public static class Extensions
{
    private const string SectionName = "SqlServer";
        
    internal static IServiceCollection AddSqlServer(this IServiceCollection services, IConfiguration configuration)
    {
        services.Configure<SqlServerOptions>(configuration.GetSection(SectionName));
        services.AddHostedService<DbContextAppInitializer>();

        return services;
    }

    public static IServiceCollection AddSqlServer<T>(this IServiceCollection services) where T : DbContext
    {
        var configuration = services.BuildServiceProvider().GetRequiredService<IConfiguration>();
        var connectionString = configuration[$"{SectionName}:{nameof(SqlServerOptions.ConnectionString)}"];
        services.AddDbContext<T>(x => x.UseSqlServer(connectionString));

        return services;
    }
}