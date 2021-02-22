using System.Collections.Generic;

namespace HospitalRestApi.Models
{
    public class Specialism : BaseEntity
    {
        public string SpecialityName { get; set; }

        public ICollection<Doctor> Doctors { get; set; }
    }
}