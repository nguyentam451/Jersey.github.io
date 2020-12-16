using System.Collections.Generic;
using System.Linq;
using Domain.Entities;
using Domain.Interfaces;

namespace Infrastructure.Persistence
{
    public class ChiTietHoaDonRepository : IChiTietHoaDonRepository
    {
         private readonly ShopLinhKienDbContext _context;
        public ChiTietHoaDonRepository (ShopLinhKienDbContext context)
        {
            this._context = context;
        }
        public IEnumerable<ChiTietHoaDon> getAll()
        {
            var listChiTietHoaDon = _context.ChiTietHoaDons.ToList();
            return listChiTietHoaDon;
        }

        public ChiTietHoaDon GetChiTietHoaDon(string ChiTietHoaDonId)
        {
            throw new System.NotImplementedException();
        }

        public void SuaChiTietHoaDon(ChiTietHoaDon ChiTietHoaDon)
        {
               _context.ChiTietHoaDons.Update(ChiTietHoaDon);
            _context.SaveChanges();
        }

        public void ThemChiTietHoaDon(ChiTietHoaDon ChiTietHoaDon)
        {
              _context.ChiTietHoaDons.Add(ChiTietHoaDon);//gọi biến ChiTietHoaDon ở shoplinhkiencontext thêm vào database
            _context.SaveChanges();//lưu lại thay đổi
        }

        public void XoaChiTietHoaDon(ChiTietHoaDon ChiTietHoaDon)
        {
             _context.ChiTietHoaDons.Remove(ChiTietHoaDon);
            _context.SaveChanges();
        }
          public void XoaChiTietHoaDon(int maChiTietHoaDon)//xóa một đối tượng ở database
        {
            
            var id = _context.ChiTietHoaDons.Find(maChiTietHoaDon);
            _context.ChiTietHoaDons.Remove(id);
            _context.SaveChanges();

        }
    }
}