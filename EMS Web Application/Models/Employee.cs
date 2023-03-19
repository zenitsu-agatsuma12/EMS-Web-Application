using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EMS_Web_Application.Models
{    public class Employee
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }

        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}")]
        public DateTime DOB { get; set; }
        [EmailAddress]
        public string Email { get; set; }
        public string Phone { get; set; }
        public Department Department { get; set; } = default!;
        public int DepartmentId { get; set; }

        public Employee() { }

        public Employee(int id, string name, DateTime dOB, string email, string phone, int deptid)
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
