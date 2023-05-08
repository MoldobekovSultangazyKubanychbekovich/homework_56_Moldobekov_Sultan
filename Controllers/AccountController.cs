using home_56.Models;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using home_56.ViewModels;

namespace home_56.Controllers
{
    public class AccountController : Controller
    {
        //private StoreContext db;
        //public AccountController(StoreContext _db)
        //{
        //    db = _db;
        //}
        //[HttpGet]
        //public IActionResult Login()
        //{
        //    return View();
        //}
        //[HttpPost]
        //public async Task<IActionResult> Login(LoginViewModel model)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        User user = await db.Users.Include(u => u.Role).FirstOrDefaultAsync(u => u.Email == model.Email && u.Password == model.Password);
        //        if (user != null)
        //        {
        //            await Authenticate(user);
        //            return RedirectToAction("Index", "Home");
        //        }
        //    }
        //    return View(model);
        //}
        //[HttpGet]
        //public IActionResult Register()
        //{
        //    return View();
        //}
        //[HttpPost]
        //public async Task<IActionResult> Register(RegisterViewModel model)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        User user = await db.Users.FirstOrDefaultAsync(u => u.Email == model.Email);
        //        if (user == null)
        //        {
        //            var role = await db.Roles.FirstOrDefaultAsync(r => r.Name == "user");
        //            var newuser = new User
        //            {
        //                Email = model.Email,
        //                Password = model.Password,
        //                Role = role,
        //                RoleId = role.Id
        //            };
        //            await db.Users.AddAsync(newuser);
        //            await db.SaveChangesAsync();
        //            await Authenticate(newuser);
        //            return RedirectToAction("Index", "Home");
        //        }
        //    }
        //    return View(model);
        //}
        //private async Task Authenticate(User user)
        //{
        //    var claims = new List<Claim>
        //    {
        //        new Claim(ClaimsIdentity.DefaultNameClaimType, user.Email),
        //        new Claim(ClaimsIdentity.DefaultRoleClaimType, user.Role?.Name)
        //    };
        //    ClaimsIdentity id = new ClaimsIdentity(
        //        claims,
        //        "ApplicationCookie",
        //        ClaimsIdentity.DefaultNameClaimType,
        //        ClaimsIdentity.DefaultRoleClaimType);
        //    await HttpContext.SignInAsync(
        //        CookieAuthenticationDefaults.AuthenticationScheme,
        //        new ClaimsPrincipal(id),
        //        new AuthenticationProperties
        //        {
        //            IsPersistent = true,
        //            ExpiresUtc = DateTime.UtcNow.AddMinutes(1)
        //        }
        //        );
        //}
        //public async Task<IActionResult> Logout()
        //{
        //    await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
        //    return RedirectToAction("Login", "Account");
        //}
    }
}
