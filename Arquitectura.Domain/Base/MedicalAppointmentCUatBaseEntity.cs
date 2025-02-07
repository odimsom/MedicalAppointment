

namespace Arquitectura.Domain.Base
{
    public abstract class MedicalAppointmentCUatBaseEntity : BaseEntity<int>
    {
        protected MedicalAppointmentCUatBaseEntity()
        {
            this.CreatedAt = DateTime.Now;
        }
        public DateTime? UpdatedA { get; set; }

        public DateTime CreatedAt { get; set; }
    }
}
