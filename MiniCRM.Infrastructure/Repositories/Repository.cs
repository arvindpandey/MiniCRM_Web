using Microsoft.EntityFrameworkCore;
using MiniCRM.Core.Interfaces.Repositories;
using MiniCRM.Infrastructure.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniCRM.Infrastructure.Repositories
{
    
    public class Repository<T> : IRepository<T> where T : class
    {
       public readonly MiniCRMContext _context;
       private readonly DbSet<T> _dbSet;
        public Repository(MiniCRMContext context)
        {
            _context = context;
            _dbSet = _context.Set<T>();
        }

        public Task AddAsync(T entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(T entity)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<T>> GetAllAsync()
        {
             var query  = from e in _dbSet
                          select e;  
             return await Task.FromResult(query.ToList());
        }

        public Task<T> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task SaveChangesAsync()
        {
            throw new NotImplementedException();
        }

        public void Update(T entity)
        {
            throw new NotImplementedException();
        }
    }
}
