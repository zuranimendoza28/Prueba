using System.Text.Json.Serialization;
using Microsoft.EntityFrameworkCore;
using Prueba.Data;
using Prueba.Services.Courses;
using Prueba.Services.Enrollments;
using Prueba.Services.Students;
using Prueba.Services.Teachers;



var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllers()
.AddJsonOptions(Options =>
{
    Options.JsonSerializerOptions.PropertyNamingPolicy = null;
    Options.JsonSerializerOptions.Converters.Add(new JsonStringEnumConverter());
    Options.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles;
});
// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

/* ------------ AÑADIR INTERFACES --------------- */

builder.Services.AddDbContext<SchoolContext>(options =>
options.UseMySql(
    builder.Configuration.GetConnectionString("MySqlConnection"),
    Microsoft.EntityFrameworkCore.ServerVersion.Parse("8.0.20-mysql")
));

builder.Services.AddScoped<IStudentsRepository, StudentsRepository>();

builder.Services.AddScoped<ITeachersRepository, TeachersRepository>();

builder.Services.AddScoped<ICoursesRepository, CoursesRepository>();

builder.Services.AddScoped<IEnrollmentsRepository, EnrollmentsRepository>(); 




var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}


app.UseHttpsRedirection();

var summaries = new[]
{
    "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
};

app.MapGet("/weatherforecast", () =>
{
    var forecast = Enumerable.Range(1, 5).Select(index =>
        new WeatherForecast
        (
            DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
            Random.Shared.Next(-20, 55),
            summaries[Random.Shared.Next(summaries.Length)]
        ))
        .ToArray();
    return forecast;
})
.WithName("GetWeatherForecast")
.WithOpenApi();

app.MapControllers();
app.Run();

record WeatherForecast(DateOnly Date, int TemperatureC, string? Summary)
{
    public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);
}
