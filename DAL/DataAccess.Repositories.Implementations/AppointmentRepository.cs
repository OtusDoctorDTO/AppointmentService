using Appointment.EntityFramework;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Appointment.Repositories
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

        public async Task<Guid> AddAsync(Entities.Appointment appointment)
        {
            appointment.CreateDate = DateTime.Now;
            _context.Appointments.Add(appointment);
            await _context.SaveChangesAsync();
            return appointment.Id;
        }

        public async Task DeleteAsync(Guid id)
        {
            var appointment = await GetAsync(id);
            if(appointment == null)
                throw new NullReferenceException($"Такой записи с id {id} нет");
            _context.Appointments.Remove(appointment);
            await _context.SaveChangesAsync();
        }

        /// <summary>
        /// Получить список
        /// </summary>
        /// <returns>Список записей</returns>
        public async Task<List<Entities.Appointment>> GetAllAsync()
        {
            return await _context.Appointments.ToListAsync();
        }

        public async Task<Entities.Appointment?> GetAsync(Guid id)
        {
            return await _context.Appointments.FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<List<Entities.Appointment>> GetPagedAsync(int page, int pageSize)
        {
            return await _context.Appointments
                .OrderByDescending(x => x.CreateDate)
                .Skip(pageSize * page)
                .Take(pageSize)
                .ToListAsync();
        }

        public async Task Update(Entities.Appointment appointment)
        {
            var appointmentDB = await GetAsync(appointment.Id);
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
    }
}
