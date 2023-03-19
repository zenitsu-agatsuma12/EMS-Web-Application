using EMS_Web_Application.Models;
using System.Numerics;
using System.Xml.Linq;

namespace EMS_Web_Application.Repository.InMemory
{
    public class EmpInMemoryRepository : IEmpRepository
    {
        static List<EmployeeModel> empList = new List<EmployeeModel>();

        static EmpInMemoryRepository()
        {
            empList.Add(new EmployeeModel(1, "Alvin Root", DateTime.Now.AddDays(1), "alvin@gmail.com", "099232312", "IT", 1));
            empList.Add(new EmployeeModel(2, "Tricia Tagle", DateTime.Now.AddDays(2), "trish@gmail.com", "099232322312", "HR", 2));
            empList.Add(new EmployeeModel(3, "Joan DC", DateTime.Now.AddDays(3), "Joan@gmail.com", "09319232312", "CSR", 3));
        }

        public List<EmployeeModel> GetAllEmployees()
        {
        return empList;
        }

        public EmployeeModel AddEmp(EmployeeModel newEmp)
        {
            newEmp.Id = empList.Max(x => x.Id) + 1;
            empList.Add(newEmp);
            return newEmp;
        }

        public EmployeeModel UpdateEmp(int EmpId, EmployeeModel newEmp)
        {
            var oldEmp = empList.Find(x => x.Id == EmpId);
            if (oldEmp == null)
                return null;
            empList.Remove(oldEmp);
            empList.Add(newEmp);
            return newEmp;
        }

        public EmployeeModel DeleteEmp(int EmpId)
        {
            var oldEmp = empList.Find(x => x.Id == EmpId);
            if (oldEmp == null)
                return null;
            empList.Remove(oldEmp);
            return oldEmp;
        }

        public EmployeeModel GetEmpId(int Id)
        {
            return empList.FirstOrDefault(x => x.Id == Id);
        }
    }
}
