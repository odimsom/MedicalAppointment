

namespace Arquitectura.Domain.Base
{
    public abstract class MedicalAppointmentCUatBaseEntity<Ttype> : BaseEntity<Ttype>
    {
        protected MedicalAppointmentCUatBaseEntity()
        {
            this.CreatedAt = DateTime.Now;
        }
        public DateTime? UpdatedA { get; set; }

        public DateTime CreatedAt { get; set; }
    }
}
