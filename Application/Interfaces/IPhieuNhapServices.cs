using System.Collections.Generic;
using Application.DTOs;

namespace Application.Interfaces
{
    public interface IPhieuNhapServices
    {
        IEnumerable<PhieuNhapDTO> getAll();
        PhieuNhapDTO GetPhieuNhap(int PhieuNhapId);
        IEnumerable<string> GetGenres();
        void ThemPhieuNhap(PhieuNhapDTO PhieuNhap);
        void SuaPhieuNhap(PhieuNhapDTO PhieuNhap);
        void XoaPhieuNhap(PhieuNhapDTO PhieuNhap);
         void XoaPhieuNhap(int id);
    }
}