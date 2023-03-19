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


        public DepartmentModel AddDept(DepartmentModel newDept)
        {
            _dbContext.Add(newDept);
            _dbContext.SaveChanges();
            return newDept;
        }

        public DepartmentModel DeleteDept(int deptId)
        {
            var dept = GetDeptId(deptId);
            if (dept != null)
            {
                _dbContext.Departments.Remove(dept);
                _dbContext.SaveChanges();
            }
            return dept;
        }

        public List<DepartmentModel> GetAllDepartments()
        {
            return _dbContext.Departments.AsNoTracking().ToList();
        }

        public DepartmentModel GetDeptId(int Id)
        {

            return _dbContext.Departments.AsNoTracking().ToList().FirstOrDefault(t => t.Id == Id);
        }

        public DepartmentModel UpdateDept(int deptId, DepartmentModel newDept)
        {
            _dbContext.Departments.Update(newDept);
            _dbContext.SaveChanges();
            return newDept;
        }
    }
}
