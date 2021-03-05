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

        public int? DoctorId { get; set; }
        public virtual Doctor AssignedDoctor { get; set; }

        public int? NurseId { get; set; }
        public virtual Nurse AssignedNurse { get; set; }

        public int? LocationId { get; set; }
        public virtual Location Location { get; set; }

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
