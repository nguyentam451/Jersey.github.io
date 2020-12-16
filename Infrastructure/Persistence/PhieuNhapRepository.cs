using System.Collections.Generic;
using System.Linq;
using Domain.Entities;
using Domain.Interfaces;

namespace Infrastructure.Persistence
{
    public class PhieuNhapRepository : IPhieuNhapRepository
    {
        
        private readonly ShopLinhKienDbContext _context;

        public PhieuNhapRepository (ShopLinhKienDbContext context)
        {
            this._context = context;
        }   
        public IEnumerable<PhieuNhap> getAll()
        {
           var listHoaDon = _context.PhieuNhaps.ToList();
            return listHoaDon;
        }
         public PhieuNhap GetPhieuNhap(int PhieuNhapId)
        {
             return _context.PhieuNhaps.Find(PhieuNhapId);
        }

        public void SuaPhieuNhap(PhieuNhap PhieuNhap)
        {
             _context.PhieuNhaps.Update(PhieuNhap);
            _context.SaveChanges();
        }

        public void ThemPhieuNhap(PhieuNhap PhieuNhap)
        {
              _context.PhieuNhaps.Add(PhieuNhap);//gọi biến PhieuNhap ở shoplinhkiencontext thêm vào database
            _context.SaveChanges();//lưu lại thay đổi
        }

        public void XoaPhieuNhap(PhieuNhap PhieuNhap)
        {
             _context.PhieuNhaps.Remove(PhieuNhap);
            _context.SaveChanges();
        }
          public void XoaPhieuNhap(int maPhieuNhap)//xóa một đối tượng ở database
        {
            
            var id = _context.PhieuNhaps.Find(maPhieuNhap);
            _context.PhieuNhaps.Remove(id);
            _context.SaveChanges();

        }
    }
}