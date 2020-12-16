using System.Collections.Generic;
using Domain.Entities;

namespace Domain.Interfaces
{
    public interface IKhachHangRepository
    {
         IEnumerable<KhachHang> getAll();
         void ThemKhachHang(KhachHang KhachHang);
         void SuaKhachHang(KhachHang KhachHang);
         void XoaKhachHang(KhachHang KhachHang);
         void XoaKhachHang(int id);
         KhachHang GetKhachHang(int KhachHangId);
    }
}