using EMS_Web_Application.Models;

namespace EMS_Web_Application.Repository
{
    public interface IDeptRepository
    {
        List<Department> GetAllDepartments();

        Department GetDeptId(int deptId);

        Department AddDept(Department departmentModel);

        Department UpdateDept(int deptId, Department departmentModel);

        Department DeleteDept(int deptId);
    }
}
