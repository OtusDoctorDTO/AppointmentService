using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Services.Repositories.Abstractions
{
    /// <summary>
    /// Интерфейс репозитория работы с записями
    /// </summary>
    public interface IAppointmentRepository
    {
        Task<List<Appointment>> GetPagedAsync(int page, int pageSize);
        Task<Appointment> GetByIdAsync(Guid id);
        Task<Guid> CreateAsync(Appointment appointment);
        Task<bool> DeleteAsync(Guid id);
        Task<bool> UpdateAsync(Appointment appointment);
        Task<List<Appointment>> GetAllAsync();
        Task<List<Appointment>> GetByParametersAsync(DateTime? sinceDate = null, DateTime? forDate = null, int[] statuses = null, int? count = null);
    }
}
