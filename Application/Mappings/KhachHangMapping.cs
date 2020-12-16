using System.Collections.Generic;
using Application.DTOs;
using Domain.Entities;

namespace Application.Mappings
{
    public static class KhachHangMapping
    {
         public static KhachHang MappingKhachHang(this KhachHangDTO khachHangDTO)
        {
            return new KhachHang
            {
                Id = khachHangDTO.Id,
                Ten = khachHangDTO.Ten,
                DiaChi = khachHangDTO.DiaChi,
                DienThoai = khachHangDTO.DienThoai, 
            };
        }

           public static KhachHangDTO MappingKhachHangDTO(this KhachHang khachHang)
        {
            return new KhachHangDTO
            {
               Id = khachHang.Id,
               Ten = khachHang.Ten,
               DiaChi = khachHang.DiaChi,
               DienThoai = khachHang.DienThoai,
            
            };
        }

          public static IEnumerable<KhachHangDTO> MappingKhachHangDTO1(this IEnumerable<KhachHang> khachhangs)
        {
            List<KhachHangDTO> listreturn = new List<KhachHangDTO>(); 
            foreach (var item in khachhangs)
            {
                var obnow = item.MappingKhachHangDTO();
                listreturn.Add(obnow);
            }
            return listreturn;
        }
    }
}