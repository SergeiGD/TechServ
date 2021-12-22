using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace Forms_TechServ
{
    class TechContext : DbContext
    {
        public TechContext() : base("DBConnection") { }

        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderService> OrdersServices { get; set; }

        public DbSet<Client> Clients { get; set; }
        public DbSet<Product> Products { get; set; }

        public DbSet<Service> Services { get; set; }

        public DbSet<SparePart> SpareParts { get; set; }




        public DbSet<SparePartFromBatch> OrdersSpareParts { get; set; }



        public DbSet<Batch> Batches { get; set; }
        public DbSet<BatchSparePart> BatchesSpareParts { get; set; }

        public DbSet<Category> Categories { get; set; }
        public DbSet<MastersCategories> MastersCategories { get; set; }

        public DbSet<Employee> Employees { get; set; }
        public DbSet<Master> Masters { get; set; }
        public DbSet<Manager> Managers { get; set; }
        public DbSet<EmployeeTimetable> EmployeesTimetables { get; set; }

        public DbSet<Workshop> Workshops { get; set; }
        public DbSet<WorkshopTimetable> WorkshopsTimetables { get; set; }

        // УПРАВЛЕНИЕ ПРАВАМИ
        public DbSet<Role> Roles { get; set; }
        public DbSet<Permission> Permissions { get; set; }
        public DbSet<RolesPermissions> RolesPermissions { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<MastersCategories>()
                .HasKey(c => new { c.MasterId, c.CategoryId });

            modelBuilder.Entity<RolesPermissions>()
                .HasKey(c => new { c.PermissionId, c.RoleId });

            modelBuilder.Entity<BatchSparePart>()
                .HasKey(c => new { c.BatchId, c.SparePartId });

            modelBuilder.Entity<OrderService>()
                .HasKey(c => new { c.OrderId, c.ServiceId });

            modelBuilder.Entity<SparePartFromBatch>()
                .HasKey(c => new { c.OrderId, c.SparePartId, c.BatchId });

            //modelBuilder.Entity<Order>().Property(e => e.Status).conf

            modelBuilder.Configurations.Add(new Service.ServiceConfig());

            modelBuilder.Configurations.Add(new WorkshopTimetable.TimetableConfig());

            //modelBuilder.Configurations.Add(new Batch.BatchConfig());
        }
    }
}
