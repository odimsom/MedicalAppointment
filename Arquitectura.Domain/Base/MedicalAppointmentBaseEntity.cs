namespace Arquitectura.Domain.Base
{
    public abstract class MedicalAppointmentBaseEntity : MedicalAppointmentCUatBaseEntity
    {
        protected MedicalAppointmentBaseEntity()
        { 
            this.IsActive = false;
        }
        public bool IsActive { get; set; }
    }
}
