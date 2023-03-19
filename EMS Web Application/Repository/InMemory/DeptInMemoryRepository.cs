using EMS_Web_Application.Models;

namespace EMS_Web_Application.Repository.InMemory
{
    public class DeptInMemoryRepository : IDeptRepository
    {
        static List<DepartmentModel> deptList = new List<DepartmentModel>();

        static DeptInMemoryRepository()
        {
        deptList.Add(new DepartmentModel(1, "IT"));
        deptList.Add(new DepartmentModel(2, "HR"));
        deptList.Add(new DepartmentModel(3, "CSR"));
        }

        public List<DepartmentModel> GetAllDepartments()
        { 
        return deptList;
        }

        public DepartmentModel AddDept(DepartmentModel newDept)
        { 
        newDept.Id = deptList.Max(x => x.Id) + 1;
        deptList.Add(newDept);
        return newDept;
        }

        public DepartmentModel UpdateDept(int deptId,DepartmentModel newDept)
        {
        var oldDept = deptList.Find(x => x.Id == deptId);
            if (oldDept == null)
                return null;
            deptList.Remove(oldDept);
            deptList.Add(newDept);
            return newDept;
        }

        public DepartmentModel DeleteDept(int deptId)
        {
            var oldDept = deptList.Find(x => x.Id == deptId);
            if (oldDept == null)
                return null;
            deptList.Remove(oldDept);
            return oldDept;
        }

        public DepartmentModel GetDeptId(int Id)
        {
            return deptList.FirstOrDefault(x => x.Id == Id);
        }
    }
}
