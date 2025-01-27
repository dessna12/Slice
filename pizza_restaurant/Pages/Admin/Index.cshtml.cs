using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication;
using System.Security.Claims;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace pizza_restaurant.Pages.Admin
{

    
    public class IndexModel : PageModel
    {

		IConfiguration configuration;
		public bool isAccountValid = true;

		public IndexModel(IConfiguration configuration)
		{
			this.configuration = configuration;
		}
		
		public IActionResult OnGet()
        {

            if (HttpContext.User.Identity != null && HttpContext.User.Identity.IsAuthenticated)
			{
				
				return Redirect("/Admin/Pizzas");
			}
			
			return Page();
        }

		public async Task<IActionResult> OnPostAsync(string username, string password, string ReturnUrl)
		{
			var authSection = configuration.GetSection("Auth");

			string adminLogin = authSection["AdminLogin"];
			string adminPassword = authSection["AdminPassword"];


            if ((username == adminLogin) && (password == adminPassword))
			{
				isAccountValid = true;
				var claims = new List<Claim>
				{
				new Claim(ClaimTypes.Name, username)
				};
				var claimsIdentity = new ClaimsIdentity(claims, "Login");
				await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, new
				ClaimsPrincipal(claimsIdentity));
				return Redirect(ReturnUrl == null ? "/Admin/Pizzas" : ReturnUrl);
			}
			isAccountValid = false;
			return Page();
		}

        public async Task<IActionResult> OnGetLogout()
        {
            await HttpContext.SignOutAsync();
			return Redirect("/Admin");

        }


    }


}
