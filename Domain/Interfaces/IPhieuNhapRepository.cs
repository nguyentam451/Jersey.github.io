using System.Collections.Generic;
using Domain.Entities;

namespace Domain.Interfaces
{
    public interface IPhieuNhapRepository
    {
         IEnumerable<PhieuNhap> getAll();
         void ThemPhieuNhap(PhieuNhap PhieuNhap);
         void SuaPhieuNhap(PhieuNhap PhieuNhap);
         void XoaPhieuNhap(PhieuNhap PhieuNhap);
         void XoaPhieuNhap(int id);
         PhieuNhap GetPhieuNhap(int PhieuNhapId);
    }
}