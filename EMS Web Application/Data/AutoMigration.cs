﻿using Microsoft.EntityFrameworkCore;
namespace EMS_Web_Application.Data
{
    public static class AutoMigration
    {
        public static void Automigrate(this WebApplication app)
        {
            using (var scope = app.Services.CreateScope())
            {
                using (var appContext = scope.ServiceProvider.GetRequiredService<EMSDBContext>())
                {
                    try
                    {
                        appContext.Database.Migrate(); // migration are there in the assembly update them on the database.
                    }
                    catch (Exception ex)
                    {
                        //Log errors or do anything you think it's needed
                        throw;
                    }
                }
            }
        }
    }
}
