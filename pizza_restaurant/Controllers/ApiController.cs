using Humanizer;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using pizza_restaurant.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace pizza_restaurant.Controllers
{
	[Route("[controller]")]
	[ApiController]
	public class ApiController : Controller
	{

		private readonly pizza_restaurant.Data.DataContext _context;

		public ApiController(pizza_restaurant.Data.DataContext context)
		{
			_context = context;
		}

	
		// GET: api/pizzas
		[HttpGet]
		[Route("pizzas")]
		public IActionResult GetPizzas()
		{
			List<Pizza> pizzas = _context.Pizzas.ToList();
			pizzas= pizzas.OrderBy(p => p.prix).ToList();

			return Json(pizzas);
		}


	}
}
