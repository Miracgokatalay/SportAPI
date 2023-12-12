using Microsoft.EntityFrameworkCore;
using SportAPI.Application.Repositories;
using SportAPI.Domain.Entities.Common;
using SportAPI.Persistance.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace SportAPI.Persistance.Repositories
{
    public class ReadRepository<T> : IReadRepository<T> where T : BaseEntity
    {
        private readonly SportAPIDbContext _context;

        public ReadRepository(SportAPIDbContext context)
        {
            _context = context;
        }


        public DbSet<T> Table => _context.Set<T>();

        public IQueryable<T> GetAll(bool tracking = true)
        {
            var query= Table.AsQueryable();
            if (!tracking) query= query.AsNoTracking();
            return query;
        }

        public async Task<T> GetByIdAsync(int id, bool tracking = true) //=> await Table.FindAsync(id);//await Table.FirstOrDefaultAsync(data => data.Id == id);
        {
            var query = Table.AsQueryable();
            if (!tracking) query = query.AsNoTracking();
            return await query.FirstOrDefaultAsync(data => data.Id == id);
        }
        public async Task<T> GetSingleAsync(Expression<Func<T, bool>> method, bool tracking = true)
        {
            var query= Table.AsQueryable();
            if(!tracking) query= query.AsNoTracking();
            return await query.FirstOrDefaultAsync(method);
        }

        public IQueryable<T> GetWhere(Expression<Func<T, bool>> method, bool tracking = true)
        {
            var query= Table.Where(method);
            if (!tracking) query = query.AsNoTracking();
            return query;
        }
    }
}
