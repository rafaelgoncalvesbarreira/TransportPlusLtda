using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TransportPlusLtda.Data.Entities
{
    public class Vehicle
    {
        public int Id { get; set; }
        public Guid GpsId { get; set; }
        public string Name { get; set; }
    }
}
