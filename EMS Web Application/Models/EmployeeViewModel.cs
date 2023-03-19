

using System.ComponentModel.DataAnnotations;

namespace EMS_Web_Application.Models
{
    public class EmployeeViewModel
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }

        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}")]
        public DateTime DOB { get; set; }
        [EmailAddress]
        public string Email { get; set; }
        public string Phone { get; set; }
        public int DepartmentId { get; set; }

        public EmployeeViewModel() { }

        public EmployeeViewModel(int id, string name, DateTime dOB, string email, string phone, int deptid)
        {
            Id = id;
            Name = name;
            DOB = dOB;
            Email = email;
            Phone = phone;
            DepartmentId = deptid;
        }

    }
}
