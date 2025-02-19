using Arquitectura.Domain.Entities.appointments;
using Arquitectura.Persistance.Base;
using Arquitectura.Persistance.Context;
using Arquitectura.Persistance.Interfaces.Iappointments;


namespace Arquitectura.Persistance.Repositories.appoiments
{
    public class AppointmentsRepository : BaseRepository<Appointments, int>, IAppointmentsRepository
    {
        public AppointmentsRepository(ArquitectureContex contex) : base(contex)
        {
        }
    }
}
