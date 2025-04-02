using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using LoanManagement.Models;
using Microsoft.EntityFrameworkCore;


var builder = WebApplication.CreateBuilder(args);

// افزودن پشتیبانی از MVC
builder.Services.AddControllersWithViews();

// افزودن پشتیبانی از سشن
builder.Services.AddSession(options =>
{
    options.IdleTimeout = TimeSpan.FromMinutes(30); // تنظیم تایم اوت سشن
    options.Cookie.HttpOnly = true;
    options.Cookie.IsEssential = true;
});

// اضافه کردن DatabaseContext
builder.Services.AddDbContext<DatabaseContext>(options =>  
    options.UseSqlite("Data Source=App_Data/loan.db"));




var app = builder.Build();


// فعال‌سازی سرویس‌های مورد نیاز
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();
app.UseSession(); // فعال کردن سشن

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Account}/{action=Login}/{id?}");

app.Run();


