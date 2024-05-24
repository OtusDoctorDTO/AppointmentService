using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public static class Constants
    {
        private static int dayCount = 7;
        private static int weekCount = 5;
        private static int duration = 20;
        private static Guid[] doctorsIds = new Guid[]
        {
            Guid.Parse("61dd8fe5-aed3-44af-a451-823caeb2dc68"),
            Guid.Parse("c302105d-1c7e-4db4-9380-d91146596f05"),
            Guid.Parse("eec214ba-7605-4392-9ec4-e788ded53bea"),
            Guid.Parse("a372bf3d-efe9-4f0d-b16b-ac550a3947d2"),
            Guid.Parse("c5508ee0-fbe6-47fa-b7d3-d6438b93b43d")
        };

        // создать несколько дефолтных записей для теста
        public static Appointment[] CreateDefaultAppoiments()
        {
            var result = new List<Appointment>(weekCount * dayCount);
            // для каждого врача создаем несколько записей на неделю
            foreach (var doctorId in doctorsIds)
            {
                for (int i = 0; i < weekCount; i++)
                {
                    for (int j = 1; j <= dayCount; j++)
                    {
                        result.Add(new Appointment()
                        {
                            Id = Guid.NewGuid(),
                            Price = j * 1000,
                            CreateDate = DateTime.Now,
                            Duration = duration,
                            Time = DateTime.Today.AddDays(j).AddHours(9).AddMinutes(j * duration),
                            DoctorId = doctorId,
                            PatientId = null,
                            IsDeleted = false,
                            Status = (int)StatusEnum.Free
                        }); ;
                    }
                }
            }
            return result.ToArray();
        }
    }
}
