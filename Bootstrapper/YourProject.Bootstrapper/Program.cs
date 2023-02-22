
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using YourProject.Modules.Notifications.Api;
using YourProject.Modules.Users.Api;
using YourProject.Shared;

namespace YourProject.Bootstrapper;

internal static class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication
            .CreateBuilder(args);

        builder.Services.AddUsersModule(builder.Configuration);
        builder.Services.AddNotificationsModule();
        builder.Services.AddSharedFramework(builder.Configuration);

        var app = builder.Build();

        app.UseSharedFramework();
        app.UseNotificationsModule();
        app.UseEndpoints(endpoints =>
        {
            endpoints.MapControllers();
            endpoints.MapGet("/", ctx => ctx.Response.WriteAsync("YourProject API"));
        });

        app.Run();
    }
}