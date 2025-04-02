using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using System.Linq;
using LoanManagement.Models;

namespace LoanManagement.Controllers
{
    public class AccountController : Controller
    {
        private readonly DatabaseContext _context;

        public AccountController(DatabaseContext context)
        {
            _context = context;
        }

        // GET: نمایش صفحه ورود
        public IActionResult Login()
        {
            return View();
        }

        // POST: بررسی اطلاعات کاربر و ورود به سیستم
        [HttpPost]
        public IActionResult Login(string nationalCode, string password)
        {
            var user = _context.users.FirstOrDefault(u => u.NationalId == nationalCode && u.Password == password);

            if (user != null)
            {
                // ذخیره اطلاعات کاربر در سشن
                HttpContext.Session.SetString("UserNationalCode", user.NationalId);
                HttpContext.Session.SetString("UserName", user.FirstName+' '+user.LastName);

                return RedirectToAction("Dashboard", "Account");
            }

            ViewBag.Error = "کد ملی یا رمز عبور اشتباه است!";
            return View();
        }

        // GET: داشبورد کاربر (فقط در صورتی که لاگین کرده باشد)
        public IActionResult Dashboard()
        {
            if (HttpContext.Session.GetString("UserNationalCode") == null)
            {
                return RedirectToAction("Login");
            }

            ViewBag.UserName = HttpContext.Session.GetString("UserName");
            return View();
        }

        // GET: خروج از سیستم
        public IActionResult Logout()
        {
            HttpContext.Session.Clear(); // حذف اطلاعات سشن
            return RedirectToAction("Login");
        }
    }
}
