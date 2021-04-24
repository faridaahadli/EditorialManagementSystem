using App.Core.IUnitOfWorks;
using App.Core.Repositories;
using App.Core.Services;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace App.Services.Services
{
    public class Service<TEntity> : IService<TEntity> where TEntity : class
    {
        public readonly IUnitOfWork unitOfWork;
        private readonly IRepository<TEntity> _repository;
        public Service(IUnitOfWork unitOfWork,IRepository<TEntity> repository)
        {
            this.unitOfWork = unitOfWork;
            _repository = repository;
        }
        public async Task<TEntity> AddAsync(TEntity entity)
        {
            await _repository.AddAsync(entity);
            await unitOfWork.CommitAsync();
            return entity;
        }

        public Task<IEnumerable<TEntity>> GetAllAsync()
        {
            return _repository.GetAllAsync();
        }

        public async Task<TEntity> GetByIdAsync(int id)
        {
            return await _repository.GetByIdAsync(id);
        }

        public async Task<TEntity> GetByIdAsync(string id)
        {
            return await _repository.GetByIdAsync(id);
        }

        public void Remove(TEntity entity)
        {
            _repository.Remove(entity);
        }

        public async Task<TEntity> Update(TEntity entity)
        {
          await _repository.Update(entity);
            await unitOfWork.CommitAsync();
            return entity;
        }
    }
}
