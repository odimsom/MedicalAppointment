
using Arquitectura.Domain.Entities.System;
using Arquitectura.Persistance.Base;
using Arquitectura.Persistance.Context;
using Arquitectura.Persistance.Interfaces.Isystem;

namespace Arquitectura.Persistance.Repositories.system
{
    public class RolesRepository : BaseRepository<Roles, int>, IRolesRepository
    {
        public RolesRepository(ArquitectureContex contex) : base(contex)
        {
        }
    }
}
