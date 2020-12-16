using Application.Interfaces;
using Microsoft.AspNetCore.Mvc;
using mvcMovie.ViewModels;

namespace mvcMovie.Controllers
{
    public class ChiTietHoaDonController : Controller
    {

        private readonly IChiTietHoaDonServices _ChiTietHoaDonServices;

        public ChiTietHoaDonController(IChiTietHoaDonServices ChiTietHoaDonServices)
        {
            _ChiTietHoaDonServices = ChiTietHoaDonServices;
        }
        
         public IActionResult Index() 
        {
            var list = _ChiTietHoaDonServices.getAll();
            ViewBag.List = list;
            return View();
        }
          public IActionResult ThemChiTietHoaDon()
        {
            return View();
        }


        public IActionResult ThemChiTietHoaDonData(ChiTietHoaDonView ChiTietHoaDonView)
        {
            if(ModelState.IsValid)
            {   
                _ChiTietHoaDonServices.ThemChiTietHoaDon(ChiTietHoaDonView.ChiTietHoaDonDTO);
                return View(nameof(Index));
            }
            ViewBag.Error = "Thêm sản phẩm thất bại";
            return View(nameof(Index));
        }
          public IActionResult SuaChiTietHoaDonData(ChiTietHoaDonView ChiTietHoaDonView)
        {
            ViewBag.Error = "Cập nhật thành công";
            if (ModelState.IsValid)
            {
                _ChiTietHoaDonServices.SuaChiTietHoaDon(ChiTietHoaDonView.ChiTietHoaDonDTO);
                Index();
                return View(nameof(Index));
            }
            ViewBag.Error = "Cập nhật thất bại";
            return View();
        }

        public IActionResult SuaChiTietHoaDon(int id)
        {
            ViewBag.SuaChiTietHoaDon = _ChiTietHoaDonServices.GetChiTietHoaDon(id);
            return View();
        }
    }
}