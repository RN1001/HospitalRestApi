using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HospitalRestApi.Models
{
    public class Patient : BaseEntity
    {
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public DateTime DateOfBirth { get; set; }
        public Doctor AssignedDoctor { get; set; }

        public Patient()
        {

        }

        public Patient(int id, string firstname, string lastname, DateTime DOB, Doctor doctor)
        {
            Id = id;
            Firstname = firstname;
            Lastname = lastname;
            DateOfBirth = DOB;
            AssignedDoctor = doctor;
        }

    }
}
