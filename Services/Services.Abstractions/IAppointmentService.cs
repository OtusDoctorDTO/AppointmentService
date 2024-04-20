using HelpersDTO.AppointmentDto.DTO;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Services.Abstractions
{
    /// <summary>
    /// Cервис работы с записями (интерфейс)
    /// </summary>
    public interface IAppointmentService
    {
        /// <summary>
        /// Получить список записей
        /// </summary>
        /// <param name="page">Номер страницы</param>
        /// <param name="pageSize">Объем страницы</param>
        /// <returns>Список записей</returns>
        Task<ICollection<AppointmentDto>> GetPagedAsync(int page, int pageSize);

        /// <summary>
        /// Получить запись
        /// </summary>
        /// <param name="id">Идентификатор</param>
        /// <returns>ДТО записи</returns>
        Task<AppointmentDto> GetByIdAsync(Guid id);

        /// <summary>
        /// Создать запись
        /// </summary>
        /// <param name="creatingAppointmentDto">ДТО создаваемой записи</param>
        Task<Guid> CreateAsync(CreatingAppointmentDto creatingAppointmentDto);

        /// <summary>
        /// Изменить запись
        /// </summary>
        /// <param name="id">Иентификатор</param>
        /// <param name="updatingAppointmentDto">ДТО редактируемой записи</param>
        Task<bool> UpdateAsync(Guid id, UpdatingAppointmentDto updatingAppointmentDto);

        /// <summary>
        /// Удалить запись
        /// </summary>
        /// <param name="id">Идентификатор</param>
        Task<bool> DeleteAsync(Guid id);
    }
}