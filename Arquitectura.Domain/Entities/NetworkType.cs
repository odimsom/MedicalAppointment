

using Arquitectura.Domain.Base;

namespace Arquitectura.Domain.Entities
{
    public sealed class NetworkType : MedicalAppointmentBaseEntity
    {
        public int NetworkTypeId { get; set; }

        public string? Name { get; set; }
    }
}
