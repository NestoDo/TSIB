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

        //[HttpPost]
        //public async Task<ActionResult<Employee>> UpdateAttendance(Employee employee, DateTime attendanceDate, int attendanceType)
        //{
        //    try
        //    {
        //        var updatedEmployee = await _attendanceRepository.UpdateAttendance(employee, attendanceDate, attendanceType);

        //        return updatedEmployee;
        //    }
        //    catch (Exception ex)
        //    {
        //        return StatusCode(StatusCodes.Status500InternalServerError, $"Error updating data {ex.Message} {ex.InnerException}");
                
        //    }
        //}

    }
}
