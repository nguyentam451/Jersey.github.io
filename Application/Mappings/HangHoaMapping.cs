using System.Collections.Generic;
using Application.DTOs;
using Domain.Entities;

namespace Application.Mappings
{
    public static class HangHoaMapping
    {
         public static HangHoa MappingHangHoa(this HangHoaDTO hangHoaDTO)
        {
            return new HangHoa
            {
                   Id = hangHoaDTO.Id,
                   Ten = hangHoaDTO.Ten,
                   LoaiHangHoaId = hangHoaDTO.LoaiHangHoaId,
                   DonGia = hangHoaDTO.DonGia,
                   SoLuong = hangHoaDTO.SoLuong,
                   TinhTrang = hangHoaDTO.TinhTrang,
            };
        }

           public static HangHoaDTO MappingHangHoaDTO(this HangHoa hangHoa)
        {
            return new HangHoaDTO
            {
                Id = hangHoa.Id,
                Ten = hangHoa.Ten,
                LoaiHangHoaId = hangHoa.LoaiHangHoaId,
                DonGia = hangHoa.DonGia,
                SoLuong = hangHoa.SoLuong,
                TinhTrang = hangHoa.TinhTrang,
            
            };
        }

          public static IEnumerable<HangHoaDTO> MappingHangHoaDTO1(this IEnumerable<HangHoa> hanghoas)
        {
            List<HangHoaDTO> listreturn = new List<HangHoaDTO>(); 
            foreach (var item in hanghoas)
            {
                var obnow = item.MappingHangHoaDTO();
                listreturn.Add(obnow);
            }
            return listreturn;
        }
    }
}