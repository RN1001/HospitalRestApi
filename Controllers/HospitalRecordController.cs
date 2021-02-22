using HospitalRestApi.Models;
using HospitalRestApi.Services;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace HospitalRestApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class HospitalRecordController : ControllerBase
    {
        private readonly IPatientService patientService;

        public HospitalRecordController(IPatientService patientService)
        {
            this.patientService = patientService;
        }


        [HttpGet, Route("patients")]
        public async Task<IEnumerable<Patient>> GetPatients() 
        {
            return await this.patientService.FindAllPatients();
        }

        [HttpGet, Route("patient/{id}")]
        public async Task<Patient> GetPatient(int? id) 
        {
            return await this.patientService.FindPatientById(id);
        }

        [HttpPost, Route("patient")]
        public async Task<IActionResult> CreatePatient([FromBody] Patient patient)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            
            await this.patientService.CreatePatient(patient);

            return CreatedAtAction(nameof(GetPatient), new { id = patient.Id }, patient);
        }

        [HttpPut, Route("patient/{id}")]
        public async Task<IActionResult> UpdatePatient(int? id, [FromBody] Patient patient)
        {
            var patientFound = await this.patientService.UpdatePatient(id, patient);
            if (patientFound == null)
            {
                return NotFound();
            }

            return NoContent();
        }

        [HttpDelete, Route("patient/{id}")]
        public async Task<IActionResult> DeletePatient(int? id)
        {
            var patient = await this.patientService.FindPatientById(id);
            if (patient == null)
            {
                return BadRequest();
            }
            await this.patientService.DeletePatient(id);
            return NoContent();
        }

    }
}