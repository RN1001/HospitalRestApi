using HospitalRestApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HospitalRestApi.Repositories
{
    public class LocationRepository : EfRepository<Location>, ILocationRepository
    {
        private readonly HospitalApiContext context;

        public LocationRepository(HospitalApiContext context) : base(context)
        {
            this.context = context;
        }
    }
}
