

using Arquitectura.Domain.Repositories;
using Arquitectura.Domain.Result;
using Arquitectura.Persistance.Context;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace Arquitectura.Persistance.Base
{
    public abstract class BaseRepository<TEntity, TType> : IBaseRepository<TEntity, TType> where TEntity : class
    {
        private readonly ArquitectureContex _context;

        private DbSet<TEntity> _entity { get; set; }

        protected BaseRepository(ArquitectureContex contex)
        {
            _context = contex;
            _entity = _context.Set<TEntity>();
        }

        public virtual async Task<bool> Exists(Expression<Func<TEntity, bool>> filter)
        {
            if (filter == null) 
                throw new ArgumentNullException(nameof(filter)); // los registros no pueden ser null
            return await _entity.AnyAsync(filter);
        }

        public virtual async Task<List<TEntity>> GetAll(TEntity entity)
        {
            var result = await _entity.ToListAsync();
            return result ?? new List<TEntity>();
        }

        public virtual async Task<OperationResult> GetAll(Expression<Func<TEntity, bool>> filter)
        {
            if (filter == null)
                throw new ArgumentNullException(nameof(filter));

            var _operationResult = new OperationResult();
            try
            {
                var data = await _entity.Where(filter).ToListAsync();
                _operationResult.Data = data;
                _operationResult.Success = data.Any();
                _operationResult.Message = data.Any() ? "Datos obtenidos correctamente." : "No se encontraron datos.";
            }
            catch (Exception ex) 
            { 
                _operationResult.Success = false;
                _operationResult.Message = $"Error al obtener los datos: {ex.Message}";
            }

            return _operationResult;
        }

        public virtual async Task<OperationResult> SaveEntityAsync(TEntity entity)
        {
            if (entity == null)
                throw new ArgumentNullException(nameof(entity));
            var _operationResult = new OperationResult();
            try
            {
                _entity.Add(entity);
                await _context.SaveChangesAsync();
                _operationResult.Success = true;
            }
            catch (Exception ex) 
            {
                _operationResult.Success = false;
                _operationResult.Message = $"Error al guardar los datos: {ex.Message}";
            }
            return _operationResult;
        }
        

        public virtual async Task<TEntity> GetEntityById(TType id)
        {
            if (_entity == null)
                throw new ArgumentNullException(nameof(_entity));
            return await _entity.FindAsync(id);
        }

        public async Task<OperationResult> UpdateEntityAsync(TEntity entity)
        {
            if(entity == null) 
                throw new ArgumentNullException(nameof(entity));

            var _operationResult = new OperationResult();
            try
            {
                _entity.Update(entity);
                await _context.SaveChangesAsync();
                _operationResult.Success = true;
            }
            catch(Exception ex) 
            { 
                _operationResult.Success = false;
                _operationResult.Message = $"Error al actualizar los datos: {ex.Message}";
            }

            return _operationResult;
        }
    }
}
