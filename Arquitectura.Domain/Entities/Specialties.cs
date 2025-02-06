
using Arquitectura.Domain.Base;

namespace Arquitectura.Domain.Entities
{
    public sealed class Specialties : MedicalAppointmentBaseEntity
    {
        public int SpecialtyID { get; set; }

        public int SpecialtyName { get; set; }
    }
}
