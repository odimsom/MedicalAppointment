

using Arquitectura.Domain.Entities.medical;
using Arquitectura.Persistance.Base;
using Arquitectura.Persistance.Context;
using Arquitectura.Persistance.Interfaces.Imedical;

namespace Arquitectura.Persistance.Repositories.medical
{
    public class MedicalRecordsRepository : BaseRepository<MedicalRecords, int>, IMedicalRecordsRepository
    {
        public MedicalRecordsRepository(ArquitectureContex contex) : base(contex)
        {
        }
    }
}
