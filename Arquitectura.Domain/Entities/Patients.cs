﻿
using Arquitectura.Domain.Base;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Arquitectura.Domain.Entities
{
    public sealed class Patients : MedicalAppointmentBaseEntity
    {
        [Column("PatientID")]
        [Key]
        public override int Id { get; set; }

        public DateTime DateOfBirth { get; set; }

        public char Gender { get; set; }

        public string PhoneNumber { get; set; } 

        public string Address { get; set; } 

        public string EmergencyContactName { get; set; } 

        public string EmergencyContactPhone { get; set; } 

        public string BloodType { get; set; } 

        public string? Allergies { get; set; }

        public int InsuranceProviderID { get; set; }
    }
}
