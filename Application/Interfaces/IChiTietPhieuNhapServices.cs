using System.Collections.Generic;
using Application.DTOs;

namespace Application.Interfaces
{
    public interface IChiTietPhieuNhapServices
    {
        IEnumerable<ChiTietPhieuNhapDTO> getAll();
        ChiTietPhieuNhapDTO GetChiTietPhieuNhap(int ChiTietPhieuNhapId);
        IEnumerable<string> GetGenres();
        void ThemChiTietPhieuNhap(ChiTietPhieuNhapDTO ChiTietPhieuNhap);
        void SuaChiTietPhieuNhap(ChiTietPhieuNhapDTO ChiTietPhieuNhap);
        void XoaChiTietPhieuNhap(ChiTietPhieuNhapDTO ChiTietPhieuNhap);
    }
}