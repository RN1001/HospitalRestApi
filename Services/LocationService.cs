using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HospitalRestApi.Models;
using HospitalRestApi.Repositories;

namespace HospitalRestApi.Services
{
    public class LocationService : ILocationService
    {
        private readonly ILocationRepository locationRepository;

        public LocationService(ILocationRepository locationRepository)
        {
            this.locationRepository = locationRepository;
        }

        public async Task<Location> FindLocationById(int? id)
        {
            return await this.locationRepository.FindByIdAsync(id);
        }

        public async Task<List<Location>> FindAllLocations()
        {
            return await locationRepository.FindAllAsync();
        }

        public async Task<Location> CreateLocation(Location location)
        {
            return await locationRepository.CreateAsync(location);
        }

        public async Task<Location> UpdateLocation(int? id, Location location)
        {
            return await locationRepository.UpdateAsync(id, location);
        }

        public async Task<Location> DeleteLocation(int? id)
        {
            return await locationRepository.DeleteAsync(id);
        }
    }
}
