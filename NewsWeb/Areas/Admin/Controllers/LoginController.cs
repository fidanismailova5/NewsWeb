using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using NewsWeb.Areas.Admin.Data;
using Application.DTOs;
using Microsoft.AspNetCore.Authorization;
using NewsWeb.Areas.Admin.Models;
using Application.Contracts;
using Application.DTOs;
using Microsoft.AspNetCore.Identity;
using System.Data;

namespace NewsWeb.Areas.Admin.Controllers
{
    public class LoginController : Controller
	{
		private readonly ApplicationDbContext _context;
		private readonly ILogger<LoginController> _logger;


		public LoginController(ApplicationDbContext context, ILogger<LoginController> logger)
		{
			_context = context;
			_logger = logger;
		}

		[Area("Admin")]
		public IActionResult Index()
		{
			return View();
		}

		[HttpPost]
		[ValidateAntiForgeryToken]
		public IActionResult Index(string email, string password)
		{
			try
			{
				var user = _context.User.SingleOrDefault(u => u.Email == email && u.Password == password);
				if (user == null)
				{
					ModelState.AddModelError(string.Empty, "Invalid login attempt");
					return View();
				}

				var claims = new[]
				{
				new Claim(ClaimTypes.Name, user.Email),
			};
				var identity = new ClaimsIdentity(claims, "YourAuthenticationScheme");
				var principal = new ClaimsPrincipal(identity);

				HttpContext.SignInAsync(
				   CookieAuthenticationDefaults.AuthenticationScheme,
				   principal,
				   new AuthenticationProperties
				   {
					   IsPersistent = false, // Set to true for persistent cookies
					   ExpiresUtc = DateTime.UtcNow.AddMinutes(20) // Adjust as needed
				   });

				return RedirectToAction("Index", "Home");
			}
			catch (Exception ex)
			{
				// Log the exception for debugging purposes
				_logger.LogError(ex, "An error occurred during login.");
				ModelState.AddModelError(string.Empty, "An error occurred during login.");
				return View();
			}
		}


		[HttpGet]
		[AllowAnonymous]
		public IActionResult Login(string returnUrl)
		{
			returnUrl = this.CheckReturnUrl(returnUrl);
			return View(new UserViewModel { ReturnUrl = returnUrl });
		}

		//[HttpPost]
		//[AllowAnonymous]
		//public async Task<IActionResult> Login(UserViewModel model)
		//{
		//	if (ModelState.IsValid)
		//	{
		//		UsersDto usersDto = new UsersDto();
		//		var userDTO = new UsersDTO { Email = model.Email, Password = model.Password };
		//		var result = await this._usersService.LoginAsync(userDTO);

		//		if (result.Succeeded)
		//		{
		//			var user = await this._usersService.GetUserAsync(userDTO.Email);
		//			userDTO.Name = user.Name;
		//			await this._userManager.SignInAsync(this.HttpContext, userDTO, model.RememberMe);
		//			return Redirect(model.ReturnUrl);
		//		}
		//		else
		//		{
		//			foreach (var error in result.Messages)
		//			{
		//				ModelState.AddModelError(string.Empty, error);
		//			}
		//		}
		//	}

		//	return View(model);
		//}

		private string CheckReturnUrl(string returnUrl)
		{
			if (string.IsNullOrEmpty(returnUrl)
			   || returnUrl.Contains("Register")
			   || returnUrl.Contains("Login"))
			{
				return "/";
			}
			return returnUrl;
		}
	}
}
