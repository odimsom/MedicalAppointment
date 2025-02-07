

using Arquitectura.Domain.Base;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Arquitectura.Domain.Entities
{
    public sealed class NetworkType : MedicalAppointmentBaseEntity
    {
        [Column("NetworkTypeId")]
        [Key]
        public override int Id { get; set; }

        public string? Name { get; set; }
    }
}
