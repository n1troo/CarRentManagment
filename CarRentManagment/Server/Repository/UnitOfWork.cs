using CarRentManagment.Server.Data;
using CarRentManagment.Server.IRepository;
using CarRentManagment.Shared.Domain;

using System.Drawing;

using Color = CarRentManagment.Shared.Domain.Color;

namespace CarRentManagment.Server.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _context;
        private IGenericRepository<Make> _makes;
        private IGenericRepository<Color> _color;
        private IGenericRepository<Model> _model;

        public UnitOfWork(ApplicationDbContext context)
        {
            _context = context;
        }

        public IGenericRepository<Make> Makes => _makes ??= new GenericRepository<Make>(_context);
        public IGenericRepository<Color> Colors => _color ??= new GenericRepository<Color>(_context);
        public IGenericRepository<Model> Models => _model ??= new GenericRepository<Model>(_context);

        public IGenericRepository<Vehicle> Vehicles => throw new NotImplementedException();
        public IGenericRepository<Customer> Customers => throw new NotImplementedException();
        public IGenericRepository<Booking> Bookings => throw new NotImplementedException();

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
