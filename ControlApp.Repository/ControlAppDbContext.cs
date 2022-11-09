using ControlApp.Core.Entities.Abstract;
using Microsoft.EntityFrameworkCore;
using System.Reflection;
using System.Data;
using Microsoft.Extensions.Options;


namespace ControlApp.Repository
{
    public class ControlAppDbContext : DbContext
    {

        public DbSet<Authority> Authorities { get; set; }
        public DbSet<Cabinet> Cabinets { get; set; }
        public DbSet<Contract> Contracts { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Core.Entities.Abstract.Directory> Directories { get; set; }
        public DbSet<Drawer> Drawers { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<EntranceCard> EntranceCards { get; set; }
        public DbSet<Fuel> Fuels { get; set; }
        public DbSet<GeneratorUsedTime> GeneratorUsedTimes { get; set; }
        public DbSet<GuestCard> GuestCards { get; set; }
        public DbSet<Headset> Headsets { get; set; }
        public DbSet<Inventory> Inventories { get; set; }
        public DbSet<Maintenance> Maintenances { get; set; }
        public DbSet<PasswordNote> PasswordNotes { get; set; }
        public DbSet<Request> Requests { get; set; }
        public DbSet<SentryDone> SentryDones { get; set; }
        public DbSet<SentryToDo> SentryToDos { get; set; }
        public DbSet<User> Users { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //bu asemblyde tüm configure dosyalarını bulur  IEntityTypeConfiguration interfacesini arar
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

            base.OnModelCreating(modelBuilder);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
          
                options.UseSqlServer("Server=Yusuf;Database=CapCap;Trusted_Connection=True;");
            
        }




        public override async Task<int> SaveChangesAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            foreach (var entity in ChangeTracker.Entries().Where(e => e.State == EntityState.Modified))
            {
                var baseEntity = entity.Entity as BaseEntity;
                baseEntity.Version++;
                baseEntity.UpdatedDate = DateTime.Now;
            }

            return await base.SaveChangesAsync(cancellationToken);
        }

        internal Task<object> FindAsync(string name)
        {
            throw new NotImplementedException();
        }
    }
}
