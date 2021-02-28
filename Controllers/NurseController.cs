using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HospitalRestApi.Models;
using HospitalRestApi.Services;
using Microsoft.AspNetCore.Mvc;

namespace HospitalRestApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class NurseController : Controller
    {
        private readonly INurseService _nurseService;

        public NurseController(INurseService nurseService)
        {
            this._nurseService = nurseService;
        }
        
        public async Task<IEnumerable<Nurse>> GetAllNurses()
        {
            return await _nurseService.FindAllNurses();
        }

        public async Task<Nurse> GetNurseById(int? id)
        {
            return await _nurseService.FindNurseById(id);
        }

        public async Task<Nurse> CreateNurse([FromBody] Nurse nurse)
        {
            return await _nurseService.CreateNurse(nurse);
        }

        public async Task<Nurse> UpdateNurse(int? id, [FromBody] Nurse nurse)
        {
            return await _nurseService.UpdateNurse(id, nurse);
        }

        public async Task<Nurse> DeleteNurses(int? id)
        {
            return await _nurseService.DeleteNurse(id);
        }

    }
}
