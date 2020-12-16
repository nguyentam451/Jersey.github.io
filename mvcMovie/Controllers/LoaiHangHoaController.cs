using Application.Interfaces;
using Microsoft.AspNetCore.Mvc;
using mvcMovie.ViewModels;

namespace mvcMovie.Controllers
{
    public class LoaiHangHoaController : Controller
    {
          private readonly ILoaiHangHoaServices _loaiHangHoaServices;//khai báo services
          public LoaiHangHoaController (ILoaiHangHoaServices loaiHangHoaServices)
          {
              _loaiHangHoaServices = loaiHangHoaServices;
          }

        public IActionResult Index() 
        {
            var list = _loaiHangHoaServices.getAll();
            ViewBag.List = list;
            return View();
        }

          public IActionResult ThemLoaiHangHoa()
        {
            return View();
        }


        public IActionResult ThemLoaiHangHoaData(LoaiHangHoaView LoaiHangHoaView)
        {
            if(ModelState.IsValid)
            {   
                _loaiHangHoaServices.ThemLoaiHangHoa(LoaiHangHoaView.LoaiHangHoaDTO);
                 Index();
                return View(nameof(Index));
            }
            ViewBag.Error = "Thêm loại hàng thất bại";
            return View(nameof(Index));
        }
          public IActionResult SuaLoaiHangHoaData(LoaiHangHoaView LoaiHangHoaView)
        {
            ViewBag.Error = "Cập nhật thành công";
            if (ModelState.IsValid)
            {
                _loaiHangHoaServices.SuaLoaiHangHoa(LoaiHangHoaView.LoaiHangHoaDTO);
                Index();
                return View(nameof(Index));
            }
            ViewBag.Error = "Cập nhật thất bại";
            return View();
        }

        public IActionResult SuaLoaiHangHoa(int id)
        {
            ViewBag.SuaLoaiHangHoa = _loaiHangHoaServices.GetLoaiHangHoa(id);
            return View();
        }

          public IActionResult XoaLoaiHangHoa(int id)
        {
            ViewBag.XoaLoaiHangHoa = _loaiHangHoaServices.GetLoaiHangHoa(id);
            return View();
        }

         public IActionResult XoaLoaiHangHoaData(LoaiHangHoaView LoaiHangHoaView) 
        {
            _loaiHangHoaServices.XoaLoaiHangHoa(LoaiHangHoaView.LoaiHangHoaDTO);
            Index();
            return View(nameof(Index)); 

        }
         public IActionResult ThongTinLoaiHangHoa(int id)
        {
            ViewBag.ThongTinLoaiHangHoa = _loaiHangHoaServices.GetLoaiHangHoa(id);
            return View();
        }

    }
}