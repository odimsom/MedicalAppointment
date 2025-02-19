

using Arquitectura.Domain.Base;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Arquitectura.Domain.Entities.System
{
    public sealed class Roles : MedicalAppointmentBaseEntity<int>
    {
        [Column("RoleID")]
        [Key]
        public override int Id { get; set; }

        public string RoleName { get; set; }
    }
}
