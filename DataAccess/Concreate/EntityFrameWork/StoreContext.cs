using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using Entities.Concreate ;

namespace DataAccess.Concreate.EntityFrameWork
{
    public partial class StoreContext : DbContext
    {
        public StoreContext()
            : base("name=StoreContext1")
        {
        }

        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<EmployeeSalary> EmployeeSalaries { get; set; }
        public virtual DbSet<oneOrder> oneOrders { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<Rrule> Rrules { get; set; }
        public virtual DbSet<Store> Stores { get; set; }
        public virtual DbSet<UserRrule> UserRrules { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<IntOutStore> IntOutStores { get; set; }
        public virtual DbSet<StoreExpenses> StoreExpenses { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>()
                .Property(e => e.Salary)
                .HasPrecision(18, 0);

            modelBuilder.Entity<EmployeeSalary>()
                .Property(e => e.Payment)
                .HasPrecision(18, 0);

            modelBuilder.Entity<EmployeeSalary>()
                .Property(e => e.discount)
                .HasPrecision(18, 0);

            modelBuilder.Entity<EmployeeSalary>()
                .Property(e => e.Salary)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Product>()
                .Property(e => e.Price)
                .HasPrecision(18, 0);

            
        }
    }
}
