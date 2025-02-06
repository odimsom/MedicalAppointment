
using Arquitectura.Domain.Result;
using System.Formats.Tar;
using System.Linq.Expressions;
using System.Numerics;
using System.Threading.Tasks;

namespace Arquitectura.Domain.Repositories
{
    public interface IBaseRepository<TEntity> where TEntity : class 
    {
        Task<OperationResult> Save(TEntity entity);

        Task<OperationResult> Update(TEntity entity);

        Task<OperationResult> Remuve(TEntity entity);

        Task<OperationResult> GetAll();

        Task<OperationResult> GetEntityBy(int id);

        Task<OperationResult> Exists(Expression<Func<TEntity, bool>> filter);
    }
}
