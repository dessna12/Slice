using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using pizza_restaurant.Data;
using pizza_restaurant.Models;

namespace pizza_restaurant.Pages.Admin.Pizzas
{
	[Authorize]
	public class IndexModel : PageModel
    {
        private readonly pizza_restaurant.Data.DataContext _context;

        public IndexModel(pizza_restaurant.Data.DataContext context)
        {
            _context = context;
        }

        public IList<Pizza> Pizza { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Pizza = await _context.Pizzas.ToListAsync();
        }
    }
}
