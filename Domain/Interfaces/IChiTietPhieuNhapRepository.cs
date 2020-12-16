using System.Collections.Generic;
using Domain.Entities;

namespace Domain.Interfaces
{
    public interface IChiTietPhieuNhapRepository
    {
         IEnumerable<ChiTietPhieuNhap> getAll();
         void ThemChiTietPhieuNhap(ChiTietPhieuNhap ChiTietPhieuNhap);
         void SuaChiTietPhieuNhap(ChiTietPhieuNhap ChiTietPhieuNhap);
         void XoaChiTietPhieuNhap(ChiTietPhieuNhap ChiTietPhieuNhap);
         void XoaChiTietPhieuNhap(int id);
         ChiTietPhieuNhap GetChiTietPhieuNhap(string ChiTietPhieuNhapId);
    }
}