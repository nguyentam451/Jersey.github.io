using Application.Interfaces;
using Microsoft.AspNetCore.Mvc;
using mvcMovie.ViewModels;

namespace mvcMovie.Controllers
{
    public class HangHoaController : Controller
    {
         private readonly IHangHoaServices _hangHoaServices;//khai báo services
          public HangHoaController (IHangHoaServices hangHoaServices)
          {
              _hangHoaServices = hangHoaServices;
          }

        public IActionResult Index() 
        {
            var list = _hangHoaServices.getAll();
            ViewBag.List = list;
            return View();
        }
        public IActionResult Create()
        {
            return View();
        }
        public IActionResult Details()
        {
            return View();
        }
          public IActionResult ThemHangHoa()
        {
            return View();
        }


        public IActionResult ThemHangHoaData(HangHoaView HangHoaView)
        {
            if(ModelState.IsValid)
            {   
                _hangHoaServices.ThemHangHoa(HangHoaView.HangHoaDTO);
                 Index();
                return View(nameof(Index));
            }
            ViewBag.Error = "Thêm hàng hóa thất bại";
            return View(nameof(Index));
        }

          public IActionResult SuaHangHoaData(HangHoaView HangHoaView)
        {
            ViewBag.Error = "Cập nhật thành công";
            if (ModelState.IsValid)
            {
                _hangHoaServices.SuaHangHoa(HangHoaView.HangHoaDTO);
                Index();
                return View(nameof(Index));
            }
            ViewBag.Error = "Cập nhật thất bại";
            return View();
        }

        public IActionResult SuaHangHoa(int id)
        {
            ViewBag.SuaHangHoa = _hangHoaServices.GetHangHoa(id);
            return View();
        }

            public IActionResult XoaHangHoa(int id)
        {
            ViewBag.XoaHangHoa = _hangHoaServices.GetHangHoa(id);
            return View();
        }

         public IActionResult XoaHangHoaData(HangHoaView HangHoaView) 
        {
            _hangHoaServices.XoaHangHoa(HangHoaView.HangHoaDTO);
            Index();
            return View(nameof(Index)); 

        }
         public IActionResult ThongTinHangHoa(int id)
        {
            ViewBag.ThongTinHangHoa = _hangHoaServices.GetHangHoa(id);
            return View();
        }

    }
}