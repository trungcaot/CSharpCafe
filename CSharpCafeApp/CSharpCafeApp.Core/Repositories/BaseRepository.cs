using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCafeApp.Core.Repositories
{
    public class BaseRepository<TEnitity> : IBaseRepository<TEnitity> where TEnitity : class
    {
        protected readonly DbSet<TEnitity> _entities;

        public BaseRepository(DbContext context)
        {
            _entities = context.Set<TEnitity>();
        }

        public async Task AddAsync(TEnitity entity)
        {
            await _entities.AddAsync(entity);
        }

        public async Task AddRangeAsync(IEnumerable<TEnitity> entities)
        {
            await _entities.AddRangeAsync(entities);
        }

        public async Task<IEnumerable<TEnitity>> FindAsync(Expression<Func<TEnitity, bool>> predicate)
        {
            return await _entities.Where(predicate).ToListAsync();
        }

        public async Task<IEnumerable<TEnitity>> GetAllAsync()
        {
            return await _entities.ToListAsync();
        }

        public void Remove(TEnitity entity)
        {
            _entities.Remove(entity);
        }

        /// <summary>
        /// Still working with remove range as simple not async.
        /// </summary>
        /// <param name="entities"></param>
        public void RemoveRange(IEnumerable<TEnitity> entities)
        {
            _entities.RemoveRange(entities);
        }

        public async Task<TEnitity> SingleAsync(Expression<Func<TEnitity, bool>> predicate)
        {
            return await _entities.SingleOrDefaultAsync(predicate);
        }
    }
}
