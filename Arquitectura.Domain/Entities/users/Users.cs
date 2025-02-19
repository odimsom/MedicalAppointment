// la luz en su infinita sabiduria me dejo aqui solo y sin luz con clase virtual a la que debo asistir me quejo en este comentario por que si me da la gana y seguire echando codigo asta que me aburra osea nunca.

using Arquitectura.Domain.Base;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Arquitectura.Domain.Entities.users
{
    public sealed class Users : MedicalAppointmentBaseEntity<int>
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
