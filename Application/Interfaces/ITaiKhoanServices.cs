using System.Collections.Generic;
using Application.DTOs;

namespace Application.Interfaces
{
    public interface ITaiKhoanServices
    {
        IEnumerable<TaiKhoanDTO> getAll();
        TaiKhoanDTO GetTaiKhoan(int TaiKhoanId);
        IEnumerable<string> GetGenres();
        void ThemTaiKhoan(TaiKhoanDTO taiKhoan);
        void SuaTaiKhoan(TaiKhoanDTO taiKhoan);
        void XoaTaiKhoan(TaiKhoanDTO taiKhoan);
        void XoaTaiKhoan(int id);
    }
}