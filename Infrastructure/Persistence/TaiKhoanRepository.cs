using System.Collections.Generic;
using System.Linq;
using Domain.Entities;
using Domain.Interfaces;

namespace Infrastructure.Persistence
{
    public class TaiKhoanRepository : ITaiKhoanRepository
    {
        private readonly ShopLinhKienDbContext _context;
        public TaiKhoanRepository (ShopLinhKienDbContext context)
        {
            this._context = context;
        }
        public IEnumerable<TaiKhoan> getAll()
        {
            var listTaiKhoan = _context.TaiKhoans.ToList();
            return listTaiKhoan;
        }

        public TaiKhoan GetTaiKhoan(int taiKhoanId)
        {
             return _context.TaiKhoans.Find(taiKhoanId);
        }

        public void SuaTaiKhoan(TaiKhoan taiKhoan)
        {
              _context.TaiKhoans.Update(taiKhoan);
            _context.SaveChanges();
        }

        public void ThemTaiKhoan(TaiKhoan taiKhoan)
        {
              _context.TaiKhoans.Add(taiKhoan);//gọi biến taikhoan ở shoplinhkiencontext thêm vào database
            _context.SaveChanges();//lưu lại thay đổi
        }

        public void XoaTaiKhoan(TaiKhoan taiKhoan)
        {
            _context.TaiKhoans.Remove(taiKhoan);
            _context.SaveChanges();
        }
        public void XoaTaiKhoan(int maTaiKhoan)//xóa một đối tượng ở database
        {
            
            var id = _context.TaiKhoans.Find(maTaiKhoan);
            _context.TaiKhoans.Remove(id);
            _context.SaveChanges();

        }
    }
}