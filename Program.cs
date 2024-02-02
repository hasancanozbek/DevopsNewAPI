var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();

var app = builder.Build();

app.Use(async (context, next) =>
{
    if (context.Request.Path.Value == "/")
    {
        // localhost'a yap�lan istekleri /MyController/MyAction'a y�nlendir
        context.Response.Redirect("/Jokes");
        return;
    }
    await next();
});

app.MapControllers();

app.Run();
