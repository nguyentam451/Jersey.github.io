using Application.Interfaces;
using Microsoft.AspNetCore.Mvc;
using mvcMovie.ViewModels;

namespace mvcMovie.Controllers
{
    public class ChiTietPhieuNhapController : Controller
    {
        // các bảng con sinh ra ra do n-n nó k có thuộc tính Id
        private readonly IChiTietPhieuNhapServices _ChiTietPhieuNhapServices;
        public ChiTietPhieuNhapController(IChiTietPhieuNhapServices ChiTietPhieuNhapServices)
        {
            _ChiTietPhieuNhapServices = ChiTietPhieuNhapServices;
        }
        

         public IActionResult Index() 
        {
            var list = _ChiTietPhieuNhapServices.getAll();
            ViewBag.List = list;
            return View();
        }
          public IActionResult ThemChiTietPhieuNhap()
        {
            return View();
        }


        public IActionResult ThemChiTietPhieuNhapData(ChiTietPhieuNhapView ChiTietPhieuNhapView)
        {
            if(ModelState.IsValid)
            {   
                _ChiTietPhieuNhapServices.ThemChiTietPhieuNhap(ChiTietPhieuNhapView.ChiTietPhieuNhapDTO);
                return View(nameof(Index));
            }
            ViewBag.Error = "Thêm sản phẩm thất bại";
            return View(nameof(Index));
        }
          public IActionResult SuaChiTietPhieuNhapData(ChiTietPhieuNhapView ChiTietPhieuNhapView)
        {
            ViewBag.Error = "Cập nhật thành công";
            if (ModelState.IsValid)
            {
                _ChiTietPhieuNhapServices.SuaChiTietPhieuNhap(ChiTietPhieuNhapView.ChiTietPhieuNhapDTO);
                Index();
                return View(nameof(Index));
            }
            ViewBag.Error = "Cập nhật thất bại";
            return View();
        }

        public IActionResult SuaChiTietPhieuNhap(int id)
        {
            ViewBag.SuaChiTietPhieuNhap = _ChiTietPhieuNhapServices.GetChiTietPhieuNhap(id);
            return View();
        }
    }
}