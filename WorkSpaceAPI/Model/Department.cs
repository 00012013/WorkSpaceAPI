using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace WorkSpaceAPI.Model
{
    public class Department
    {
        [Key]
        public int Id { get; set; }
        
        public string Name { get; set; }

        [JsonIgnore]
        public List<Employee> Employees { get; set; }
    }
}
