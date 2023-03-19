using EMS_Web_Application.Models;
using Microsoft.EntityFrameworkCore;
namespace EMS_Web_Application.Data.ModeTableMapping
{
    public static class EmployeeModelMapping
    {
        public static void EmployeeModel(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>()
               .ToTable("Employee")
               .Property("Name")
               .HasColumnName("Full_Name")
               .HasColumnType("ntext");
        }
    }
}
