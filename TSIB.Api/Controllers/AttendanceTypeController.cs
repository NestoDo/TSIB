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
    public class AttendanceTypeController : ControllerBase
    {
        private readonly IAttendanceTypeRepository _attendanceTypeRepository;
        public AttendanceTypeController(IAttendanceTypeRepository attendanceTypeRepository)
        {
            _attendanceTypeRepository = attendanceTypeRepository;
        }

        [HttpGet("{search}")]
        public async Task<ActionResult> GetAttendanceType(int attendanceTypeId)
        {
            try
            {
                return Ok(await _attendanceTypeRepository.GetAttendanceType(attendanceTypeId));
            }
            catch (Exception ex)
            {

                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }
    }
}
