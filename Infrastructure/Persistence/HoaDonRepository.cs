using System.Collections.Generic;
using System.Linq;
using Domain.Entities;
using Domain.Interfaces;

namespace Infrastructure.Persistence
{
    public class HoaDonRepository : IHoaDonRepository
    {
        private readonly ShopLinhKienDbContext _context;

        public HoaDonRepository (ShopLinhKienDbContext context)
        {
            this._context = context;
        }   
        public IEnumerable<HoaDon> getAll()
        {
           var listHoaDon = _context.HoaDons.ToList();
            return listHoaDon;
        }
         public HoaDon GetHoaDon(int HoaDonId)
        {
            return _context.HoaDons.Find(HoaDonId);
        }

        public void SuaHoaDon(HoaDon HoaDon)
        {
               _context.HoaDons.Update(HoaDon);
            _context.SaveChanges();
        }

        public void ThemHoaDon(HoaDon HoaDon)
        {
              _context.HoaDons.Add(HoaDon);//gọi biến HoaDon ở shoplinhkiencontext thêm vào database
            _context.SaveChanges();//lưu lại thay đổi
        }

        public void XoaHoaDon(HoaDon HoaDon)
        {
             _context.HoaDons.Remove(HoaDon);
            _context.SaveChanges();
        }
          public void XoaHoaDon(int maHoaDon)//xóa một đối tượng ở database
        {
            
            var id = _context.HoaDons.Find(maHoaDon);
            _context.HoaDons.Remove(id);
            _context.SaveChanges();

        }
    }
}