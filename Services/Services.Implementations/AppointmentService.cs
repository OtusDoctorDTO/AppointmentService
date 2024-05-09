using Domain.Entities;
using HelpersDTO.AppointmentDto.DTO;
using HelpersDTO.Authentication;
using Services.Abstractions;

using Services.Implementations.Mapping;
using Services.Repositories.Abstractions;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Services.Implementations
{
    /// <summary>
    /// Cервис работы с пациентами
    /// </summary>
    public class AppointmentService : IAppointmentService
    {
        private readonly IAppointmentRepository _repository;

        public AppointmentService(IAppointmentRepository courseRepository)
        {
            _repository = courseRepository;
        }

        /// <summary>
        /// Получить список
        /// </summary>
        /// <param name="page">номер страницы</param>
        /// <param name="pageSize">объем страницы</param>
        /// <returns></returns>
        public async Task<ICollection<AppointmentDto>> GetPagedAsync(int page, int pageSize)
        {
            var result = await _repository.GetPagedAsync(page, pageSize);
            return result.ToAppointmentsDto();
        }

        /// <summary>
        /// Получить
        /// </summary>
        /// <param name="id">идентификатор</param>
        /// <returns>ДТО пациента</returns>
        public async Task<AppointmentDto> GetByIdAsync(Guid id)
        {
            var Appointment = await _repository.GetByIdAsync(id);
            return Appointment.ToAppointmentDto();
        }

        /// <summary>
        /// Создать
        /// </summary>
        /// <param name="appointmentDto">ДТО пациента</param>
        /// <returns>идентификатор</returns>
        public async Task<Guid> CreateAsync(CreatingAppointmentDto appointmentDto)
        {
            var Appointment = appointmentDto.ToAppointment();
            return await _repository.CreateAsync(Appointment);
        }

        /// <summary>
        /// Изменить
        /// </summary>
        /// <param name="id">идентификатор</param>
        /// <param name="AppointmentDto">ДТО пациента</param>
        public async Task<bool> UpdateAsync(Guid id, UpdatingAppointmentDto appointmentDto)
        {
            var appointment = appointmentDto.ToAppointment();
            appointment.Id = id;
            return await _repository.UpdateAsync(appointment);
        }

        /// <summary>
        /// Удалить
        /// </summary>
        /// <param name="id">идентификатор</param>
        public async Task<bool> DeleteAsync(Guid id)
        {
           return await _repository.DeleteAsync(id);
        }

        public async Task<List<ShortAppointnmentDTO>?> GetAppointmentsByParametersAsync(ShortAppointmentRequest parameters)
        {
            return await _repository.GetByParametersAsync(parameters);
        }
    }
}