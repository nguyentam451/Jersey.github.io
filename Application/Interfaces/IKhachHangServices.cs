using System.Collections.Generic;
using Application.DTOs;

namespace Application.Interfaces
{
    public interface IKhachHangServices
    {
        IEnumerable<KhachHangDTO> getAll();
        KhachHangDTO GetKhachHang(int KhachHangId);
        IEnumerable<string> GetGenres();
        void ThemKhachHang(KhachHangDTO KhachHang);
        void SuaKhachHang(KhachHangDTO KhachHang);
        void XoaKhachHang(KhachHangDTO KhachHang);
        void XoaKhachHang(int id);
    }
}