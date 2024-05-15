using System.ComponentModel.DataAnnotations;
using WorkSpaceAPI.Model;

namespace WorkSpaceAPI.Controllers.DTO
{
    public class EmployeeDTO
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int Age { get; set; }

        public int DepartmentId { get; set; }
    }
}
