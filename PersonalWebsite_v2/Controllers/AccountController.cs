using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using PersonalWebsite_v2.Models;
using PersonalWebsite_v2.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonalWebsite_v2.Controllers
{
	public class AccountController : Controller
	{
		private readonly UserManager<User> _userManager;
		private readonly SignInManager<User> _signInManager;
		public AccountController(UserManager<User> userManager, SignInManager<User> signInManager)
		{
			_userManager = userManager;
			_signInManager = signInManager;
		}

		[HttpGet]
		[AllowAnonymous]
		public IActionResult Login()
		{
			if (User.Identity.IsAuthenticated)
			{
				return Redirect("Admin/Index");
			}
			return View("Login");
		}

		[HttpPost]
		[ValidateAntiForgeryToken]
		[AllowAnonymous]
		public async Task<IActionResult> Login([FromForm] LoginVM vm)
		{


			if (!ModelState.IsValid)
			{
				return View("Login", vm);
			}

			var result = await _signInManager.PasswordSignInAsync(vm.UserName, vm.Password, vm.RememberMe, false);
			if (result.Succeeded)
			{
				if (Url.IsLocalUrl(vm.ReturnUrl))
				{
					return Redirect(vm.ReturnUrl);
				}
				else
				{
					return RedirectToAction("Index", "Admin");
				}
			}

			return View("Login", vm);
		}

		[Authorize]
		[HttpGet]
		public IActionResult Register()
		{
			return View("Register");
		}


		[HttpPost]
		public async Task<IActionResult> Register([FromForm] RegisterVM vm)
		{
			if (!ModelState.IsValid)
			{
				return View("Register", vm);
			}
			//var user = _mapper.Map<User>(vm);
			var user = new User
			{
				UserName = vm.UserName,
				Email = vm.Email,
			};
			var result = await _userManager.CreateAsync(user, vm.Password);
			if (!result.Succeeded)
			{
				foreach (var error in result.Errors)
				{
					ModelState.TryAddModelError(error.Code, error.Description);
				}
				return BadRequest(ModelState);
			}
			return StatusCode(200, "User Created");

		}

		public async Task<IActionResult> Logout()
    {
			await _signInManager.SignOutAsync();
			return RedirectToAction("Login");
    }
	}
}
