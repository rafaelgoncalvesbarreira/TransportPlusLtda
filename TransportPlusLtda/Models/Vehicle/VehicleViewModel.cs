using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TransportPlusLtda.Models.Vehicle
{
    public class VehicleViewModel
    {
        public int Id { get; set; }
        public Guid GpsId { get; set; }
        public string Name { get; set; }
    }
}
