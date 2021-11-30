using CarRentManagment.Server.Data;
using CarRentManagment.Server.IRepository;
using CarRentManagment.Shared.Domain;

namespace CarRentManagment.Server.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private ApplicationDbContext _context;

        private IGenericRepository<Make>? _makes;
        private IGenericRepository<Kolor>? _kolors;
        private IGenericRepository<Model>? _models;
        private IGenericRepository<Booking>? _bookings;
        private IGenericRepository<Customer>? _customers;
        private IGenericRepository<Vehicle>? _vehicles;

        public UnitOfWork(ApplicationDbContext context)
        {
            _context = context;
        }

        public IGenericRepository<Make> Makes
            => _makes ??= new GenericRepository<Make>(_context);
        public IGenericRepository<Model> Models
            => _models ??= new GenericRepository<Model>(_context);
        public IGenericRepository<Kolor> Kolors
            => _kolors ??= new GenericRepository<Kolor>(_context);
        public IGenericRepository<Vehicle> Vehicles
            => _vehicles ??= new GenericRepository<Vehicle>(_context);
        public IGenericRepository<Booking> Bookings
            => _bookings ??= new GenericRepository<Booking>(_context);
        public IGenericRepository<Customer> Customers
            => _customers ??= new GenericRepository<Customer>(_context);

       

        public void Dispose()
        {
            _context.Dispose();
            GC.SuppressFinalize(this);
        }

        public async Task Save(HttpContext httpContext)
        {
            var user = httpContext.User.Identity.Name;
            if (user == null)
            { user = "System"; }    
            var entities = _context.ChangeTracker.Entries()
                .Where(s => s.State == Microsoft.EntityFrameworkCore.EntityState.Added 
                || s.State == Microsoft.EntityFrameworkCore.EntityState.Modified
                );

            foreach (var entityEntry in entities)
            {
                ((BaseDomainModel)entityEntry.Entity).DateUpdated = DateTime.Now;
                ((BaseDomainModel)entityEntry.Entity).UpdatedBy = user;
                if (entityEntry.State == Microsoft.EntityFrameworkCore.EntityState.Added)
                {
                    ((BaseDomainModel)entityEntry.Entity).DateCreated = DateTime.Now;
                    ((BaseDomainModel)entityEntry.Entity).CreatedBy = user;
                }
            }

            await _context.SaveChangesAsync();
        }
    }
}
