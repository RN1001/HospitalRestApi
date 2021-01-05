using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HospitalRestApi.Models
{
    public class Doctor : Employee
    {
        public Specialism Specialism { get; set; }

        public List<Patient> Patients { get; set; }

        public Doctor()
        {

        }

        public Doctor(int id, string firstname, string lastname)
        {
            Id = id;
            Firstname = firstname;
            Lastname = lastname;
        }

    }
}
