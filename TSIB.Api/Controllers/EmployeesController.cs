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
    public class EmployeesController : ControllerBase
    {
        private readonly IEmployeeRepository _employeeRepository;
        public EmployeesController(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }

        [HttpGet]
        public async Task<ActionResult> GetEmployees(int employeeId, string FirstName, string LastName)
        {
            try
            {
                return Ok(await _employeeRepository.GetEmployees(employeeId, FirstName, LastName));
            }
            catch (Exception ex)
            {

                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        //[HttpGet("{id:int}")]
        //public async Task<ActionResult<Employee>> GetEmployee(int id)
        //{
        //    try
        //    {
        //        var result = await _employeeRepository.GetEmployee(id);

        //        if (result == null)
        //        {
        //            return NotFound();
        //        }

        //        return result;
        //    }
        //    catch (Exception ex)
        //    {
        //        return StatusCode(StatusCodes.Status500InternalServerError, $"Error retrieving data from the database { ex.Message} {ex.InnerException}");

        //    }
        //}

        [HttpPost]
        public async Task<ActionResult<Employee>> CreateEmployee(Employee employee)
        {
            try
            {
                if (employee == null)
                {
                    return BadRequest();
                }

                var createdEmployee = await _employeeRepository.AddEmployee(employee);

                //return CreatedAtAction(nameof(GetEmployee), new { id = createdEmployee.EmployeeId }, createdEmployee);
                return createdEmployee;
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, $"Error retrieving data from the database { ex.Message} {ex.InnerException}");
            }
        }

        [HttpPut]
        public async Task<ActionResult<Employee>> UpdateEmployee(Employee employee)
        {
            try
            {
                var updatedEmployee = await _employeeRepository.UpdateEmployee(employee);

                return updatedEmployee;
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, $"Error updating data {ex.Message} {ex.InnerException}");
                
            }
        }

    }
}
