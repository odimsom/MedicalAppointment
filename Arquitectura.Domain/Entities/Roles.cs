

using Arquitectura.Domain.Base;

namespace Arquitectura.Domain.Entities
{
    public sealed class Roles : MedicalAppointmentBaseEntity
    {
        public int RoleID { get; set; }

        public string RoleName { get; set; }
    }
}
