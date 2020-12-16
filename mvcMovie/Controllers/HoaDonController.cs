using Application.Interfaces;
using Microsoft.AspNetCore.Mvc;
using mvcMovie.ViewModels;

namespace mvcMovie.Controllers
{
    public class HoaDonController : Controller
    {
          private readonly IHoaDonServices _hoaDonServices;//khai báo services
          public HoaDonController (IHoaDonServices hoaDonServices)
          {
              _hoaDonServices = hoaDonServices;
          }

        public IActionResult Index() 
        {
            var list = _hoaDonServices.getAll();
            ViewBag.List = list;
            return View();
        }

          public IActionResult ThemHoaDon()
        {
            return View();
        }


        public IActionResult ThemHoaDonData(HoaDonView HoaDonView)
        {
            if(ModelState.IsValid)
            {   
                _hoaDonServices.ThemHoaDon(HoaDonView.HoaDonDTO);
                 Index();
                return View(nameof(Index));
            }
            ViewBag.Error = "Thêm hóa đơn thất bại";
            return View(nameof(Index));
        }

          public IActionResult SuaHoaDonData(HoaDonView HoaDonView)
        {
            ViewBag.Error = "Cập nhật thành công";
            if (ModelState.IsValid)
            {
                _hoaDonServices.SuaHoaDon(HoaDonView.HoaDonDTO);
                Index();
                return View(nameof(Index));
            }
            ViewBag.Error = "Cập nhật thất bại";
            return View();
        }

        public IActionResult SuaHoaDon(int id)
        {
            ViewBag.SuaHoaDon = _hoaDonServices.GetHoaDon(id);
            return View();
        }
            public IActionResult XoaHoaDon(int id)
        {
            ViewBag.XoaHoaDon = _hoaDonServices.GetHoaDon(id);
            return View();
        }

         public IActionResult XoaHoaDonData(HoaDonView HoaDonView) 
        {
            _hoaDonServices.XoaHoaDon(HoaDonView.HoaDonDTO);
            Index();
            return View(nameof(Index)); 

        }
         public IActionResult ThongTinHoaDon(int id)
        {
            ViewBag.ThongTinHoaDon = _hoaDonServices.GetHoaDon(id);
            return View();
        }


    }
}