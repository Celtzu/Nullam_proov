using Microsoft.AspNetCore.Mvc;
using Nullam.Models;
using Nullam.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Nullam.Controllers
{
    public class UritusController : Controller
    {

        public IActionResult Index()
        {
            SampleDataRepository sampleDataRepository = new();

            return View(sampleDataRepository.GetAllUritused());
        }

        public IActionResult Create()
        {
            return View();
        }

        

    }

}
