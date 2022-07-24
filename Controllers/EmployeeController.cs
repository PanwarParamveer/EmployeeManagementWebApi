using AutoMapper;
using EmployeeManagementWebApi.ClientDtos;
using EmployeeManagementWebApi.Models;
using EmployeeManagementWebApi.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeManagementWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        IEmployeeService _employeeService;
        IMapper _mapper;
        public EmployeeController( IEmployeeService employeeService,IMapper mapper)
        {
            _employeeService = employeeService;
            _mapper = mapper;
        }
        [HttpGet]
        [Route("GetAllEmployee")]
        public ActionResult <List<Employee>> GetAllEmployee()
        {
            return Ok(_mapper.Map<List<EmployeeDto>>(_employeeService.GetAllEmployee()));
        }

        [HttpGet]
        [Route("GetEmployee")]
        public ActionResult<EmployeeDto> GetEmployee(int empID)
        {
            return _mapper.Map<EmployeeDto>(_employeeService.GetEmployeeById(empID));
        }

    }
}
