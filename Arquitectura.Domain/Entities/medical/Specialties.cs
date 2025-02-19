
using Arquitectura.Domain.Base;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Arquitectura.Domain.Entities.medical
{
    public sealed class Specialties : MedicalAppointmentBaseEntity<char>
    {
        [Column("SpecialtyID")]
        [Key]
        public override char Id { get; set; }

        public int SpecialtyName { get; set; }
    }
}
