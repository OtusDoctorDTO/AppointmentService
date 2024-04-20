using HelpersDTO.AppointmentDto.DTO;
using Microsoft.AspNetCore.Mvc;
using Services.Abstractions;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AppointmentController : ControllerBase
    {
        private readonly IAppointmentService _appointmentService;
        public AppointmentController(IAppointmentService appointmentService)
        {
            _appointmentService = appointmentService;
        }
        [HttpGet("GetPaged")]
        public async Task<IEnumerable<AppointmentDto>> AppointmentList(int page, int pageSize)
        {
            return await _appointmentService.GetPagedAsync(page, pageSize);
        }
        [HttpGet("GetAppointmentbyId")]
        public async Task<AppointmentDto> GetAppointmentById(Guid id)
        {
            return await _appointmentService.GetByIdAsync(id);
        }
        [HttpPost("AddAppointment")]
        public async Task AddAppointment(CreatingAppointmentDto appointment)
        {
            await _appointmentService.CreateAsync(appointment);
        }
        [HttpPut("updateAppointment")]
        public async Task UpdateAppointment(Guid id, UpdatingAppointmentDto appointment)
        {
            await _appointmentService.UpdateAsync(id, appointment);
        }
        [HttpDelete("deleteAppointment")]
        public async Task<bool> DeleteAppointment(Guid id)
        {
            try
            {
                await _appointmentService.DeleteAsync(id);
                return true;
            }
            catch (Exception)
            {
                // Логи
            }
            return false;
        }
    }
}