using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TransportPlusLtda.Services;
using TransportPlusLtda.Models.Vehicle;
using TransportPlusLtda.Data.Entities;
using Microsoft.AspNetCore.Authorization;

namespace TransportPlusLtda.Controllers
{
    [Authorize]
    public class VehicleController : Controller
    {
        private IVehicleService service;

        public VehicleController(IVehicleService service)
        {
            this.service = service;
        }

        public IActionResult Index()
        {
            var list = new List<Vehicle>();
            list.Add(new Vehicle
            {
                Id = 1,
                GpsId = Guid.Parse("5a16662f-a28f-424f-8c3f-2e662704ee29"),
                Name = "Vehicle secure #23"
            });
            list.Add(new Vehicle
            {
                Id = 1,
                GpsId = Guid.Parse("4f46fd87-d029-4b55-8c83-b0425a61b7b0"),
                Name = "oil truck #332"
            });
            var models = (from v in list
                          select new VehicleViewModel
                          {
                              Id = v.Id,
                              Name = v.Name,
                              GpsId = v.GpsId
                          }).ToList();

            return View(models);
        }
        
    }
}