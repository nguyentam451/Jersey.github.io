using System.Collections.Generic;
using Domain.Entities;

namespace Domain.Interfaces
{
    public interface IChiTietHoaDonRepository
    {
         IEnumerable<ChiTietHoaDon> getAll();
         void ThemChiTietHoaDon(ChiTietHoaDon ChiTietHoaDon);
         void SuaChiTietHoaDon(ChiTietHoaDon ChiTietHoaDon);
         void XoaChiTietHoaDon(ChiTietHoaDon ChiTietHoaDon);
         void XoaChiTietHoaDon(int id);
         ChiTietHoaDon GetChiTietHoaDon(string ChiTietHoaDonId);
    }
}