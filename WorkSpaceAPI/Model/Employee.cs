using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace WorkSpaceAPI.Model
{
    public class Employee
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }

        public int Age { get; set; }

        public int DepartmentId { get; set; }

        public Department Department { get; set; }
    }
}
