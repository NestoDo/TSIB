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

        [HttpGet("{reportsummary}")]
        public async Task<ActionResult> GetReportSummary(int employeeId, DateTime summaryDate)
        {
            try
            {
                return Ok(await _reportRepository.GetReportSummary(employeeId, summaryDate));
            }
            catch (Exception ex)
            {

                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }
    }
}
