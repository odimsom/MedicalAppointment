

using Arquitectura.Domain.Base;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Arquitectura.Domain.Entities
{
    public sealed class Users : MedicalAppointmentBaseEntity
    {
        [Column("UserID")]
        [Key]
        public override int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }

        public int? RoleID { get; set; }
    }
}
