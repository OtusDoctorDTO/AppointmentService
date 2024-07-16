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
        public async Task<ActionResult<IEnumerable<ShortAppointnmentDTO>>> GetAppointmentsAsync(ShortAppointmentRequest request)
        {
            try
            {
                var apps = await _appointmentService.GetAppointmentsByParametersAsync(request);
                return Ok(apps);
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
        public async Task<ActionResult<AppointmentDto>> GetAppointmentById(Guid id)
        {
            try
            {
                var app = await _appointmentService.GetByIdAsync(id);
                return Ok(app);
            }
            catch (Exception e)
            {
                _logger.LogError(e, "Произошла ошибка в GetAppointments");
                return BadRequest(e.Message);
            }
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

        [HttpPost("UpdateStatus")]
        public async Task<ActionResult<bool>> UpdateStatusAppointment(UpdateStatusAppointmentDto appointmentDto)
        {
            try
            {
                var result = await _appointmentService.UpdateStatusAsync(appointmentDto);
                return Ok(result);
            }
            catch (Exception e)
            {
                _logger.LogError(e, "Произошла ошибка в GetAppointments");
                return BadRequest(e.Message);
            }
        }

        [HttpPost("BookAppointment")]
        public async Task<IActionResult> BookAppointment([FromBody] AppointmentDto appointmentDto)
        {
            if (appointmentDto == null)
            {
                return BadRequest("Invalid appointment data.");
            }

            try
            {
                var result = await _appointmentService.BookAppointmentAsync(appointmentDto);
                if (result)
                {
                    return Ok(true);
                }
                else
                {
                    return StatusCode(500, "Failed to book appointment.");
                }
            }
            catch (Exception ex)
            {
                _logger.LogError($"Error occurred while booking appointment: {ex.Message}");
                return StatusCode(500, "Internal server error.");
            }
        }
        [HttpGet("GetByPatientId")]
        public async Task<ActionResult<IEnumerable<AppointmentDto>>> GetByPatientIdAsync(Guid patientId)
        {
            try
            {
                var appointments = await _appointmentService.GetByPatientIdAsync(patientId);
                return Ok(appointments);
            }
            catch (Exception e)
            {
                _logger.LogError(e, "An error occurred in GetByPatientIdAsync");
                return BadRequest(e.Message);
            }
        }
        [HttpGet("GetAppointmentsByDoctorId")]
        public async Task<ActionResult<IEnumerable<AppointmentDto>>> GetAppointmentsByDoctorIdAsync(Guid doctorId)
        {
            try
            {
                var appointments = await _appointmentService.GetAppointmentsByDoctorIdAsync(doctorId);
                return Ok(appointments);
            }
            catch (Exception e)
            {
                _logger.LogError(e, "An error occurred in GetByPatientIdAsync");
                return BadRequest(e.Message);
            }
        }

    }
}