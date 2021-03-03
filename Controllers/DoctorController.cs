using HospitalRestApi.Models;
using HospitalRestApi.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Cors;

namespace HospitalRestApi.Controllers
{
    [EnableCors("origins")]
    [ApiController]
    [Route("api")]
    public class DoctorController : Controller
    {
        private readonly IDoctorService doctorService;

        public DoctorController(IDoctorService doctorService)
        {
            this.doctorService = doctorService;
        }

        [HttpGet, Route("doctors")]
        public async Task<List<Doctor>> FindAllDoctors()
        {
            return await this.doctorService.FindAllDoctors();
        }

        [HttpGet, Route("doctor/{id}")]
        public async Task<Doctor> FindDoctorById(int? id)
        {
            return await this.doctorService.FindDoctorById(id);
        }

        [HttpPost, Route("doctor")]
        public async Task<Doctor> CreateDoctor(Doctor doctor)
        {
            return await this.doctorService.CreateDoctor(doctor);
        }
        
        [HttpPut, Route("doctor/{id}")]
        public async Task<Doctor> UpdateDoctor(int? id, Doctor doctor)
        {
            return await this.doctorService.UpdateDoctor(id, doctor);
        }

        [HttpDelete, Route("doctor/{id}")]
        public async Task<Doctor> DeleteDoctor(int? id)
        {
            return await this.doctorService.DeleteDoctor(id);
        }
    }
}
