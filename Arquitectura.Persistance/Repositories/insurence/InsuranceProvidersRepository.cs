

using Arquitectura.Domain.Entities.insurance;
using Arquitectura.Persistance.Base;
using Arquitectura.Persistance.Context;
using Arquitectura.Persistance.Interfaces.Iinsurence;

namespace Arquitectura.Persistance.Repositories.insurence
{
    public class InsuranceProvidersRepository : BaseRepository<InsuranceProviders, int>, IInsuranceProvidersRepository
    {
        public InsuranceProvidersRepository(ArquitectureContex contex) : base(contex)
        {
        }
    }
}
