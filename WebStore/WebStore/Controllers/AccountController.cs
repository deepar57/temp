﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using WebStore.Domain.Entities;
using WebStore.ViewModels;

namespace WebStore.Controllers
{
	public class AccountController : Controller
	{
		private readonly UserManager<User> _UserManager;
		private readonly SignInManager<User> _SignInManager;

		public AccountController(UserManager<User> UserManager, SignInManager<User> SignInManager)
		{
			_UserManager = UserManager;
			_SignInManager = SignInManager;
		}

		public IActionResult Register() => View();

		[HttpPost, ValidateAntiForgeryToken]
		public async Task<IActionResult> Register(RegisterUserViewModel model)
		{
			if (!ModelState.IsValid) return View(model);

			var new_user = new User()
			{
				UserName = model.UserName,
			};

			IdentityResult creatin_result = await _UserManager.CreateAsync(new_user, model.Password);
			if (creatin_result.Succeeded)
			{
				await _SignInManager.SignInAsync(new_user, false);

				return RedirectToAction("Index", "Home");
			}

			foreach (var error in creatin_result.Errors)
				ModelState.AddModelError("", error.Description);

			return View(model);
		}

		public IActionResult Login() => View();

		[HttpPost, ValidateAntiForgeryToken]
		public async Task<IActionResult> Login(LoginViewModel login)
		{
			if (!ModelState.IsValid) return View(login);

			var login_result = await _SignInManager.PasswordSignInAsync(login.UserName, login.Password, login.RememberMe, false);

			if (login_result.Succeeded)
			{
				if (Url.IsLocalUrl(login.ReturnUrl))
					return Redirect(login.ReturnUrl);

				return RedirectToAction("Index", "Home");
			}

			ModelState.AddModelError("", "Имя пользователя или пароль неверны.");
			return View(login);
		}

		public async Task<IActionResult> Logout()
		{
			await _SignInManager.SignOutAsync();
			return RedirectToAction("Index", "Home");
		}

		public IActionResult AccessDenied() => View();
	}
}