using Microsoft.EntityFrameworkCore;
using WorkSpaceAPI.Controllers.DTO;
using WorkSpaceAPI.DBContexts;
using WorkSpaceAPI.Model;

namespace WorkSpaceAPI.Repository
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly AppContexts _context;

        public EmployeeRepository(AppContexts context)
        {
            _context = context;
        }

        public void AddEmployee(EmployeeDTO employeeDto)
        {
            Employee employee = new Employee
            {
                Name = employeeDto.Name,
                Age = employeeDto.Age,
                DepartmentId = employeeDto.DepartmentId
            };

            _context.Employees.Add(employee);
            _context.SaveChanges();
        }

        public void DeleteEmployee(int employeeId)
        {
            var employeeToDelete = _context.Employees.Find(employeeId);
            if (employeeToDelete != null)
            {
                _context.Employees.Remove(employeeToDelete);
                _context.SaveChanges();
            }
        }

        public IEnumerable<Employee> GetAll()
        {
            return _context.Employees.Include(e => e.Department).ToList();
        }

        public Employee GetEmployee(int employeeId)
        {
            return _context.Employees
                               .Include(e => e.Department)
                               .FirstOrDefault(e => e.Id == employeeId);
        }

        public void UpdateEmployee(int id, EmployeeDTO employeeDto)
        {
            if (employeeDto == null)
            {
                throw new ArgumentNullException(nameof(employeeDto));
            }
            var employeeToUpdate = _context.Employees.Find(id);
            if (employeeToUpdate != null)
            {
                employeeToUpdate.Name = employeeDto.Name;
                employeeToUpdate.Age = employeeDto.Age;
                employeeToUpdate.DepartmentId = employeeDto.DepartmentId;

                _context.Employees.Update(employeeToUpdate);
                _context.SaveChanges();

            }
           
        }
    }
}
