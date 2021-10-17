using EntityFramworkFirstApp.Data;
using EntityFramworkFirstApp.Models.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace EntityFramworkFirstApp.Controllers
{
    public class AccountController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly SignInManager<IdentityUser> _signInManager;
        private readonly UserManager<IdentityUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;

        public AccountController(ApplicationDbContext context, SignInManager<IdentityUser> signInManager, UserManager<IdentityUser> userManager, RoleManager<IdentityRole> roleManager)
        {
            _context = context;
            _signInManager = signInManager;
            _userManager = userManager;
            _roleManager = roleManager;
        }
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Login(LoginViewModel loginViewModel)
        {
            if (ModelState.IsValid)
            {
                var user = await _userManager.FindByNameAsync(loginViewModel.UserName);
                if (user != null)
                {
                    var result = await _signInManager.PasswordSignInAsync(user, loginViewModel.Password, loginViewModel.RememberMe, false);

                    if (result.Succeeded)
                    {
                        return RedirectToAction("Index", "Home");
                    }
                }
            }

            return View();
        }
        public IActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Register(RegisterViewModel registerViewModel)
        {
            if (ModelState.IsValid)
            {
                var userNameExistsTest = await _userManager.FindByNameAsync(registerViewModel.UserName);
                if (userNameExistsTest==null)
                {
                    var user = new IdentityUser();
                    user.UserName = registerViewModel.UserName;
                    user.Email = registerViewModel.Email;
                    user.PhoneNumber = registerViewModel.PhoneNumber;
                    var result = await _userManager.CreateAsync(user, registerViewModel.Password);
                    if (result.Succeeded)
                    {
                        return RedirectToAction(nameof(Login));
                    }
                }
                else
                {
                    ModelState.AddModelError("", "UserName Already Exists");
                }
              
            }
            return View(registerViewModel);
        }
        public async Task<IActionResult> LogOut()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction(nameof(Login));
        }
        public IActionResult CreateRole()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> CreateRole(RoleViewModel roleViewModel)
        {
            if (ModelState.IsValid)
            {
                var role = new IdentityRole();
                role.Name = roleViewModel.RoleName;
                var result = await _roleManager.CreateAsync(role);
                if (result.Succeeded)
                {
                    return RedirectToAction("Index", "Home");
                }
            }
            return View();
        }

        public IActionResult UserIndex()
        {
            var users = _userManager.Users.ToList();
            return View(users);
        }
        public IActionResult RoleIndex()
        {
            var roles = _roleManager.Roles.ToList();
            return View(roles);
        }
        public IActionResult AssignRole()
        {
            ViewData["Users"] = new SelectList(_userManager.Users, "UserName", "UserName");
            ViewData["Roles"] = new SelectList(_roleManager.Roles, "Name", "Name");
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> AssignRole(AssignRoleViewModel assignRoleViewModel)
        {
            var user = await _userManager.FindByNameAsync(assignRoleViewModel.UserName);
            await _userManager.AddToRoleAsync(user, assignRoleViewModel.RoleName);
            return View();
        }
       
    }
}
