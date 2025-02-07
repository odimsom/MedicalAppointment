

using Arquitectura.Domain.Base;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Arquitectura.Domain.Entities
{
    public sealed class Roles : MedicalAppointmentBaseEntity
    {
        [Column("RoleID")]
        [Key]
        public override int Id { get; set; }

        public string RoleName { get; set; }
    }
}
