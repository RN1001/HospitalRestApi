using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HospitalRestApi.Models;
using HospitalRestApi.Services;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;

namespace HospitalRestApi.Controllers
{
    [EnableCors("origins")]
    [ApiController]
    [Route("api")]
    public class NurseController : Controller
    {
        private readonly INurseService _nurseService;

        public NurseController(INurseService nurseService)
        {
            this._nurseService = nurseService;
        }
        
        [HttpGet, Route("/nurses")]
        public async Task<IEnumerable<Nurse>> GetAllNurses()
        {
            return await _nurseService.FindAllNurses();
        }

        [HttpGet, Route("nurse/{id}")]
        public async Task<Nurse> GetNurseById(int? id)
        {
            return await _nurseService.FindNurseById(id);
        }

        [HttpPost, Route("nurse")]
        public async Task<Nurse> CreateNurse([FromBody] Nurse nurse)
        {
            return await _nurseService.CreateNurse(nurse);
        }

        [HttpPut, Route("nurse/{id}")]
        public async Task<Nurse> UpdateNurse(int? id, [FromBody] Nurse nurse)
        {
            return await _nurseService.UpdateNurse(id, nurse);
        }

        [HttpDelete, Route("nurse/{id}")]
        public async Task<Nurse> DeleteNurses(int? id)
        {
            return await _nurseService.DeleteNurse(id);
        }

    }
}
