using WorkSpaceAPI.Controllers.DTO;
using WorkSpaceAPI.Model;

namespace WorkSpaceAPI.Repository
{
    public interface IEmployeeRepository
    {
        void AddEmployee(EmployeeDTO employee);

        void UpdateEmployee(int id, EmployeeDTO employee);

        void DeleteEmployee(int employeeId);

        Employee GetEmployee(int employeeId);

        IEnumerable<Employee> GetAll();
    }
}
