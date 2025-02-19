

using Arquitectura.Domain.Entities.users;
using Arquitectura.Persistance.Base;
using Arquitectura.Persistance.Context;
using Arquitectura.Persistance.Interfaces.Iusers;

namespace Arquitectura.Persistance.Repositories.users
{
    public class DoctorsRepository : BaseRepository<Doctors, int>, IDoctorsRepository
    {
        public DoctorsRepository(ArquitectureContex contex) : base(contex)
        {
        }
    }
}
