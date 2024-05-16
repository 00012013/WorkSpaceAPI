using Microsoft.AspNetCore.Mvc;
using WorkSpaceAPI.Controllers.DTO;
using WorkSpaceAPI.Repository;

namespace WorkSpaceAPI.Controllers
{
    [Route("api/employees")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployeeRepository _employeeRepository;

        public EmployeeController(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }

        // GET: api/employees
        [HttpGet]
        public IActionResult GetAllEmployees()
        {
            var employees = _employeeRepository.GetAll();
            return Ok(employees);
        }

        // GET: api/employees/{id}
        [HttpGet("{id}")]
        public IActionResult GetEmployeeById(int id)
        {
            var employee = _employeeRepository.GetEmployee(id);

            if (employee == null)
            {
                return NotFound();
            }

            return Ok(employee);
        }

        // POST: api/employees
        [HttpPost]
        public IActionResult AddEmployee([FromBody] EmployeeDTO employee)
        {
            _employeeRepository.AddEmployee(employee);
            return CreatedAtAction(nameof(GetEmployeeById), new { id = employee.Id }, employee);
        }

        // PUT: api/employees/{id}
        [HttpPut("{id}")]
        public IActionResult UpdateEmployee(int id, [FromBody] EmployeeDTO employee)
        {
            _employeeRepository.UpdateEmployee(id, employee);
            return NoContent();
        }

        // DELETE: api/employees/{id}
        [HttpDelete("{id}")]
        public IActionResult DeleteEmployee(int id)
        {
            _employeeRepository.DeleteEmployee(id);
            return NoContent();
        }
    }
}
