using System.Collections.Generic;
using Application.DTOs;

namespace Application.Interfaces
{
    public interface IHoaDonServices
    {
        IEnumerable<HoaDonDTO> getAll();
        HoaDonDTO GetHoaDon(int HoaDonId);
        IEnumerable<string> GetGenres();
        void ThemHoaDon(HoaDonDTO HoaDon);
        void SuaHoaDon(HoaDonDTO HoaDon);
        void XoaHoaDon(HoaDonDTO HoaDon);
        void XoaHoaDon(int id);
    }
}