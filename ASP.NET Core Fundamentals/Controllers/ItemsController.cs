using ASP.NET_Core_Fundamentals.Models;
using Microsoft.AspNetCore.Mvc;

namespace ASP.NET_Core_Fundamentals.Controllers
{
	public class ItemsController : Controller
	{
		public IActionResult Overview()
		{
			var item = new Item() { Name = "Keyboard" };
			return View(item);
		}

		public IActionResult Edit(int id)
		{
			return Content($"id: {id}");
		}
	}
}
