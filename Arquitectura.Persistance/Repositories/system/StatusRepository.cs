
using Arquitectura.Domain.Entities.System;
using Arquitectura.Persistance.Base;
using Arquitectura.Persistance.Context;
using Arquitectura.Persistance.Interfaces.Isystem;

namespace Arquitectura.Persistance.Repositories.system
{
    public class StatusRepository : BaseRepository<Status, int>, IStatusRepository
    {
        public StatusRepository(ArquitectureContex contex) : base(contex)
        {
        }
    }
}
