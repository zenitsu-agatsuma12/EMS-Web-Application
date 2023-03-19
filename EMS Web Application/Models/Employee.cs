using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EMS_Web_Application.Models
{    public class EmployeeModel
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }

        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}")]
        public DateTime DOB { get; set; }
        [EmailAddress]
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Department { get; set; }
        public int DepartmentId { get; set; }

        public EmployeeModel() { }

        public EmployeeModel(int id, string name, DateTime dOB, string email, string phone, string dept, int deptid)
        {
        Id = id;
        Name = name;
        DOB = dOB;        
        Email = email;
        Phone = phone;
        Department =  dept;
        DepartmentId = deptid;
        }
       
    }
}
