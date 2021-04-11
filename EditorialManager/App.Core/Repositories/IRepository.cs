using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace App.Core.Repositories
{
   public interface IRepository<TEntity> where TEntity:class
    {
        Task<TEntity> GetByIdAsync(int id);
        Task<TEntity> GetByIdAsync(string id);
        Task<IEnumerable<TEntity>> GetAllAsync();
        Task AddAsync(TEntity entity);
        
    }
}
