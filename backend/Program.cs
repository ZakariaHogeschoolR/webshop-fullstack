using Microsoft.EntityFrameworkCore;
using Webshop.DatabaseService;

var builder = WebApplication.CreateBuilder(args);

// Register DbContext
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseNpgsql(builder.Configuration.GetConnectionString("DefaultSQLConnection")));

// Add controllers (real API style)
builder.Services.AddControllers();

builder.Services.AddEndpointsApiExplorer();

builder.Services.AddSwaggerGen();

builder.Services.AddSingleton<DatabaseService>();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.MapControllers();

// ===== Test Endpoints =====
var api = app.MapGroup("/api");

api.MapGet("/db-test", async (DatabaseService dbService) =>
{
    try
    {
        await dbService.TestConnectionAsync();
        return Results.Ok(new { status = "Database verbinding succesvol!" });
    }
    catch (Exception ex)
    {
        return Results.Problem($"Database fout: {ex.Message}");
    }
})
.WithName("TestDatabaseConnection");

app.Run();
