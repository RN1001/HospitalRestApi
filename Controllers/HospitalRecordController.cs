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
                    new Doctor(1, "Eraj", "Arshad")
                    ),
                new Patient(
                    2,
                    "Omair",
                    "Nazir",
                    new System.DateTime(1992, 4, 8),
                    new Doctor(2, "Someone", "Somewhere")
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