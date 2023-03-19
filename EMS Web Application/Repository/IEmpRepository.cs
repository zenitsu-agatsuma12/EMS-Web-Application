using EMS_Web_Application.Models;

namespace EMS_Web_Application.Repository
{
    public interface IEmpRepository
    {
        List<Employee> GetAllEmployees();

        Employee GetEmpId(int employeeId);

        Employee AddEmp(Employee employeeModel);

        Employee UpdateEmp(int EmpId, Employee employeeModel);

        Employee DeleteEmp(int employeeId);
    }
}
