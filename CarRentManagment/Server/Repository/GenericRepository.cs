using CarRentManagment.Server.Data;
using CarRentManagment.Server.IRepository;

using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;

using System.Linq.Expressions;

namespace CarRentManagment.Server.Repository
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        private readonly ApplicationDbContext _context; //do bazy
        private readonly DbSet<T> _db;   //do konktetnej tabeli

        public GenericRepository(ApplicationDbContext context)
        {
            this._context = context;
            this._db = context.Set<T>();
        }

        public async Task Delete(int id)
        {
            var record = await _db.FindAsync(id);
            if (record != null)
            {
                _db.Remove(record);
            }
        }

        public void DeleteRange(IEnumerable<T> entities)
        {
            _db.RemoveRange(entities);
        }

        public async Task<T> Get(Expression<Func<T, bool>> expression, Func<IQueryable<T>, IIncludableQueryable<T, object>>? includes = null)
        {
            IQueryable<T> query = _db;

            if (includes != null)
            {
                query = includes(query);
            }

            return await query.AsNoTracking().FirstOrDefaultAsync(expression);
        }

        public async Task<IList<T>> GetAll(
                            Expression<Func<T, bool>>? expression = null,
                            Func<IQueryable<T>, IOrderedQueryable<T>>? orderBy = null,
                            Func<IQueryable<T>, IIncludableQueryable<T, object>>? includes = null
                            )
        {
            IQueryable<T> query = _db;

            if (expression != null)
            {
                query = query.Where(expression);
            }

            if (includes != null)
            {
                query = includes(query);
            }

            if (orderBy != null)
            {
                query = orderBy(query);
            }

            return await query.AsNoTracking().ToListAsync();
        }

        public Task GetAll(List<string> includes)
        {
            throw new NotImplementedException();
        }

        public async Task Insert(T entity)
        {
            await _db.AddAsync(entity); 
        }

        public async Task InsertRange(IEnumerable<T> entities)
        {
           await _db.AddRangeAsync(entities);
        }

        public void Update(T entity)
        {
            _db.Attach(entity);
            _context.Entry(entity).State = EntityState.Modified;
        }
    }
}
