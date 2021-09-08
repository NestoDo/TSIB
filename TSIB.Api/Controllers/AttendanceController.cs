using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;
using TSIB.Api.Models;
using TSIB.Api.Repositories;

namespace TSIB.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AttendanceController : ControllerBase
    {
        private readonly IAttendanceRepository _attendanceRepository;
        public AttendanceController(IAttendanceRepository attendanceRepository)
        {
            _attendanceRepository = attendanceRepository;
        }

        [HttpGet("{search}")]
        public async Task<ActionResult> GetAttendance(int employeeId, int year, int month)
        {
            try
            {
                return Ok(await _attendanceRepository.GetAttendance(employeeId, year, month));
            }
            catch (Exception ex)
            {

                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpPost]
        public async Task<ActionResult<Attendance>> UpdateAttendance(Attendance attendance)
        {
            try
            {
                var updatedattendance = await _attendanceRepository.UpdateAttendance(attendance);

                return updatedattendance;
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, $"Error updating data {ex.Message} {ex.InnerException}");

            }
        }

        [HttpPost("updateComment")]
        public async Task<ActionResult<Attendance>> UpdateComment(Attendance attendance)
        {
            try
            {
                var updatedattendance = await _attendanceRepository.UpdateComment(attendance);

                return updatedattendance;
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, $"Error updating data {ex.Message} {ex.InnerException}");

            }
        }

    }
}
