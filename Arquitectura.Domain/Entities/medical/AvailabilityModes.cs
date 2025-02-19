using Arquitectura.Domain.Base;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Arquitectura.Domain.Entities.medical
{
    public sealed class AvailabilityModes : MedicalAppointmentBaseEntity<char>
    {
        [Column("SAvailabilityModeID")]
        [Key]
        public override char Id { get; set; }

        public string AvailabilityMode { get; set; }
    }
}
