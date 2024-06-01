using Domain.Entities;
using HelpersDTO.AppointmentDto.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using HelpersDTO.AppointmentDto.Enums;

namespace Services.Implementations.Mapping
{
    public static class Extentions
    {
        public static List<AppointmentDto> ToAppointmentsDto(this List<Appointment> appointments)
        {
            return appointments.Select(p => p.ToAppointmentDto()).ToList();
        }

        public static AppointmentDto ToAppointmentDto(this Appointment appointment)
        {
            if (appointment == null) return null;
            return new AppointmentDto()
            {
                Id = appointment.Id,
                Price = appointment.Price,
                CreateDate = appointment.CreateDate,
                Duration = appointment.Duration,
                Time = appointment.Time,
                DoctorId = appointment.DoctorId,
                PatientId = appointment.PatientId,
                Status = appointment.Status.GetDescription()
            };
        }


        public static Appointment ToAppointment(this CreatingAppointmentDto appointment)
        {
            if (appointment == null) return null;
            return new Appointment()
            {
                Price = appointment.Price,
                Time = appointment.Time,
                DoctorId = appointment.DoctorId,
                PatientId = appointment.PatientId
            };
        }
        public static Appointment ToAppointment(this AppointmentDto appointment)
        {
            if (appointment == null) return null;
            return new Appointment()
            {
                Id = appointment.Id,
                Price = appointment.Price,
                CreateDate = appointment.CreateDate,
                Duration = appointment.Duration,
                Time = appointment.Time,
                DoctorId = appointment.DoctorId,
                PatientId = appointment.PatientId,
                Status = (int)appointment.Status.ParseEnum<RelevanceStatusEnum>()
            };
        }

        public static Appointment ToAppointment(this UpdatingAppointmentDto appointment)
        {
            if (appointment == null) return null;
            return new Appointment()
            {
                Id = appointment.Id,
                Price = appointment.Price,
                Time = appointment.Time,
                DoctorId = appointment.DoctorId,
                PatientId = appointment.PatientId,
                Status = (int)appointment.Status
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

        public static ShortAppointnmentDTO ToShortAppointnmentDTO(this Appointment appointment)
        {
            if (appointment == null) return null;
            return new ShortAppointnmentDTO()
            {
                DoctorId = appointment.DoctorId,
                Id = appointment.Id,
                Price = appointment.Price,
                Date = new DateOnly(appointment.Time.Year, appointment.Time.Month, appointment.Time.Day),
                Time = new TimeOnly(appointment.Time.Hour, appointment.Time.Minute),
                PatientId = appointment.PatientId,
                Status = ((StatusEnum)appointment.Status).GetDescription()
            };
        }
    }
}
