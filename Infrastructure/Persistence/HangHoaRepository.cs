using System.Collections.Generic;
using System.Linq;
using Domain.Entities;
using Domain.Interfaces;

namespace Infrastructure.Persistence
{
    public class HangHoaRepository : IHangHoaRepository
    {
         private readonly ShopLinhKienDbContext _context;

        public HangHoaRepository (ShopLinhKienDbContext context)
        {
            this._context = context;
        }   
        public IEnumerable<HangHoa> getAll()
        {
           var listHoaDon = _context.HangHoas.ToList();
            return listHoaDon;
        }
         public HangHoa GetHangHoa(int HangHoaId)
        {
           return _context.HangHoas.Find(HangHoaId);
        }

        public void SuaHangHoa(HangHoa HangHoa)
        {
              _context.HangHoas.Update(HangHoa);
            _context.SaveChanges();
        }

        public void ThemHangHoa(HangHoa HangHoa)
        {
              _context.HangHoas.Add(HangHoa);//gọi biến HangHoa ở shoplinhkiencontext thêm vào database
            _context.SaveChanges();//lưu lại thay đổi
        }

        public void XoaHangHoa(HangHoa HangHoa)
        {
             _context.HangHoas.Remove(HangHoa);
            _context.SaveChanges();
        }
          public void XoaHangHoa(int maHangHoa)//xóa một đối tượng ở database
        {
            
            var id = _context.HangHoas.Find(maHangHoa);
            _context.HangHoas.Remove(id);
            _context.SaveChanges();

        }
    }
}