using JSDemo1.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace JSDemo1.Controllers
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
			ViewBag.MyName = DAL.GetEmployeeName();
			return View();
		}

		public IActionResult GetForm()
		{
			return View();
		}

		public IActionResult UseForm(string nametext, string cattext)
		{
			if (nametext == null || cattext == null)
			{
				return Content("Please enter in all fields");
			}
			else
			{
				return Content($"{nametext} - {cattext}");
			}
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
