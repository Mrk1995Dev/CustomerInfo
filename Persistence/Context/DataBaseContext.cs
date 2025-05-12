using ApplicationService;
using Domain.Attributes;
using Domain.Location;
using Domain.Users;
using Microsoft.EntityFrameworkCore;
using Persistence.Configurations.Location;
using Persistence.Configurations.User;
using Persistence.DataSeed;
using System.Linq.Expressions;
using System.Reflection.Emit;

namespace Persistence.Context
{
    public class DataBaseContext : DbContext, IDataBaseContext
    {
        public DataBaseContext(DbContextOptions options) : base(options)
        {
        }

        #region DbSet
        public DbSet<Customer> Customers { get; set; }
        public DbSet<City> Cities { get; set; }
        #endregion

        protected override void OnModelCreating(ModelBuilder builder)
        {
            #region Seed Data
            builder.Entity<City>().HasData(CitySeedData.GetCities());
            #endregion

            foreach (var entityType in builder.Model.GetEntityTypes())
            {
                if (entityType.ClrType.GetCustomAttributes(typeof(AuditableAttribute), true).Length > 0)
                {
                    builder.Entity(entityType.Name).Property<DateTime>("InsertTime").HasDefaultValue(DateTime.Now);
                    builder.Entity(entityType.Name).Property<DateTime?>("UpdateTime");
                    builder.Entity(entityType.Name).Property<DateTime?>("RemoveTime");
                    builder.Entity(entityType.Name).Property<bool>("IsRemoved").HasDefaultValue(false);
                    builder.Entity(entityType.Name).Property<int?>("CreatedBy");
                    builder.Entity(entityType.Name).Property<int?>("UpdatedBy");
                    builder.Entity(entityType.Name).Property<int?>("RemovedBy");
                }
            }

            #region Global Query Filters
            builder.Entity<Customer>().HasQueryFilter(cu => EF.Property<bool>(cu, "IsRemoved") == false);
            #endregion

            #region Entities Configuration
            builder.ApplyConfiguration(new CustomerConfiguration());
            builder.ApplyConfiguration(new CityConfiguration());
            #endregion

            base.OnModelCreating(builder);
        }

        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            var modifiedEntries = ChangeTracker.Entries()
                .Where(p => p.State == EntityState.Modified ||
                p.State == EntityState.Added ||
                p.State == EntityState.Deleted
                ).ToList();
            foreach (var item in modifiedEntries)
            {
                var entityType = item.Context.Model.FindEntityType(item.Entity.GetType());

                var inserted = entityType.FindProperty("InsertTime");
                var updated = entityType.FindProperty("UpdateTime");
                var RemoveTime = entityType.FindProperty("RemoveTime");
                var IsRemoved = entityType.FindProperty("IsRemoved");
                var createdBy = entityType.FindProperty("CreatedBy");
                var updatedBy = entityType.FindProperty("UpdatedBy");
                var removedBy = entityType.FindProperty("RemovedBy");
                if (item.State == EntityState.Added && inserted != null)
                {
                    item.Property("InsertTime").CurrentValue = DateTime.Now;
                }
                if (item.State == EntityState.Modified && updated != null)
                {
                    item.Property("UpdateTime").CurrentValue = DateTime.Now;
                }

                if (item.State == EntityState.Deleted && RemoveTime != null && IsRemoved != null)
                {
                    item.Property("RemoveTime").CurrentValue = DateTime.Now;
                    item.Property("IsRemoved").CurrentValue = true;
                    item.State = EntityState.Modified;
                }
            }
            return base.SaveChangesAsync(cancellationToken);
        }
    }
}
