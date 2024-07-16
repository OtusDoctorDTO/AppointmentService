using Domain.Entities;
using HelpersDTO.AppointmentDto.DTO;
using Infrastructure.EntityFramework;
using Microsoft.EntityFrameworkCore;
using Services.Repositories.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Infrastructure.Repositories.Implementations
{
    /// <summary>
    /// Репозиторий работы с записями.
    /// </summary>
    public class AppointmentRepository : IAppointmentRepository
    {
        private DatabaseContext _context;
        public AppointmentRepository(DatabaseContext context)
        {
            _context = context;
        }

        public async Task<Guid> CreateAsync(Appointment appointment)
        {
            appointment.CreateDate = DateTime.Now;
            _context.Appointments.Add(appointment);
            await _context.SaveChangesAsync();
            return appointment.Id;
        }

        public async Task<bool> DeleteAsync(Guid id)
        {
            var appointment = await GetByIdAsync(id);
            if (appointment == null)
                throw new NullReferenceException($"Такой записи с id {id} нет");
            appointment.Status = (int)RelevanceStatusEnum.Deleted;
            appointment.IsDeleted = true;
            await _context.SaveChangesAsync();
            return true;
        }

        /// <summary>
        /// Получить список
        /// </summary>
        /// <returns>Список записей</returns>
        public async Task<List<Appointment>> GetAllAsync()
        {
            return await _context.Appointments.ToListAsync();
        }

        public async Task<Appointment> GetByIdAsync(Guid id)
        {
            return await _context.Appointments.FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<List<Appointment>> GetPagedAsync(int page, int pageSize)
        {
            return await _context.Appointments
                .OrderByDescending(x => x.CreateDate)
                .Skip(pageSize * page)
                .Take(pageSize)
                .ToListAsync();
        }

        public async Task<bool> UpdateAsync(Appointment appointment)
        {
            try
            {
                var appointmentDB = await GetByIdAsync(appointment.Id);
                if (appointmentDB == null)
                    throw new NullReferenceException($"Такой записи с id {appointment.Id} нет");
                appointmentDB.Price = appointment.Price;
                appointmentDB.Duration = appointment.Duration;
                appointmentDB.Time = appointment.Time;
                appointmentDB.DoctorId = appointment.DoctorId;
                appointmentDB.PatientId = appointment.PatientId;
                appointmentDB.IsDeleted = appointment.IsDeleted;
                appointmentDB.Status = appointment.Status;
                await _context.SaveChangesAsync();
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }

        /// <summary>
        /// Получить список записей по параметрам
        /// </summary>
        /// <param name="sinceDate">С</param>
        /// <param name="forDate">По</param>
        /// <param name="statuses">Список нужных статусов</param>
        /// <param name="count">кол-во</param>
        /// <returns></returns>
        public async Task<List<Appointment>> GetByParametersAsync(
            DateTime? sinceDate = null,
            DateTime? forDate = null,
            int[] statuses = null,
            int? count = null)
        {
            var result = await _context.Appointments.Where(appointment =>
            (sinceDate == null || appointment.Time > sinceDate!.Value) &&
            (forDate == null || appointment.Time <= forDate!.Value) &&
            ((statuses == null || !statuses.Any()) || statuses.Contains(appointment.Status)))
                .OrderByDescending(x => x.CreateDate)
                .ToListAsync();
            if (count != null && count < result.Count)
                return result.Take(count!.Value).ToList();
            return result;
        }

        public async Task<IEnumerable<Appointment>> GetByPatientIdAsync(Guid patientId)
        {
            return await _context.Appointments.Where(a => a.PatientId == patientId).ToListAsync();
        }

        public async Task<List<Appointment>> GetAppointmentsByDoctorIdAsync(Guid doctorId)
        {
            return await _context.Appointments
            .Where(a => a.DoctorId == doctorId)
            .ToListAsync();
        }
    }
}
