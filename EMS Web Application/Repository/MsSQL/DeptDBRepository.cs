using Microsoft.EntityFrameworkCore;
using EMS_Web_Application.Data;
using EMS_Web_Application.Models;

namespace EMS_Web_Application.Repository.MsSQL
{
    public class DeptDBRepository : IDeptRepository
    {
        EMSDBContext _dbContext;

        public DeptDBRepository(EMSDBContext dbContext)
        {
            _dbContext = dbContext;
        }


        public Department AddDept(Department newDept)
        {
            _dbContext.Add(newDept);
            _dbContext.SaveChanges();
            return newDept;
        }

        public Department DeleteDept(int deptId)
        {
            var dept = GetDeptId(deptId);
            if (dept != null)
            {
                _dbContext.Departments.Remove(dept);
                _dbContext.SaveChanges();
            }
            return dept;
        }

        public List<Department> GetAllDepartments()
        {
            return _dbContext.Departments.AsNoTracking().ToList();
        }

        public Department GetDeptId(int Id)
        {

            return _dbContext.Departments.AsNoTracking().ToList().FirstOrDefault(t => t.Id == Id);
        }

        public Department UpdateDept(int deptId, Department newDept)
        {
            _dbContext.Departments.Update(newDept);
            _dbContext.SaveChanges();
            return newDept;
        }
    }
}
