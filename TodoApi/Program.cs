var builder = WebApplication.CreateBuilder(args);

// 1. Services registrieren
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAll", policy =>
    {
        policy.AllowAnyOrigin()
              .AllowAnyHeader()
              .AllowAnyMethod();
    });
});

builder.Services.AddControllers();

// 2. App bauen
var app = builder.Build();

// 3. Middleware aktivieren
app.UseCors("AllowAll");

// 4. Endpunkte definieren
app.MapGet("/api/todo", () => "Hello World");
app.MapControllers();

// 5. App starten
app.Run();