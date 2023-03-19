using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace EMS_Web_Application.Models
{
    public class Department
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public List<Employee> Employees { get; set; } = new List<Employee>();

        public Department() { }

        public Department (int id, string dept)
        {
            Id = id;
            Name = dept;
        }
    }
}
