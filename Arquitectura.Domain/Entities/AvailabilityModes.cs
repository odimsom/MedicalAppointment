
using Arquitectura.Domain.Base;

namespace Arquitectura.Domain.Entities
{
    public sealed class AvailabilityModes : MedicalAppointmentBaseEntity
    {
        public int SAvailabilityModeID { get; set; }

        public string AvailabilityMode { get; set; }
    }
}
