using Microsoft.EntityFrameworkCore;
using EMS_Web_Application.Models;

namespace EMS_Web_Application.Data
{
    public static class SeedData
    {
        public static void SeedDefaultData(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>().HasData(
                   new Employee(1, "Alvin Root", DateTime.Now.AddDays(1), "alvin@gmail.com", "099232312",  1),
                   new Employee(2, "Tricia Tagle", DateTime.Now.AddDays(2), "trish@gmail.com", "099232322312",  2),
                   new Employee(3, "Joan DC", DateTime.Now.AddDays(3), "Joan@gmail.com", "09319232312", 3)
                   );

            modelBuilder.Entity<Department>().HasData(
                  new Department(1, "IT"),
                  new Department(2, "HR"),
                  new Department(3, "CSR")
                  );
        }   
    }
}
