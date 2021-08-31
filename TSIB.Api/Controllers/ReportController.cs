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
    public class ReportController : ControllerBase
    {
        private readonly IReportRepository _reportRepository;
        public ReportController(IReportRepository reportRepository)
        {
            _reportRepository = reportRepository;
        }

        [HttpGet("reportsummary")]
        public async Task<ActionResult> GetReportSummary(int employeeId, DateTime dateInit, DateTime dateEnd)
        {
            try
            {
                return Ok(await _reportRepository.GetReportSummary(employeeId, dateInit, dateEnd));
            }
            catch (Exception ex)
            {

                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpGet("reportsummarydetail")]
        public async Task<ActionResult> GetReportSummaryDetail(int employeeId, DateTime dateInit, DateTime dateEnd)
        {
            try
            {
                return Ok(await _reportRepository.GetReportSummaryDetail(employeeId, dateInit, dateEnd));
            }
            catch (Exception ex)
            {

                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpGet("reportsummarygroup")]
        public async Task<ActionResult> GetReportSummaryGroup(int employeeId, DateTime dateInit, DateTime dateEnd)
        {
            try
            {
                return Ok(await _reportRepository.GetReportSummaryGroup(employeeId, dateInit, dateEnd));
            }
            catch (Exception ex)
            {

                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }
    }
}
