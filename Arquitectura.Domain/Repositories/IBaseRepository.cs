
using Arquitectura.Domain.Result;

using System.Linq.Expressions;

namespace Arquitectura.Domain.Repositories
{
    /// <summary>
    /// Entidad base de reposytory que deven heredar todos los repositorios.
    /// </summary>
    /// <typeparam name="TEntity">Entidad</typeparam>
    /// <typeparam name="TType">El tipo de dato primary key para realizar consultas.</typeparam>
    public interface IBaseRepository<TEntity, TType> where TEntity : class 
    {
        Task<TEntity> GetEntityById(TType id);

        Task<OperationResult> UpdateEntityAsync(TEntity entity);

        Task<OperationResult> RemuveEntityAsync(TEntity entity);

        Task<OperationResult> SaveEntityAsync(TEntity entity);
        
        Task<List<TEntity>> GetAll(TEntity entity);

        Task<OperationResult> GetAll(Expression<Func<TEntity, bool>> filter);

        Task<OperationResult> GetEntityById(int id);

        Task<bool> Exists(Expression<Func<TEntity, bool>> filter);
    }
}
