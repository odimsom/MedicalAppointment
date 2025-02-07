
using Arquitectura.Domain.Base;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Arquitectura.Domain.Entities
{
    public sealed class Appointments : MedicalAppointmentCUatBaseEntity
    {
        [Column("AppointmentID")]
        [Key]
        public override int Id { get ; set ; }

        public int PatientID { get; set; }

        public int DoctorID { get; set; }

        public DateTime AppointmentDate { get; set; }

        public int StatusID { get; set; }
    }
}
