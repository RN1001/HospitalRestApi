using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace HospitalRestApi.Models
{
    public class Nurse : Employee
    {

        [ForeignKey("LocationId")]
        public int LocationId { get; set; }
        public virtual Location Location { get; set; }

        public virtual ICollection<Patient> Patients { get; set; }

        public Nurse()
        {

        }

        public Nurse(int id, string firstname, string lastname)
        {
            Id = id;
            Firstname = firstname;
            Lastname = lastname;
        }

    }
}