using CarRentManagment.Shared.Domain;

namespace CarRentManagment.Server.IRepository
{
    public interface IUnitOfWork : IDisposable
    {
        Task Save(HttpContext httpContext);
        IGenericRepository<Make> Makes { get; }
        IGenericRepository<Model> Models { get; }
        IGenericRepository<Vehicle> Vehicles { get; }
        IGenericRepository<Color> Colors { get; }
        IGenericRepository<Customer> Customers { get; }
        IGenericRepository<Booking> Bookings { get; }
       
    }
}
