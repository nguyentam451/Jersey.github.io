using Application.Interfaces;
using Microsoft.AspNetCore.Mvc;
using mvcMovie.ViewModels;

namespace mvcMovie.Controllers
{
    public class KhachHangController : Controller
    {
          private readonly IKhachHangServices _khachHangServices;//khai báo services
          public KhachHangController (IKhachHangServices khachHangServices)
          {
              _khachHangServices = khachHangServices;
          }
        public IActionResult Index() 
        {
            var list = _khachHangServices.getAll();
            ViewBag.List = list;
            return View();
        }
          public IActionResult ThemKhachHang()
        {
            return View();
        }


        public IActionResult ThemKhachHangData(KhachHangView KhachHangView)
        {
            if(ModelState.IsValid)
            {   
                _khachHangServices.ThemKhachHang(KhachHangView.KhachHangDTO);
                 Index();
                return View(nameof(Index));
            }
            ViewBag.Error = "Thêm khách hàng thất bại";
            return View(nameof(Index));
        }
          public IActionResult SuaKhachHangData(KhachHangView KhachHangView)
        {
            ViewBag.Error = "Cập nhật thành công";
            if (ModelState.IsValid)
            {
                _khachHangServices.SuaKhachHang(KhachHangView.KhachHangDTO);
                Index();
                return View(nameof(Index));
            }
            ViewBag.Error = "Cập nhật thất bại";
            return View();
        }

        public IActionResult SuaKhachHang(int id)
        {
            ViewBag.SuaKhachHang = _khachHangServices.GetKhachHang(id);
            return View();
        }
            public IActionResult XoaKhachHang(int id)
        {
            ViewBag.XoaKhachHang = _khachHangServices.GetKhachHang(id);
            return View();
        }

         public IActionResult XoaKhachHangData(KhachHangView KhachHangView) 
        {
            _khachHangServices.XoaKhachHang(KhachHangView.KhachHangDTO);
            Index();
            return View(nameof(Index)); 

        }
         public IActionResult ThongTinKhachHang(int id)
        {
            ViewBag.ThongTinKhachHang = _khachHangServices.GetKhachHang(id);
            return View();
        }

    }
}