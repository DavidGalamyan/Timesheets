using Microsoft.EntityFrameworkCore;
using Timesheets.Models;

namespace Timesheets.Data.EntityFramework
{
    public class TimesheetDbContext:DbContext
    {
        public DbSet<Client> Clients { get; set; }
        public DbSet<Contract> Contracts { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<Sheet> Sheets { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Employee> Employees { get; set; }

        public TimesheetDbContext(DbContextOptions<TimesheetDbContext> options) :base (options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Client>().ToTable("Clients");
            modelBuilder.Entity<Contract>().ToTable("Contracts");
            modelBuilder.Entity<Service>().ToTable("Services");
            modelBuilder.Entity<User>().ToTable("Users");
            modelBuilder.Entity<Employee>().ToTable("Employees");

            modelBuilder.Entity<Sheet>().HasOne(sheet => sheet.Contract)
                .WithMany(contract => contract.Sheets)
                .HasForeignKey("ContractId");

            modelBuilder.Entity<Sheet>().HasOne(sheet => sheet.Employee)
                .WithMany(employee => employee.Sheets)
                .HasForeignKey("EmployeeId");

            modelBuilder.Entity<Sheet>().HasOne(sheet => sheet.Service)
                .WithMany(service => service.Sheets)
                .HasForeignKey("ServiceId");
        }
    }
}
