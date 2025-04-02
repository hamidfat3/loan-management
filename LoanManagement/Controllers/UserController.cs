using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using System.Linq;
using LoanManagement.Models;

namespace LoanManagement.Controllers
{
    public class UserController : Controller
    {
        private readonly DatabaseContext _context;

        public UserController(DatabaseContext context)
        {
            _context = context;
        }

        // اطلاعات پروفایل کاربر
        public IActionResult Profile()
        {
            string nationalCode = HttpContext.Session.GetString("UserNationalCode");

            if (string.IsNullOrEmpty(nationalCode))
                return RedirectToAction("Login", "Account");

            var user = _context.users.FirstOrDefault(u => u.NationalId == nationalCode);

            return View(user);
        }

        // لیست وام‌های کاربر
        public IActionResult Loans()
        {
            string nationalCode = HttpContext.Session.GetString("UserNationalCode");

            if (string.IsNullOrEmpty(nationalCode))
                return RedirectToAction("Login", "Account");

            var loans = _context.loans.Where(l => l.ReceiverNationalId == nationalCode).ToList();

            return View(loans);
        }

        // لیست پرداخت‌های کاربر
        public IActionResult Payments()
        {
            string nationalCode = HttpContext.Session.GetString("UserNationalCode");

            if (string.IsNullOrEmpty(nationalCode))
                return RedirectToAction("Login", "Account");

            var payments = _context.payments.Where(p => p.NationalIdPayer == nationalCode).ToList();

            return View(payments);
        }
    }
}
