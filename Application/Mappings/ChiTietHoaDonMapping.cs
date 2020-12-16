using System.Collections.Generic;
using Application.DTOs;
using Domain.Entities;

namespace Application.Mappings
{
    public static class ChiTietHoaDonMapping
    {
         public static ChiTietHoaDon MappingChiTietHoaDon(this ChiTietHoaDonDTO ChiTietHoaDonDTO)
        {
            return new ChiTietHoaDon
            {
               HangHoaId = ChiTietHoaDonDTO.HangHoaId,
               HoaDonId = ChiTietHoaDonDTO.HoaDonId,
               SoLuong = ChiTietHoaDonDTO.SoLuong,
               DonGia = ChiTietHoaDonDTO.DonGia,
            
            };
        }

        public static ChiTietHoaDonDTO MappingChiTietHoaDonDTO(this ChiTietHoaDon ChiTietHoaDon)
        {
            return new ChiTietHoaDonDTO
            {
               HangHoaId = ChiTietHoaDon.HangHoaId,
               HoaDonId = ChiTietHoaDon.HoaDonId,
               SoLuong = ChiTietHoaDon.SoLuong,
               DonGia = ChiTietHoaDon.DonGia,
            
            };
        }

         public static IEnumerable<ChiTietHoaDonDTO> MappingChiTietHoaDonDTO1(this IEnumerable<ChiTietHoaDon> ChiTietHoaDons)
        {
            List<ChiTietHoaDonDTO> listreturn = new List<ChiTietHoaDonDTO>(); 
            foreach (var ChiTietHoaDon in ChiTietHoaDons)
            {
                var obnow = ChiTietHoaDon.MappingChiTietHoaDonDTO();
                listreturn.Add(obnow);
            }
            return listreturn;
        }
    }
}