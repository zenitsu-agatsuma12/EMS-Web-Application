using EMS_Web_Application.Models;
using System.Numerics;
using System.Xml.Linq;

namespace EMS_Web_Application.Repository.InMemory
{
    public class EmpInMemoryRepository : IEmpRepository
    {
        static List<Employee> empList = new List<Employee>();

        static EmpInMemoryRepository()
        {
            empList.Add(new Employee(1, "Alvin Root", DateTime.Now.AddDays(1), "alvin@gmail.com", "099232312",  1));
            empList.Add(new Employee(2, "Tricia Tagle", DateTime.Now.AddDays(2), "trish@gmail.com", "099232322312",  2));
            empList.Add(new Employee(3, "Joan DC", DateTime.Now.AddDays(3), "Joan@gmail.com", "09319232312",  3));
        }

        public List<Employee> GetAllEmployees()
        {
        return empList;
        }

        public Employee AddEmp(Employee newEmp)
        {
            newEmp.Id = empList.Max(x => x.Id) + 1;
            empList.Add(newEmp);
            return newEmp;
        }

        public Employee UpdateEmp(int EmpId, Employee newEmp)
        {
            var oldEmp = empList.Find(x => x.Id == EmpId);
            if (oldEmp == null)
                return null;
            empList.Remove(oldEmp);
            empList.Add(newEmp);
            return newEmp;
        }

        public Employee DeleteEmp(int EmpId)
        {
            var oldEmp = empList.Find(x => x.Id == EmpId);
            if (oldEmp == null)
                return null;
            empList.Remove(oldEmp);
            return oldEmp;
        }

        public Employee GetEmpId(int Id)
        {
            return empList.FirstOrDefault(x => x.Id == Id);
        }
    }
}
