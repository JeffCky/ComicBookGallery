var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Comic books Galore!");
app.MapGet("/ComicBooks", );

app.Run();
