using EMS_Web_Application.Models;

namespace EMS_Web_Application.Repository.InMemory
{
    public class DeptInMemoryRepository : IDeptRepository
    {
        static List<Department> deptList = new List<Department>();

        static DeptInMemoryRepository()
        {
        deptList.Add(new Department(1, "IT"));
        deptList.Add(new Department(2, "HR"));
        deptList.Add(new Department(3, "CSR"));
        }

        public List<Department> GetAllDepartments()
        { 
        return deptList;
        }

        public Department AddDept(Department newDept)
        { 
        newDept.Id = deptList.Max(x => x.Id) + 1;
        deptList.Add(newDept);
        return newDept;
        }

        public Department UpdateDept(int deptId,Department newDept)
        {
        var oldDept = deptList.Find(x => x.Id == deptId);
            if (oldDept == null)
                return null;
            deptList.Remove(oldDept);
            deptList.Add(newDept);
            return newDept;
        }

        public Department DeleteDept(int deptId)
        {
            var oldDept = deptList.Find(x => x.Id == deptId);
            if (oldDept == null)
                return null;
            deptList.Remove(oldDept);
            return oldDept;
        }

        public Department GetDeptId(int Id)
        {
            return deptList.FirstOrDefault(x => x.Id == Id);
        }
    }
}
