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
    [Route("api")]
    public class SpecialismController : Controller
    {
        private readonly ISpecialismService _specialismService;

        public SpecialismController(ISpecialismService specialismService)
        {
            this._specialismService = specialismService;
        }

        [HttpGet, Route("specialism/{id}")]
        public async Task<Specialism> GetSpecialismById(int? id)
        {
            return await _specialismService.FindSpecialismById(id);
        }

        [HttpGet, Route("specialisms")]
        public async Task<IEnumerable<Specialism>> GetAllSpecialisms()
        {
            return await _specialismService.FindAllSpecialisms();
        }

        [HttpPost, Route("specialism")]
        public async Task<Specialism> AddSpecialism([FromBody] Specialism specialism)
        {
            return await _specialismService.CreateSpecialism(specialism);
        }

        [HttpPut, Route("specialism/{id}")]
        public async Task<Specialism> UpdateSpecialism(int? id, [FromBody] Specialism specialism)
        {
            return await _specialismService.UpdateSpecialism(id, specialism);
        }

        [HttpDelete, Route("specialism/{id}")]
        public async Task<Specialism> DeleteSpecialism(int? id)
        {
            return await _specialismService.DeleteSpecialism(id);
        }


    }
}
