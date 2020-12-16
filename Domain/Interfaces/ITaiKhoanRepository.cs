using System.Collections.Generic;
using Domain.Entities;

namespace Domain.Interfaces
{
    public interface ITaiKhoanRepository
    {
         IEnumerable<TaiKhoan> getAll();
         void ThemTaiKhoan(TaiKhoan taiKhoan);
         void SuaTaiKhoan(TaiKhoan taiKhoan);
         void XoaTaiKhoan(TaiKhoan taiKhoan);
         void XoaTaiKhoan(int id);

         TaiKhoan GetTaiKhoan(int taiKhoanId);
     
    }
}