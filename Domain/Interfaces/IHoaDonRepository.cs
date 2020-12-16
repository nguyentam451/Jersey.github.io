using System.Collections.Generic;
using Domain.Entities;

namespace Domain.Interfaces
{
    public interface IHoaDonRepository
    {
         IEnumerable<HoaDon> getAll();
         void ThemHoaDon(HoaDon HoaDon);
         void SuaHoaDon(HoaDon HoaDon);
         void XoaHoaDon(HoaDon HoaDon);
         void XoaHoaDon(int id);
         HoaDon GetHoaDon(int HoaDonId);

    }
}