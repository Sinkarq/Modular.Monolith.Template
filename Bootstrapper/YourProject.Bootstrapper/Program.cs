using YourProject.Modules.Users.Api;
using YourProject.Shared;

var builder = WebApplication
    .CreateBuilder(args);

builder.Services.AddUsersModule(builder.Configuration);
builder.Services.AddSharedFramework(builder.Configuration);

var app = builder.Build();

app.UseSharedFramework();
app.UseEndpoints(endpoints =>
{
    endpoints.MapControllers();
    endpoints.MapGet("/", ctx => ctx.Response.WriteAsync("YourProject API"));
});

app.Run();