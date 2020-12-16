using System.Collections.Generic;
using System.Linq;
using Domain.Entities;
using Domain.Interfaces;

namespace Infrastructure.Persistence
{
    public class NhaCungCapRepository : INhaCungCapRepository
    {
         private readonly ShopLinhKienDbContext _context;

        public NhaCungCapRepository (ShopLinhKienDbContext context)
        {
            this._context = context;
        }   
        public IEnumerable<NhaCungCap> getAll()
        {
           var listHoaDon = _context.NhaCungCaps.ToList();
            return listHoaDon;
        }
         public NhaCungCap GetNhaCungCap(int NhaCungCapId)
        {
          return _context.NhaCungCaps.Find(NhaCungCapId);
        }

        public void SuaNhaCungCap(NhaCungCap NhaCungCap)
        {
              _context.NhaCungCaps.Update(NhaCungCap);
            _context.SaveChanges();
        }

        public void ThemNhaCungCap(NhaCungCap NhaCungCap)
        {
              _context.NhaCungCaps.Add(NhaCungCap);//gọi biến NhaCungCap ở shoplinhkiencontext thêm vào database
            _context.SaveChanges();//lưu lại thay đổi
        }

        public void XoaNhaCungCap(NhaCungCap NhaCungCap)
        {
            _context.NhaCungCaps.Remove(NhaCungCap);
            _context.SaveChanges();
        }
          public void XoaNhaCungCap(int maNhaCungCap)//xóa một đối tượng ở database
        {
            
            var id = _context.NhaCungCaps.Find(maNhaCungCap);
            _context.NhaCungCaps.Remove(id);
            _context.SaveChanges();

        }
    }
}