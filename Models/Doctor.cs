using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace HospitalRestApi.Models
{
    public class Doctor : Employee
    {
        public int? SpecialismId { get; set; }
        public virtual Specialism Specialism { get; set; }

        public int? LocationId { get; set; }
        public virtual Location Location { get; set; }
        
        public virtual ICollection<Patient> Patients { get; set; }

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
