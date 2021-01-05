using HospitalRestApi.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace HospitalRestApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class HospitalRecordController : ControllerBase
    {
        [HttpGet, Route("Patients")]
        public IEnumerable<Patient> GetPatients() 
        {
            return new Patient[]
            {
                new Patient(
                    1,
                    "Raihaan",
                    "Nazir",
                    new System.DateTime(1993, 6, 9),
                    new List<Doctor>()
                    {
                        new Doctor(1, "Eraj", "Arshad")
                    },
                    new List<Nurse>()
                    {
                        new Nurse(1, "Random", "Nurse")
                    }
                ),
                new Patient(
                    2,
                    "Omair",
                    "Nazir",
                    new System.DateTime(1992, 4, 8),
                    new List<Doctor>()
                    {
                        new Doctor(2, "Doctor", "Cool"),
                        new Doctor(3, "Doctor", "Big man")
                    },
                    new List<Nurse>()
               )
            };
        }

        [HttpGet, Route("Patient/{id}")]
        public Patient GetPatient(int id) 
        {
            return new Patient();
        }



    }
}