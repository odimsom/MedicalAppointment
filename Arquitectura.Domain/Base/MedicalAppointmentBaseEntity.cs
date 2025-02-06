

namespace Arquitectura.Domain.Base
{
    public abstract class MedicalAppointmentBaseEntity : MedicalAppointmentCUatBaseEntity
    {
        public bool IsActive { get; set; }
    }
}
