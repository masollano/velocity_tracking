using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using VelocityTracking.WebApi.Application.Interfaces;
using VelocityTracking.WebApi.Contracts.Employee;
using VelocityTracking.WebApi.Entities;

namespace VelocityTracking.WebApi.Controllers
{
    [Route("api/employees")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        //private readonly IEmployeeRepository _employeeRepository;
        //public EmployeeController(IEmployeeRepository employeeRepository)
        //{
        //    _employeeRepository = employeeRepository;
        //}

        //[HttpPost]
        //public async Task<IActionResult> CreateEmployee(EmployeeRequest request)
        //{
        //    var newEmployee = new Employee();
        //    newEmployee.Name = request.Name;
        //    newEmployee.DatetimeCreated = DateTime.Now;
        //    newEmployee.StatusCode = 1000;
        //    var result = await _employeeRepository.CreateEmployee(newEmployee);
        //    return Ok(result);
        //}

        //[HttpGet]
        //public async Task<IActionResult> GetEmployees()
        //{
        //    var employees = await _employeeRepository.GetEmployees();
        //    return Ok(employees);
        //}
        //[HttpGet("{id:int}")]
        //public async Task<IActionResult> GetEmployeeById(int id)
        //{
        //    var employee = await _employeeRepository.GetEmployeeById(id);
        //    return Ok(employee);
        //}
    }
}
