using System.Collections.Generic;
using Application.DTOs;
using Domain.Entities;

namespace Application.Mappings
{
    public static class TaiKhoanMapping
    {
         public static TaiKhoan MappingTaiKhoan(this TaiKhoanDTO taiKhoanDTO)
        {
            return new TaiKhoan
            {
                Id = taiKhoanDTO.Id,
                Username = taiKhoanDTO.Username,
                Password = taiKhoanDTO.Password,
                Quyen = taiKhoanDTO.Quyen,
                KhachHangId = taiKhoanDTO.KhachHangId,
                 
            };
        }

        public static TaiKhoanDTO MappingTaiKhoanDTO(this TaiKhoan taiKhoan)
        {
            return new TaiKhoanDTO
            {
               Id = taiKhoan.Id,
               Username = taiKhoan.Username,
               Password = taiKhoan.Password,
               Quyen = taiKhoan.Quyen,
               KhachHangId = taiKhoan.KhachHangId,
            
            };
        }

         public static IEnumerable<TaiKhoanDTO> MappingTaiKhoanDTO1(this IEnumerable<TaiKhoan> taikhoans)
        {
            List<TaiKhoanDTO> listreturn = new List<TaiKhoanDTO>(); 
            foreach (var taiKhoan in taikhoans)
            {
                var obnow = taiKhoan.MappingTaiKhoanDTO();
                listreturn.Add(obnow);
            }
            return listreturn;
        }
    }
}