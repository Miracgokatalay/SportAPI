var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "deneme ");

app.Run();
