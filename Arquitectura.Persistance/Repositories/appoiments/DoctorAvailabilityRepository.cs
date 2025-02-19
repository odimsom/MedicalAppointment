using Arquitectura.Domain.Entities.appointments;
using Arquitectura.Persistance.Base;
using Arquitectura.Persistance.Context;
using Arquitectura.Persistance.Interfaces.Iappointments;

namespace Arquitectura.Persistance.Repositories.appoiments
{
    public class DoctorAvailabilityRepository : BaseRepository<DoctorAvailability, int>, IDoctorAvailabilityRepository
    {
        public DoctorAvailabilityRepository(ArquitectureContex contex) : base(contex)
        {
        }
    }
}
