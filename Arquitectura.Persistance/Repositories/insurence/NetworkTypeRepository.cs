

using Arquitectura.Domain.Entities.insurance;
using Arquitectura.Persistance.Base;
using Arquitectura.Persistance.Context;
using Arquitectura.Persistance.Interfaces.Iinsurence;

namespace Arquitectura.Persistance.Repositories.insurence
{
    public class NetworkTypeRepository : BaseRepository<NetworkType, int>, INetworkTypeRepository
    {
        public NetworkTypeRepository(ArquitectureContex contex) : base(contex)
        {
        }
    }
}
