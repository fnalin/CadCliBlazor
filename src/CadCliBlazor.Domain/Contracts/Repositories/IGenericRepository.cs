using CadCliBlazor.Domain.Entities;

namespace CadCliBlazor.Domain.Contracts.Repositories;

public interface IGenericRepository<TEntity> where TEntity : EntityBase
{
    Task<IEnumerable<TEntity>> GetAllAsync();
    Task<TEntity> GetAsync(int id);
    
    Task AddAsync(TEntity entity);
    Task UpdateAsync(TEntity entity);
    Task DeleteAsync(TEntity entity);
}