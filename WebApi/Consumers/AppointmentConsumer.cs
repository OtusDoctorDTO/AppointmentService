using HelpersDTO.AppointmentDto;
using MassTransit;
using Microsoft.Extensions.Logging;
using Services.Abstractions;
using System.Threading.Tasks;

namespace WebApi.Consumers
{
    public class AppointmentConsumer : IConsumer<CreateAppointmentDtoRequest>, IConsumer<DeleteAppointmentDtoRequest>, IConsumer<UpdateAppointmentDtoRequest>
    {
        private readonly ILogger<AppointmentConsumer> logger;
        private readonly IAppointmentService service;

        public AppointmentConsumer(ILogger<AppointmentConsumer> logger, IAppointmentService service)
        {
            this.logger = logger;
            this.service = service;
        }

        public async Task Consume(ConsumeContext<CreateAppointmentDtoRequest> context)
        {
            logger.LogInformation("Получен запрос CreateAppointmentDtoRequest {message}", context.Message);
            var result = new CreateAppointmentDtoResponse()
            {
                Guid = context.Message.Guid,
                Success = true,
                ConnectionId = context.Message.ConnectionId
            };
            try
            {
                result.Guid = await service.CreateAsync(context.Message.Appointment);
            }
            catch (System.Exception e)
            {
                logger.LogError(e, "При сохранении записи произошла ошибка");
            }
            await context.RespondAsync(result);
        }

        public async Task Consume(ConsumeContext<UpdateAppointmentDtoRequest> context)
        {
            logger.LogInformation("Получен запрос UpdateAppointmentDtoRequest {message}", context.Message);
            var result = new UpdateAppointmentDtoResponse()
            {
                Guid = context.Message.Guid,
                Success = true,
                ConnectionId = context.Message.ConnectionId
            };
            try
            {
                result.Success = await service.UpdateAsync(context.Message.Id, context.Message.Appointment);
            }
            catch (System.Exception e)
            {
                logger.LogError(e, "При обновлении записи произошла ошибка");
            }
            await context.RespondAsync(result);
        }

        public async Task Consume(ConsumeContext<DeleteAppointmentDtoRequest> context)
        {
            logger.LogInformation("Получен запрос DeleteAppointmentDtoRequest {message}", context.Message);
            var result = new DeleteAppointmentDtoResponse()
            {
                Guid = context.Message.Guid,
                Success = true,
                ConnectionId = context.Message.ConnectionId
            };
            try
            {
                result.Success = await service.DeleteAsync(context.Message.Id);
            }
            catch (System.Exception e)
            {
                logger.LogError(e, "При удалении записи произошла ошибка");
            }
            await context.RespondAsync(result);
        }
    }
}