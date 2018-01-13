using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TransportPlusLtda.Models.Api
{
    public class PositionViewModel
    {
        public Guid Id { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
    }
}
