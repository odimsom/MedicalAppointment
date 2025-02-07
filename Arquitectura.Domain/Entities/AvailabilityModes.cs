
using Arquitectura.Domain.Base;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Arquitectura.Domain.Entities
{
    public sealed class AvailabilityModes : MedicalAppointmentBaseEntity
    {
        [Column("SAvailabilityModeID")]
        [Key]
        public override int Id { get; set; }

        public string AvailabilityMode { get; set; }
    }
}
