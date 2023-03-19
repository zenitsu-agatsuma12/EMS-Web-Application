using Microsoft.EntityFrameworkCore;
using EMS_Web_Application.Data;
using EMS_Web_Application.Models;

namespace EMS_Web_Application.Repository.MsSQL
{
    public class EmpDBRepository : IEmpRepository
    {
        // interact with database and perform CRUD 

        EMSDBContext _dbContext;

        public EmpDBRepository(EMSDBContext dbContext)
        {
            _dbContext = dbContext;
        }


        public EmployeeModel AddEmp(EmployeeModel newEmp)
        {
            _dbContext.Add(newEmp);
            _dbContext.SaveChanges();
            return newEmp;
        }

        public EmployeeModel DeleteEmp(int empId)
        {
            var emp = GetEmpId(empId);
            if (emp != null)
            {
                _dbContext.Employees.Remove(emp);
                _dbContext.SaveChanges();
            }
            return emp;
        }

        public List<EmployeeModel> GetAllEmployees()
        {
            return _dbContext.Employees.AsNoTracking().ToList();
        }

        public EmployeeModel GetEmpId(int Id)
        {

            return _dbContext.Employees.AsNoTracking().ToList().FirstOrDefault(t => t.Id == Id);
        }

        public EmployeeModel UpdateEmp(int empId, EmployeeModel newEmp)
        {
            _dbContext.Employees.Update(newEmp);
            _dbContext.SaveChanges();
            return newEmp;
        }
    }
}
