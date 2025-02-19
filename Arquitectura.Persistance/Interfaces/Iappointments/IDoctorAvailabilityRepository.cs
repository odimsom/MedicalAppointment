using Arquitectura.Domain.Entities.appointments;
using Arquitectura.Domain.Repositories;

namespace Arquitectura.Persistance.Interfaces.Iappointments
{
    public interface IDoctorAvailabilityRepository : IBaseRepository<DoctorAvailability, int>
    {
    }
}
