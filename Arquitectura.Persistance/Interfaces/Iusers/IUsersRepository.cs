using Arquitectura.Domain.Entities.users;
using Arquitectura.Domain.Repositories;

namespace Arquitectura.Persistance.Interfaces.Iusers
{
    public interface IUsersRepository : IBaseRepository<Users, int>
    {
    }
}
