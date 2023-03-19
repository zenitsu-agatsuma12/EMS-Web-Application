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


        public Employee AddEmp(Employee newEmp)
        {
            _dbContext.Add(newEmp);
            _dbContext.SaveChanges();
            return newEmp;
        }

        public Employee DeleteEmp(int empId)
        {
            var emp = GetEmpId(empId);
            if (emp != null)
            {
                _dbContext.Employees.Remove(emp);
                _dbContext.SaveChanges();
            }
            return emp;
        }

        public List<Employee> GetAllEmployees()
        {
            return _dbContext.Employees.AsNoTracking().Include(e => e.Department).ToList();
        }

        public Employee GetEmpId(int Id)
        {

            return _dbContext.Employees.AsNoTracking().ToList().FirstOrDefault(t => t.Id == Id);
        }

        public Employee UpdateEmp(int empId, Employee newEmp)
        {
            _dbContext.Employees.Update(newEmp);
            _dbContext.SaveChanges();
            return newEmp;
        }
    }
}
