using HelpersDTO.AppointmentDto.DTO;
using HelpersDTO.Authentication;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Services.Abstractions;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        private readonly IAppointmentService _appointmentService;
        private readonly ILogger<HomeController> _logger;
        public HomeController(
            IAppointmentService appointmentService,
            ILogger<HomeController> logger)
        {
            _appointmentService = appointmentService;
            _logger = logger;
        }

        [HttpPost("GetAppointments")]
        public async Task<IActionResult> GetAppointmentsAsync(ShortAppointmentRequest request)
        {
            try
            {
                return Ok(await _appointmentService.GetAppointmentsByParametersAsync(request));
            }
            catch (Exception e)
            {
                _logger.LogError(e, "Произошла ошибка в GetAppointments");
                return BadRequest(e.Message);
            }
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
        [HttpPut("UpdateAppointment")]
        public async Task UpdateAppointment(Guid id, UpdatingAppointmentDto appointment)
        {
            await _appointmentService.UpdateAsync(id, appointment);
        }

        [HttpDelete("DeleteAppointment")]
        public async Task<bool> DeleteAppointment(Guid id)
        {
            try
            {
                await _appointmentService.DeleteAsync(id);
                return true;
            }
            catch (Exception e)
            {
                _logger.LogError("Произошла ошибка {message}", e);
            }
            return false;
        }
    }
}