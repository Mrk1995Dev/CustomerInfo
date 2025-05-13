using Domain.Location;
using Domain.Users;
using Microsoft.EntityFrameworkCore;

namespace ApplicationService
{
    public interface IDataBaseContext
    {
        DbSet<Customer> Customers { get; set; }
        DbSet<City> Cities { get; set; }
        Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);
    }
}
