using HospitalRestApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HospitalRestApi.Services
{
    public interface ILocationService
    {
        public Task<Location> FindLocationById(int? id);
        public Task<List<Location>> FindAllLocations();
        public Task<Location> CreateLocation(Location location);
        public Task<Location> UpdateLocation(int? id, Location location);
        public Task<Location> DeleteLocation(int? id);
    }
}
