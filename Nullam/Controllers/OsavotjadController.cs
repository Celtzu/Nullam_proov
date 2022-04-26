using Microsoft.AspNetCore.Mvc;
using Nullam.Models;
using Nullam.OsavotjadData;

namespace Nullam.Controllers
{
    public class OsavotjadController : Controller
    {
        public IActionResult Index()
        {
            SampleDataRepository2 sampleDataRepository2 = new();

            return View(sampleDataRepository2.GetAllOsavotjad());
        }

        public IActionResult Create()
        {
            return View();
        }
    }
}
