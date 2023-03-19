using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace EMS_Web_Application.Models
{
    public class DepartmentModel
    {
        public int Id { get; set; }
        [Required]
        public string Department { get; set; }

        public DepartmentModel() { }

        public DepartmentModel (int id, string dept)
        {
            Id = id;
            Department = dept;
        }
    }
}
