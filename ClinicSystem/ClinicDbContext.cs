using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicSystem
{
    internal class ClinicDbContext : DbContext
    {

        public DbSet<Patient> Patients { get; set; }
        public DbSet<Specialization> Specializations { get; set; }
        public DbSet<Appointment> Appointments { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // Configure your database connection string here
            optionsBuilder.UseSqlServer("Data Source=AHMED-HOOTI-LAP\\SQLEXPRESS;Initial Catalog=ClinicSystem;Integrated Security=True");
        }
    }
}
        

    

