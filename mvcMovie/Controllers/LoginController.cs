using System;
using System.Linq;
using System.Threading.Tasks;
using Domain.Entities;
using Infrastructure.Persistence;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace mvcMovie.Controllers
{
    public class LoginController : Controller
    {
        private readonly ShopLinhKienDbContext _context;

         public LoginController(ShopLinhKienDbContext context)
            {
                _context = context;
            }

        [HttpGet]
        public IActionResult Index()
            {
                return View();
            }

        
        [HttpPost]
        public IActionResult Index(TaiKhoan taiKhoan)
        {
            //  var ds = from m in _context.TaiKhoan
            //      select m;
            //   if (!string.IsNullOrEmpty(search))
            //   {
                //  ds = ds.Where(s => s.Username.Contains(search));
                //  Console.WriteLine(ds.Username);
        
            var validUser = _context.TaiKhoans.Where(tk => tk.Password == taiKhoan.Password 
                                    && tk.Username == taiKhoan.Username && tk.Quyen == "admin").FirstOrDefault();
            if(validUser != null) return RedirectToAction("Index","Home");

            //Em lên mạng coi theme cách sửa lỗi nha
            //Anh quen viết theo kiểu kia r
            // a ví dụ cho e luôn cái khóa n-n luôn với 
            // database cua e ne
            return View(taiKhoan);
        }

        public IActionResult Logout()
        {
            return RedirectToAction("Index","Login");
        }

    }
}