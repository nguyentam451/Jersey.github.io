using System.Collections.Generic;
using System.Linq;
using Domain.Entities;
using Domain.Interfaces;

namespace Infrastructure.Persistence
{
    public class LoaiHangHoaRepository : ILoaiHangHoaRepository
    {
         private readonly ShopLinhKienDbContext _context;

        public LoaiHangHoaRepository (ShopLinhKienDbContext context)
        {
            this._context = context;
        }   
        public IEnumerable<LoaiHangHoa> getAll()
        {
           var listHoaDon = _context.LoaiHangHoas.ToList();
            return listHoaDon;
        }
         public LoaiHangHoa GetLoaiHangHoa(int LoaiHangHoaId)
        {
             return _context.LoaiHangHoas.Find(LoaiHangHoaId);
        }

        public void SuaLoaiHangHoa(LoaiHangHoa LoaiHangHoa)
        {
               _context.LoaiHangHoas.Update(LoaiHangHoa);
            _context.SaveChanges();
        }

        public void ThemLoaiHangHoa(LoaiHangHoa LoaiHangHoa)
        {
              _context.LoaiHangHoas.Add(LoaiHangHoa);//gọi biến LoaiHangHoa ở shoplinhkiencontext thêm vào database
            _context.SaveChanges();//lưu lại thay đổi
        }

        public void XoaLoaiHangHoa(LoaiHangHoa LoaiHangHoa)
        {
             _context.LoaiHangHoas.Remove(LoaiHangHoa);
            _context.SaveChanges();
        }
          public void XoaLoaiHangHoa(int maLoaiHangHoa)//xóa một đối tượng ở database
        {
            
            var id = _context.LoaiHangHoas.Find(maLoaiHangHoa);
            _context.LoaiHangHoas.Remove(id);
            _context.SaveChanges();

        }
    }
}