using EMS_Web_Application.Models;

namespace EMS_Web_Application.Repository
{
    public interface IDeptRepository
    {
        List<DepartmentModel> GetAllDepartments();

        DepartmentModel GetDeptId(int deptId);

        DepartmentModel AddDept(DepartmentModel departmentModel);

        DepartmentModel UpdateDept(int deptId, DepartmentModel departmentModel);

        DepartmentModel DeleteDept(int deptId);
    }
}
