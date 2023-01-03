using StudentCourseApp.Application;
using StudentCourseApp.Persistence;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

#region Service Registration

builder.Services.AddPersistenceServices(builder.Configuration);
builder.Services.AddApplicationServices();

#endregion

builder.Services.AddControllers();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


builder.Services.AddCors(opt =>
{
    opt.AddPolicy("GlobalCORS", config =>
    {
        config.AllowAnyHeader().AllowAnyMethod();
    });
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.UseHttpsRedirection();

//app.UseMiddleware<GlobalExHandlerMiddleware>();

app.UseCors("GlobalCORS");

app.UseAuthorization();

app.MapControllers();

app.Run();
