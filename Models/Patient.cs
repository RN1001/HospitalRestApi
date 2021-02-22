using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace HospitalRestApi.Models
{
    public class Patient : BaseEntity
    {
        [Required]
        [StringLength(100, MinimumLength = 2, ErrorMessage = "Firstname is too short.")]
        public string Firstname { get; set; }
        [Required]
        [StringLength(100, MinimumLength = 2, ErrorMessage = "Lastname is too short.")]
        public string Lastname { get; set; }
        [Required]
        public DateTime DateOfBirth { get; set; }

        [ForeignKey("doctor_id")]
        public int DoctorId { get; set; }
        public virtual Doctor AssignedDoctors { get; set; }

        [ForeignKey("nurse_id")]
        public int NurseId { get; set; }
        public virtual Nurse AssignedNurses { get; set; }


        public Patient()
        {

        }

        public Patient(int id, string firstname, string lastname, DateTime DOB)
        {
            Id = id;
            Firstname = firstname;
            Lastname = lastname;
            DateOfBirth = DOB;
        }

    }
}
