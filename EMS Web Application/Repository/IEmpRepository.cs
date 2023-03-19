using EMS_Web_Application.Models;

namespace EMS_Web_Application.Repository
{
    public interface IEmpRepository
    {
        List<EmployeeModel> GetAllEmployees();

        EmployeeModel GetEmpId(int employeeId);

        EmployeeModel AddEmp(EmployeeModel employeeModel);

        EmployeeModel UpdateEmp(int EmpId, EmployeeModel employeeModel);

        EmployeeModel DeleteEmp(int employeeId);
    }
}
