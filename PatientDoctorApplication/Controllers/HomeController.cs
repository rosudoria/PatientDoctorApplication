using Microsoft.AspNetCore.Mvc;
using PatientDoctorApplication.Models;
using System.Diagnostics;

namespace PatientDoctorApplication.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        /// <summary>
        /// Author: Roswell Doria
        /// Date: 2022-10-25
        /// 
        /// This function is responsible for displaying the Doctor's landing page
        /// after successfully logging in.
        ///
        /// </summary>
        /// <returns></returns>
        public IActionResult DoctorIndex()
        {
            return View();
        }

        /// <summary>
        /// Author: Roswell Doria
        /// Date: 2022-10-25
        /// 
        /// This function is responsible for displaying the Patient's landing page
        /// after successfully logging in.
        ///
        /// </summary>
        /// <returns></returns>
        public IActionResult PatientIndex()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}