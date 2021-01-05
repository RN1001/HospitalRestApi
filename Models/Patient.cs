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
        public List<Doctor> AssignedDoctors { get; set; }
        public List<Nurse> AssignedNurses { get; set; }

        public Patient()
        {

        }

        public Patient(int id, string firstname, string lastname, DateTime DOB, List<Doctor> doctor, List<Nurse> nurses)
        {
            Id = id;
            Firstname = firstname;
            Lastname = lastname;
            DateOfBirth = DOB;
            AssignedDoctors = doctor;
            AssignedNurses = nurses;
        }

    }
}
