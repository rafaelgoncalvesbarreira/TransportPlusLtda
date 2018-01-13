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
            var models = (from v in service.GetAll()
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