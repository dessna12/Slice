using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using pizza_restaurant.Models;

namespace pizza_restaurant.Pages
{
	public class MenuPizzaModel : PageModel
	{

		private readonly pizza_restaurant.Data.DataContext _context;

		public MenuPizzaModel(pizza_restaurant.Data.DataContext context)
		{
			_context = context;
		}

		public IList<Pizza> Pizza { get; set; } = default!;

		public async Task OnGetAsync()
		{
			Pizza = await _context.Pizzas.ToListAsync();
		}
	}
}
