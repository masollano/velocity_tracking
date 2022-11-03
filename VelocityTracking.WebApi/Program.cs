using VelocityTracking.WebApi.Application.Interfaces;
using VelocityTracking.WebApi.Data;
using VelocityTracking.WebApi.Repository;

var builder = WebApplication.CreateBuilder(args);
{
    // Add services to the container.

    builder.Services.AddSingleton<DapperContext>();
    builder.Services.AddScoped<IEmployeeRepository, EmployeeRepository>();
    builder.Services.AddScoped<IProjectRepository, ProjectRepository>();
    builder.Services.AddScoped<ITasksRepository, TasksRepository>();
    builder.Services.AddScoped<IVelocityTrackingRecordRepository, VelocityTrackingRecordRepository>();
    builder.Services.AddControllers();
    // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
    builder.Services.AddEndpointsApiExplorer();
    builder.Services.AddSwaggerGen();

}


var app = builder.Build();
{
    // Configure the HTTP request pipeline.
    if (app.Environment.IsDevelopment())
    {
        app.UseSwagger();
        app.UseSwaggerUI();
    }

    app.UseHttpsRedirection();

    app.UseAuthorization();

    app.MapControllers();

    app.Run();
}

