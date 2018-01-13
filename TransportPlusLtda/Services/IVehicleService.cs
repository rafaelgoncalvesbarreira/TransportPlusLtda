using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TransportPlusLtda.Data.Entities;

namespace TransportPlusLtda.Services
{
    public interface IVehicleService
    {
        IEnumerable<Vehicle> GetAll();
    }
}
