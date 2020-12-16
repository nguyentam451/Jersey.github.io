using Application.Interfaces;
using Microsoft.AspNetCore.Mvc;
using mvcMovie.ViewModels;

namespace mvcMovie.Controllers
{
    public class PhieuNhapController : Controller
    {
        private readonly IPhieuNhapServices _phieuNhapServices;//khai báo services
        public PhieuNhapController (IPhieuNhapServices phieuNhapServices)
          {
              _phieuNhapServices = phieuNhapServices;
          }

        public IActionResult Index() 
        {
            var list = _phieuNhapServices.getAll();
            ViewBag.List = list;
            return View();
        }

          public IActionResult ThemPhieuNhap()
        {
            return View();
        }


        public IActionResult ThemPhieuNhapData(PhieuNhapView PhieuNhapView)
        {
            if(ModelState.IsValid)
            {   
                _phieuNhapServices.ThemPhieuNhap(PhieuNhapView.PhieuNhapDTO);
                 Index();
                return View(nameof(Index));
            }
            ViewBag.Error = "Thêm phiếu nhập thất bại";
            return View(nameof(Index));
        }


         public IActionResult SuaPhieuNhapData(PhieuNhapView PhieuNhapView)
        {
            ViewBag.Error = "Cập nhật thành công";
            if (ModelState.IsValid)
            {
                _phieuNhapServices.SuaPhieuNhap(PhieuNhapView.PhieuNhapDTO);
                Index();
                return View(nameof(Index));
            }
            ViewBag.Error = "Cập nhật thất bại";
            return View();
        }

        public IActionResult SuaPhieuNhap(int id)
        {
            ViewBag.SuaPhieuNhap = _phieuNhapServices.GetPhieuNhap(id);
            return View();
        }

          public IActionResult XoaPhieuNhap(int id)
        {
            ViewBag.XoaPhieuNhap = _phieuNhapServices.GetPhieuNhap(id);
            return View();
        }

         public IActionResult XoaPhieuNhapData(PhieuNhapView PhieuNhapView) 
        {
            _phieuNhapServices.XoaPhieuNhap(PhieuNhapView.PhieuNhapDTO);
            Index();
            return View(nameof(Index)); 

        }
         public IActionResult ThongTinPhieuNhap(int id)
        {
            ViewBag.ThongTinPhieuNhap = _phieuNhapServices.GetPhieuNhap(id);
            return View();
        }

    }
}