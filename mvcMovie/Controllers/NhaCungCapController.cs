using Application.Interfaces;
using Microsoft.AspNetCore.Mvc;
using mvcMovie.ViewModels;

namespace mvcMovie.Controllers
{
    public class NhaCungCapController : Controller
    { 
          private readonly INhaCungCapServices _nhaCungCapServices;//khai báo services
          public NhaCungCapController (INhaCungCapServices nhaCungCapServices)
          {
              _nhaCungCapServices = nhaCungCapServices;
          }

        public IActionResult Index() 
        {
            var list = _nhaCungCapServices.getAll();
            ViewBag.List = list;
            return View();
        }

          public IActionResult ThemNhaCungCap()
        {
            return View();
        }


        public IActionResult ThemNhaCungCapData(NhaCungCapView NhaCungCapView)
        {
            if(ModelState.IsValid)
            {   
                _nhaCungCapServices.ThemNhaCungCap(NhaCungCapView.NhaCungCapDTO);
                 Index();
                return View(nameof(Index));
            }
            ViewBag.Error = "Thêm phiếu nhập thất bại";
            return View(nameof(Index));
        }
         public IActionResult SuaNhaCungCapData(NhaCungCapView NhaCungCapView)
        {
            ViewBag.Error = "Cập nhật thành công";
            if (ModelState.IsValid)
            {
                _nhaCungCapServices.SuaNhaCungCap(NhaCungCapView.NhaCungCapDTO);
                Index();
                return View(nameof(Index));
            }
            ViewBag.Error = "Cập nhật thất bại";
            return View();
        }

        public IActionResult SuaNhaCungCap(int id)
        {
            ViewBag.SuaNhaCungCap = _nhaCungCapServices.GetNhaCungCap(id);
            return View();
        }

             public IActionResult XoaNhaCungCap(int id)
        {
            ViewBag.XoaNhaCungCap = _nhaCungCapServices.GetNhaCungCap(id);
            return View();
        }

         public IActionResult XoaNhaCungCapData(NhaCungCapView NhaCungCapView) 
        {
            _nhaCungCapServices.XoaNhaCungCap(NhaCungCapView.NhaCungCapDTO);
            Index();
            return View(nameof(Index)); 

        }
         public IActionResult ThongTinNhaCungCap(int id)
        {
            ViewBag.ThongTinNhaCungCap = _nhaCungCapServices.GetNhaCungCap(id);
            return View();
        }


    }
}