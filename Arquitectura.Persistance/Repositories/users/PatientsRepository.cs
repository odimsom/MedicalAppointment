
using Arquitectura.Domain.Entities.users;
using Arquitectura.Persistance.Base;
using Arquitectura.Persistance.Context;
using Arquitectura.Persistance.Interfaces.Iusers;

namespace Arquitectura.Persistance.Repositories.users
{
    public class PatientsRepository : BaseRepository<Patients, int>, IPatientsReposytory
    {
        public PatientsRepository(ArquitectureContex contex) : base(contex)
        {
        }
    }
}
