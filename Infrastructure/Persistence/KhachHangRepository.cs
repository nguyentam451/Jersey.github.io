using System.Collections.Generic;
using System.Linq;
using Domain.Entities;
using Domain.Interfaces;

namespace Infrastructure.Persistence
{
    public class KhachHangRepository : IKhachHangRepository
    {
        private readonly ShopLinhKienDbContext _context;
        public KhachHangRepository (ShopLinhKienDbContext context)
        {
            this._context = context;
        }   
        public IEnumerable<KhachHang> getAll()
        {
           var listHoaDon = _context.KhachHangs.ToList();
            return listHoaDon;
        }
         public KhachHang GetKhachHang(int KhachHangId)
        {
             return _context.KhachHangs.Find(KhachHangId);
        }

        public void SuaKhachHang(KhachHang KhachHang)
        {
              _context.KhachHangs.Update(KhachHang);
            _context.SaveChanges();
        }

        public void ThemKhachHang(KhachHang KhachHang)
        {
              _context.KhachHangs.Add(KhachHang);//gọi biến KhachHang ở shoplinhkiencontext thêm vào database
            _context.SaveChanges();//lưu lại thay đổi
        }

        public void XoaKhachHang(KhachHang KhachHang)
        {
            _context.KhachHangs.Remove(KhachHang);
            _context.SaveChanges();
        }
          public void XoaKhachHang(int maKhachHang)//xóa một đối tượng ở database
        {
            
            var id = _context.KhachHangs.Find(maKhachHang);
            _context.KhachHangs.Remove(id);
            _context.SaveChanges();

        }
    }
}