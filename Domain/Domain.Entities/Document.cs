using System;

namespace Domain.Entities
{
    /// <summary>
    /// Документ удостоверяющий личность
    /// </summary>
    public class Document : IEntity<Guid>
    {
        public Guid Id { get; set; }

        public Guid AppointmentId { get; set; }
        /// <summary>
        /// Тип документа
        /// </summary>
        public int DocumentType { get; set; }
        /// <summary>
        /// Серия
        /// </summary>
        public string Series { get; set; }
        /// <summary>
        /// Номер
        /// </summary>
        public string Number { get; set; }
        /// <summary>
        /// Дата выдачи
        /// </summary>
        public DateTime IssueDate { get; set; }
        /// <summary>
        /// Кем выдано
        /// </summary>
        public string IssuedBy { get; set; }
        /// <summary>
        /// Код подразделения
        /// </summary>
        public string DepartmentCode { get; set; }

        public virtual Appointment Appointment { get; set; }
    }
}
