using Appointment.EntityFramework;
using Appointment.Repositories;
using Appointment.Service.Configs;
using Appointment.Service.Consumers;
using AutoMapper;
using BusinessLogic.Abstractions;
using BusinessLogic.Services;
using BusinessLogic.Services.Mapping;
using MassTransit;
using Microsoft.EntityFrameworkCore;
using System.Transactions;

var builder = WebApplication.CreateBuilder(args);
IConfiguration configuration = new ConfigurationBuilder()
    .SetBasePath(Directory.GetCurrentDirectory())
    .AddJsonFile("appsettings.json", false, true)
    .AddJsonFile("appsettings.Development.json", true)
    .Build();

if (configuration.Get<ApplicationConfig>() is not IApplicationConfig receptionConfig)
    throw new ConfigurationException("�� ������� ��������� ������������ �������");
builder.Services.AddSingleton<IMapper>(new Mapper(new MapperConfiguration(cfg =>
{
    cfg.AddProfile<AppointmentMappingsProfile>();

})));

string connection = configuration!.GetConnectionString("DefaultConnection");
if (string.IsNullOrEmpty(connection))
    throw new ConfigurationException("�� ������� ��������� ������ �����������");

builder.Services.AddDbContext<DatabaseContext>(options => options.UseSqlServer(connection));

builder.Services.AddTransient<IAppointmentService, AppointmentService>();
builder.Services.AddTransient<IAppointmentRepository, AppointmentRepository>();
builder.Services.AddTransient<IMessageLogic, MessageLogic>();
// Add services to the container.
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddMassTransit(x =>
{
    x.AddConsumer<BaseConsumer>();


    x.UsingRabbitMq((context, cfg) =>
    {
        cfg.Host(receptionConfig.BusConfig.Host, receptionConfig.BusConfig.Port, receptionConfig.BusConfig.Path, h =>
        {
            h.Username(receptionConfig.BusConfig.Username);
            h.Password(receptionConfig.BusConfig.Password);
        });

        cfg.UseTransaction(_ =>
        {
            _.Timeout = TimeSpan.FromSeconds(20);
            _.IsolationLevel = IsolationLevel.ReadCommitted;
        });

        cfg.ReceiveEndpoint(new TemporaryEndpointDefinition(), e =>
        {
            e.ConfigureConsumer<BaseConsumer>(context);
        });
        cfg.ConfigureEndpoints(context);
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

app.UseAuthorization();

app.MapControllers();

app.Run();


