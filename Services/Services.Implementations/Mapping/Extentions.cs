using Domain.Entities;
using HelpersDTO.AppointmentDto.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace Services.Implementations.Mapping
{
    public static class Extentions
    {
        public static List<AppointmentDto> ToAppointmentsDto(this List<Appointment> Appointments)
        {
            return Appointments.Select(p => p.ToAppointmentDto()).ToList();
        }

        public static AppointmentDto ToAppointmentDto(this Appointment Appointment)
        {
            if(Appointment == null) return null;
            return new AppointmentDto()
            {
                Id = Appointment.Id,
                Price = Appointment.Price,
                CreateDate = Appointment.CreateDate,
                Duration = Appointment.Duration,
                Time = Appointment.Time,
                DoctorId = Appointment.DoctorId,
                PatientId = Appointment.PatientId,
                Status = Appointment.Status.GetDescription()
            };
        }

        
        public static Appointment ToAppointment(this CreatingAppointmentDto Appointment)
        {
            if (Appointment == null) return null;
            return new Appointment()
            {
                Price = Appointment.Price,
                Time = Appointment.Time,
                DoctorId = Appointment.DoctorId,
                PatientId = Appointment.PatientId
            };
        }
        public static Appointment ToAppointment(this AppointmentDto Appointment)
        {
            if (Appointment == null) return null;
            return new Appointment()
            {
                Id = Appointment.Id,
                Price = Appointment.Price,
                CreateDate = Appointment.CreateDate,
                Duration = Appointment.Duration,
                Time = Appointment.Time,
                DoctorId = Appointment.DoctorId,
                PatientId = Appointment.PatientId,
                Status = (int)Appointment.Status.ParseEnum<RelevanceStatusEnum>()
            };
        }

        public static Appointment ToAppointment(this UpdatingAppointmentDto Appointment)
        {
            if (Appointment == null) return null;
            return new Appointment()
            {
                Id = Appointment.Id,
                Price = Appointment.Price,
                Time = Appointment.Time,
                DoctorId = Appointment.DoctorId,
                PatientId = Appointment.PatientId,
                Status = (int)Appointment.Status
            };
        }


        public static string GetDescription<T>(this T enumValue) where T : struct, IConvertible
        {
            if (!typeof(T).IsEnum)
                return null;

            var description = enumValue.ToString();
            var fieldInfo = enumValue.GetType().GetField(enumValue.ToString());

            if (fieldInfo != null)
            {
                var attrs = fieldInfo.GetCustomAttributes(typeof(DescriptionAttribute), true);
                if (attrs != null && attrs.Length > 0)
                {
                    description = ((DescriptionAttribute)attrs[0]).Description;
                }
            }

            return description;
        }

        public static T ParseEnum<T>(this string value)
        {
            return (T)Enum.Parse(typeof(T), value, true);
        }
    }
}
