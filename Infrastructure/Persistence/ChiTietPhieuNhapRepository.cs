using System.Collections.Generic;
using System.Linq;
using Domain.Entities;
using Domain.Interfaces;

namespace Infrastructure.Persistence
{
    public class ChiTietPhieuNhapRepository : IChiTietPhieuNhapRepository
    {
         private readonly ShopLinhKienDbContext _context;
        public ChiTietPhieuNhapRepository (ShopLinhKienDbContext context)
        {
            this._context = context;
        }
        public IEnumerable<ChiTietPhieuNhap> getAll()
        {
            var listChiTietPhieuNhap = _context.ChiTietPhieuNhaps.ToList();
            return listChiTietPhieuNhap;
        }

        public ChiTietPhieuNhap GetChiTietPhieuNhap(string ChiTietPhieuNhapId)
        {
            throw new System.NotImplementedException();
        }

        public void SuaChiTietPhieuNhap(ChiTietPhieuNhap ChiTietPhieuNhap)
        {
              _context.ChiTietPhieuNhaps.Update(ChiTietPhieuNhap);
            _context.SaveChanges();
        }

        public void ThemChiTietPhieuNhap(ChiTietPhieuNhap ChiTietPhieuNhap)
        {
              _context.ChiTietPhieuNhaps.Add(ChiTietPhieuNhap);//gọi biến ChiTietPhieuNhap ở shoplinhkiencontext thêm vào database
            _context.SaveChanges();//lưu lại thay đổi
        }

        public void XoaChiTietPhieuNhap(ChiTietPhieuNhap ChiTietPhieuNhap)
        {
             _context.ChiTietPhieuNhaps.Remove(ChiTietPhieuNhap);
            _context.SaveChanges();
        }
          public void XoaChiTietPhieuNhap(int maChiTietPhieuNhap)//xóa một đối tượng ở database
        {
            
            var id = _context.ChiTietPhieuNhaps.Find(maChiTietPhieuNhap);
            _context.ChiTietPhieuNhaps.Remove(id);
            _context.SaveChanges();

        }
    }
}