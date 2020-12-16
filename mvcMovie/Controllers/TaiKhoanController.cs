using Microsoft.AspNetCore.Mvc;
using Application.Interfaces;
using Infrastructure.Persistence;
using mvcMovie.ViewModels;
using mvcMovie.SaveModels;
using Application.DTOs;

namespace mvcMovie.Controllers
{
    public class TaiKhoanController : Controller
    {
         private readonly ITaiKhoanServices _taiKhoanServices;//khai báo services
        
         private readonly IKhachHangServices _khachHangServices;
         
       //  private readonly ShopLinhKienDbContext _context;
        //nay chay co bi cai do k
        public TaiKhoanController (ITaiKhoanServices taiKhoanServices,IKhachHangServices khachHangServices)
        {
            _taiKhoanServices = taiKhoanServices;
            _khachHangServices = khachHangServices;
        }
    
         public IActionResult Index()   // nếu mà em để cái dòng này  private readonly ShopLinhKienDbContext _context; thì chạy được
         // còn làm theo của bạn k chạy dc a
        {
            var list = _taiKhoanServices.getAll();//hàm lấy tất cả các đối tượng ở dưới database để show thông tin sản phẩm lên
            ViewBag.List = list;//lưu danh sách vừa lấy được vào viewbag đê show ra bên index
            return View();
        }

        public IActionResult ThemTaiKhoan()
        {
            return View();
        }


        public IActionResult ThemTaiKhoanData(TaiKhoanSaveModel taiKhoanSaveModel) 
        {
            //Cai nay la cai dau tien em them xoa sua ha dung roi anh oi 
            // luc do em chua them cai form nay
            // luc do chi la user name voi password
            if(ModelState.IsValid)//kiểm tra dữ liệu đã được post đúng hay chưa
            {   
                // var view = new KhachHangView();
                var khachHang = new KhachHangDTO {
                    Ten = taiKhoanSaveModel.Ten,
                    DiaChi = taiKhoanSaveModel.DiaChi,
                    DienThoai = taiKhoanSaveModel.DienThoai,
                };
                _khachHangServices.ThemKhachHang(khachHang);
                //Do them vo thi ko có the nào cap nhật th khachHang có id cả, h id nó đg là 0
                //Em làm phần khác đi h sửa phải sửa từ repository nữa 
                // a vay chac e bo phan nay
                // a sua giup em cai cho ngay thang
                var taiKhoan = new TaiKhoanDTO {
                    KhachHangId = khachHang.Id,
                    Password = taiKhoanSaveModel.Password,
                    Username = taiKhoanSaveModel.Username,
                    Quyen = taiKhoanSaveModel.Quyen,
                };
                // taiKhoanView.TaiKhoanDTO.KhachHangId = taiKhoanView.KhachHangDTO.Id; // gán id khách hàng băngf KhachHangID
                _taiKhoanServices.ThemTaiKhoan(taiKhoan);
                 Index();//cập nhật xong load lại trang index
                return View(nameof(Index));//return view là trả về view nhưng không chạy những gì trong đó
                                            //còn redirecttoaction là thực hiện trong index rồi mới trả về view
            }
            ViewBag.Error = "Thêm tài khoản thất bại";
            return View(nameof(Index));
        }

         public IActionResult SuaTaiKhoanData(TaiKhoanView TaiKhoanView)//Cập nhật một đối tượng xuống database
        {
            ViewBag.Error = "Cập nhật thành công";
            if (ModelState.IsValid)//kiểm tra xem đã có dữ liệu truyền trên url hay chưa
            {
                _taiKhoanServices.SuaTaiKhoan(TaiKhoanView.TaiKhoanDTO);//gọi hàm sửa ở services
                Index();//cập nhật xong load lại trang index
                return View(nameof(Index));//quay về trang index
            }
            ViewBag.Error = "Cập nhật thất bại";
            return View();
        }

        public IActionResult SuaTaiKhoan(int id)//truyền mã vào để sửa, mục đích là để khi bấm nút sửa dựa vào mã ở
            //giao diện QuanLiTaiKhoan/Index truy xuất xuống services/reponsitory để lấy đối tượng thương hiệu lên và gán dữ liệu cho trang SuaTaiKhoan

        {
            ViewBag.SuaTaiKhoan = _taiKhoanServices.GetTaiKhoan(id);//gọi hàm lấy một đối tượng thương hiệu bên services và gán cho viewbag
            return View();
        }
        
        public IActionResult XoaTaiKhoan(int id)
        {
            ViewBag.XoaTaiKhoan = _taiKhoanServices.GetTaiKhoan(id);
            return View();
        }

         public IActionResult XoaTaiKhoanData(TaiKhoanView TaiKhoanView) //truyền mã vào để xóa một đối tượng
        {
            _taiKhoanServices.XoaTaiKhoan(TaiKhoanView.TaiKhoanDTO);//gọi hàm xóa bên services
            Index();//chạy lại hàm index và các dòng trong index, mục đích là để xóa xong nó load lại trang luôn
            return View(nameof(Index)); // trả về view

        }
         public IActionResult ThongTinTaiKhoan(int id)
        {
            ViewBag.ThongTinTaiKhoan = _taiKhoanServices.GetTaiKhoan(id);
            return View();
        }

    }
}