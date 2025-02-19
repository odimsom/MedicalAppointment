namespace Arquitectura.Domain.Base
{
    public abstract class MedicalAppointmentBaseEntity<Ttype> : MedicalAppointmentCUatBaseEntity<Ttype>
    {
        protected MedicalAppointmentBaseEntity()
        { 
            this.IsActive = false;
        }
        public bool IsActive { get; set; }
    }
}
