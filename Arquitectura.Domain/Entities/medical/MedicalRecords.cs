
using Arquitectura.Domain.Base;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Arquitectura.Domain.Entities.medical
{
    public sealed class MedicalRecords : MedicalAppointmentCUatBaseEntity<int>
    {
        [Column("RecordID")]
        [Key]
        public override int Id { get; set; }

        public int PatientID { get; set; }

        public int DoctorID { get; set; }

        public string Diagnosis { get; set; }

        public string Treatment { get; set; }

        public DateTime DateOfVisit { get; set; }
    }
}
