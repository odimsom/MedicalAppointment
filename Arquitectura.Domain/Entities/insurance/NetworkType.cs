

using Arquitectura.Domain.Base;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Arquitectura.Domain.Entities.insurance
{
    public sealed class NetworkType : MedicalAppointmentBaseEntity<int>
    {
        [Column("NetworkTypeId")]
        [Key]
        public override int Id { get; set; }

        public string? Name { get; set; }
    }
}
