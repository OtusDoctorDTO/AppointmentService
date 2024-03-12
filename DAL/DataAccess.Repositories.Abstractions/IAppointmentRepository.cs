using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Appointment.Repositories
{
    /// <summary>
    /// Интерфейс репозитория работы с курсами.
    /// </summary>
    public interface IAppointmentRepository
    {
        Task<Guid> AddAsync(Entities.Appointment appointment);
        Task DeleteAsync(Guid id);

        /// <summary>
        /// Получить все записи
        /// </summary>
        /// <returns>Список записей</returns>
        Task<List<Entities.Appointment>> GetAllAsync();

        Task<Entities.Appointment> GetAsync(Guid id);

        /// <summary>
        /// Получить записи постранично
        /// </summary>
        /// <param name="page"></param>
        /// <param name="pageSize"></param>
        /// <returns></returns>
        Task<List<Entities.Appointment>> GetPagedAsync(int page, int pageSize);
        Task Update(Entities.Appointment appointment);
    }
}
