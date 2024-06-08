using System;
using System.ComponentModel.DataAnnotations;

namespace Domain.Entities
{
    public class Appointment
    {
        /// <summary>
        /// Идентификатор
        /// </summary>
        [Key]
        public Guid Id { get; set; }

        /// <summary>
        /// Стоимость
        /// </summary>
        public decimal Price { get; set; }

        /// <summary>
        /// Дата создания
        /// </summary>
        public DateTime CreateDate { get; set; }

        /// <summary>
        /// Продолжительность приема
        /// </summary>
        public int Duration { get; set; }
        /// <summary>
        /// Время начала записи
        /// </summary>
        public DateTime Time { get; set; }
        /// <summary>
        /// Идентификатор врача
        /// </summary>
        public Guid? DoctorId { get; set; }
        /// <summary>
        /// Идентификатор пациента
        /// </summary>
        public Guid? PatientId { get; set; }
        
        /// <summary>
        /// Удалена
        /// </summary>
        public bool IsDeleted { get; set; }

        /// <summary>
        /// Статус
        /// </summary>
        public int Status { get; set; }
    }
}
