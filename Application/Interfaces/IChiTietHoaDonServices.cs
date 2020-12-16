using System.Collections.Generic;
using Application.DTOs;

namespace Application.Interfaces
{
    public interface IChiTietHoaDonServices
    {
        IEnumerable<ChiTietHoaDonDTO> getAll();
        ChiTietHoaDonDTO GetChiTietHoaDon(int ChiTietHoaDonId);
        IEnumerable<string> GetGenres();
        void ThemChiTietHoaDon(ChiTietHoaDonDTO ChiTietHoaDon);
        void SuaChiTietHoaDon(ChiTietHoaDonDTO ChiTietHoaDon);
        void XoaChiTietHoaDon(ChiTietHoaDonDTO ChiTietHoaDon);
    }
}