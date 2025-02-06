

using Arquitectura.Domain.Base;

namespace Arquitectura.Domain.Entities
{
    public sealed class Users : MedicalAppointmentBaseEntity
    {
        public int UserID { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }

        public int? RoleID { get; set; }
    }
}
