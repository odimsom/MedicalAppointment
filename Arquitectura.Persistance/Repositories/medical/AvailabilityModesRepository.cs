using Arquitectura.Domain.Entities.medical;
using Arquitectura.Persistance.Base;
using Arquitectura.Persistance.Context;
using Arquitectura.Persistance.Interfaces.Imedical;

namespace Arquitectura.Persistance.Repositories.medical
{
    public class AvailabilityModesRepository : BaseRepository<AvailabilityModes, char>, IAvailabilityModesRepository
    {
        public AvailabilityModesRepository(ArquitectureContex contex) : base(contex)
        {
        }
    }
}
