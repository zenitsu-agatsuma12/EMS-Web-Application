using Microsoft.EntityFrameworkCore;
using EMS_Web_Application.Models;

namespace EMS_Web_Application.Data
{
    public static class SeedData
    {
        public static void SeedDefaultData(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>().HasData(
                   new Employee(1, "Alvin Root", DateTime.Today.AddDays(1), "alvin@gmail.com", "099232312",  1)
                   );

            modelBuilder.Entity<Department>().HasData(
                  new Department(1, "Admin")
                  );
        }   
    }
}
