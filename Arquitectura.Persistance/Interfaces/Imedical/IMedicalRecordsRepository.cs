using Arquitectura.Domain.Entities.medical;
using Arquitectura.Domain.Repositories;

namespace Arquitectura.Persistance.Interfaces.Imedical
{
    public interface IMedicalRecordsRepository : IBaseRepository<MedicalRecords, int>
    {
    }
}
