using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TransportPlusLtda.Data;
using TransportPlusLtda.Data.Entities;

namespace TransportPlusLtda.Services
{
    public class VehicleService : IVehicleService
    {
        private ApplicationDbContext context;

        public VehicleService(ApplicationDbContext context)
        {
            this.context = context;
        }

        public IEnumerable<Vehicle> GetAll()
        {
            return context.VehicleItems;
        }
    }
}
