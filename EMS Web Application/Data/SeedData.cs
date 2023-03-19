using Microsoft.EntityFrameworkCore;
using EMS_Web_Application.Models;

namespace EMS_Web_Application.Data
{
    public static class SeedData
    {
        public static void SeedDefaultData(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<EmployeeModel>().HasData(
                   new EmployeeModel(1, "Alvin Root", DateTime.Now.AddDays(1), "alvin@gmail.com", "099232312", "IT", 1),
                   new EmployeeModel(2, "Tricia Tagle", DateTime.Now.AddDays(2), "trish@gmail.com", "099232322312", "HR", 2),
                   new EmployeeModel(3, "Joan DC", DateTime.Now.AddDays(3), "Joan@gmail.com", "09319232312", "CSR", 3)
                   );

            modelBuilder.Entity<DepartmentModel>().HasData(
                  new DepartmentModel(1, "IT"),
                  new DepartmentModel(2, "HR"),
                  new DepartmentModel(3, "CSR")
                  );
        }   
    }
}
