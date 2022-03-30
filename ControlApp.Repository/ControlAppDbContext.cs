using ControlApp.Core.Entities.Abstract;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ControlApp.Repository
{
    public class ControlAppDbContext : DbContext
    {
        //DbContextOptions almasının sebebi veritabanı yolunun startup dosyasında verilecek olması
        //DbContextOptions<ControlAppDbContext>  bu şekilde kullanılması da ControlAppDbContext için bir options verdim demek
        public ControlAppDbContext(DbContextOptions<ControlAppDbContext> dbContextOptions) : base(dbContextOptions)
        {
        }
        public DbSet<Authority> Authorities { get; set; }
        public DbSet<Cabinet> Cabinets { get; set; }
        public DbSet<Contract> Contracts { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Core.Entities.Abstract.Directory> Directorys { get; set; }
        public DbSet<Drawer> Drawers { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<EntranceCard> EntranceCards { get; set; }
        public DbSet<Fuel> Fuels { get; set; }
        public DbSet<GeneratorUsedTime> GeneratorUsedTime { get; set; }
        public DbSet<GuestCard> GuestCards { get; set; }
        public DbSet<Headset> Headsets { get; set; }
        public DbSet<Inventory> Inventories { get; set; }
        public DbSet<Maintenance> Maintenances { get; set; }
        public DbSet<PasswordNote> PasswordNotes { get; set; }  
        public DbSet<Request> Requests { get; set; }    
        public DbSet<SentryDone> SentryDone { get; set; }   
        public DbSet<SentryToDo> SentryToDos { get; set; }



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //bu asemblyde tüm configure dosyalarını bulur  IEntityTypeConfiguration interfacesini arar
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

            base.OnModelCreating(modelBuilder);
        }
    }
}
