
using Arquitectura.Domain.Base;

namespace Arquitectura.Domain.Entities
{
    public sealed class Appointments : MedicalAppointmentCUatBaseEntity
    {
        public int AppointmentID { get; set; }

        public int PatientID { get; set; }

        public int DoctorID { get; set; }

        public DateTime AppointmentDate { get; set; }

        public int StatusID { get; set; }
    }
}
