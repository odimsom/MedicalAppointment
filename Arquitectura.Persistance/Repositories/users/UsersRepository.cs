

using Arquitectura.Domain.Entities.users;
using Arquitectura.Persistance.Base;
using Arquitectura.Persistance.Context;
using Arquitectura.Persistance.Interfaces.Iusers;

namespace Arquitectura.Persistance.Repositories.users
{
    public class UsersRepository : BaseRepository<Users, int>, IUsersRepository
    {
        public UsersRepository(ArquitectureContex contex) : base(contex)
        {
        }
    }
}
