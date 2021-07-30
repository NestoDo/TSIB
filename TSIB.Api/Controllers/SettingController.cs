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
    public class SettingController : ControllerBase
    {
        private readonly ISettingRepository _settingRepository;
        public SettingController(ISettingRepository settingRepository)
        {
            _settingRepository = settingRepository;
        }

        [HttpGet("{search}")]
        public async Task<ActionResult> GetSetting()
        {
            try
            {
                return Ok(await _settingRepository.GetSetting());
            }
            catch (Exception ex)
            {

                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }
    }
}
