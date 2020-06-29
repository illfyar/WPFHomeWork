using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFHomeWork.Data
{
    class MyDBContext : DbContext
    {
        public DbSet<Person> Person { get; set; }
        public DbSet<Position> Position { get; set; }
        public DbSet<Department> Department { get; set; }
        public DbSet<Salary> Salary { get; set; }
        public DbSet<Employee> Employee { get; set; }
        public MyDBContext() : base("DBConnectionString")
        {
            Database.SetInitializer(new DropCreateDatabaseIfModelChanges<MyDBContext>());
        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Types<Person>()
                .Configure(c => c.ToTable("Person"));
            modelBuilder.Types<Department>()
                .Configure(c => c.ToTable("Department"));
            modelBuilder.Types<Position>()
                .Configure(c => c.ToTable("Position"));
            modelBuilder.Types<Employee>()
                .Configure(c => c.ToTable("Employee"));
            modelBuilder.Entity<Employee>().Property(a => a.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            //modelBuilder.Entity<Person>().Property(a => a.Id)
            //    .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            //base.OnModelCreating(modelBuilder);
        }
    }
}
