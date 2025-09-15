var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

// Route definieren: GET /api/todo
app.MapGet("/api/todo", () => "Hello World");

app.Run();