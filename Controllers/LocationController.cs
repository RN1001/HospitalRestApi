using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HospitalRestApi.Models;
using HospitalRestApi.Services;
using Microsoft.AspNetCore.Cors;

namespace HospitalRestApi.Controllers
{
    [EnableCors("origins")]
    [ApiController]
    [Route("api")]
    public class LocationController : Controller
    {
        private readonly ILocationService _locationService;

        public LocationController(ILocationService locationService)
        {
            this._locationService = locationService;
        }

        [HttpGet, Route("locations")]
        public async Task<List<Location>> FindAllLocations()
        {
            return await this._locationService.FindAllLocations();
        }

        [HttpGet, Route("location/{id}")]
        public async Task<Location> findLocationById(int? id)
        {
            return await this._locationService.FindLocationById(id);
        }

        [HttpPost, Route("location")]
        public async Task<Location> CreateLocation([FromBody] Location location)
        {
            return await this._locationService.CreateLocation(location);
        }

        [HttpPut, Route("location/{id}")]
        public async Task<Location> UpdateLocation(int? id, [FromBody] Location location)
        {
            return await this._locationService.UpdateLocation(id, location);
        }

        [HttpDelete, Route("location/{id}")]
        public async Task<Location> DeleteLocation(int? id)
        {
            return await this._locationService.DeleteLocation(id);
        }

    }
}
