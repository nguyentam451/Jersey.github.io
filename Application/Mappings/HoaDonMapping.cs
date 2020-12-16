using System.Collections.Generic;
using Application.DTOs;
using Domain.Entities;

namespace Application.Mappings
{
    public static class HoaDonMapping
    {
         public static HoaDon MappingHoaDon(this HoaDonDTO hoaDonDTO)
        {
            return new HoaDon
            {
                Id = hoaDonDTO.Id,
                NgayLap = hoaDonDTO.NgayLap,
                KhachHangId = hoaDonDTO.KhachHangId,     
            };
        }

           public static HoaDonDTO MappingHoaDonDTO(this HoaDon hoaDon)
        {
            return new HoaDonDTO
            {
                Id = hoaDon.Id,
                NgayLap = hoaDon.NgayLap,
                KhachHangId = hoaDon.KhachHangId,
            
            };
        }

          public static IEnumerable<HoaDonDTO> MappingHoaDonDTO1(this IEnumerable<HoaDon> hoadons)
        {
            List<HoaDonDTO> listreturn = new List<HoaDonDTO>(); 
            foreach (var item in hoadons)
            {
                var obnow = item.MappingHoaDonDTO();
                listreturn.Add(obnow);
            }
            return listreturn;
        }
    }
}