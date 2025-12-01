using Microsoft.EntityFrameworkCore;
using StudentGrades.Data;

var builder = WebApplication.CreateBuilder(args);

// Подключение SQLite
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlite(builder.Configuration.GetConnectionString("Default")));

// Blazor
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();

// Регистрация сервиса (если нужен)
builder.Services.AddSingleton<WeatherForecastService>();

var app = builder.Build();

// Создание БД при запуске
using (var scope = app.Services.CreateScope())
{
    var db = scope.ServiceProvider.GetRequiredService<AppDbContext>();
    db.Database.Migrate();
}

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
}

app.UseStaticFiles();
app.UseRouting();

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();
