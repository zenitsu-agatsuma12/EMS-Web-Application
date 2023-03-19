using Microsoft.EntityFrameworkCore;
using EMS_Web_Application.Data;
using EMS_Web_Application.Repository;
using EMS_Web_Application.Repository.InMemory;
using EMS_Web_Application.Repository.MsSQL;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews(); 
builder.Services.AddDbContext<EMSDBContext>();
builder.Services.AddScoped<IEmpRepository, EmpDBRepository>();
builder.Services.AddScoped<IDeptRepository, DeptDBRepository>();
//builder.Services.AddSingleton<IEmpRepository, EmpInMemoryRepository>();
//builder.Services.AddSingleton<IDeptRepository, DeptInMemoryRepository>();


// Add services to the container.
builder.Services.AddControllersWithViews();
var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();


app.MapControllerRoute(
    name: "default",
   pattern: "{controller=Home}/{action=Index}/{id?}"
   );

app.Run();
