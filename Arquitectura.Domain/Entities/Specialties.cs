
using Arquitectura.Domain.Base;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Arquitectura.Domain.Entities
{
    public sealed class Specialties : MedicalAppointmentBaseEntity
    {
        [Column("SpecialtyID")]
        [Key]
        public override int Id { get; set; }

        public int SpecialtyName { get; set; }
    }
}
