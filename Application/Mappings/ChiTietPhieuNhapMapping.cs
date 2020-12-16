using System.Collections.Generic;
using Application.DTOs;
using Domain.Entities;

namespace Application.Mappings
{
    public static class ChiTietPhieuNhapMapping
    {
         public static ChiTietPhieuNhap MappingChiTietPhieuNhap(this ChiTietPhieuNhapDTO ChiTietPhieuNhapDTO)
        {
            return new ChiTietPhieuNhap
            {
               HangHoaId = ChiTietPhieuNhapDTO.HangHoaId,
               PhieuNhapId = ChiTietPhieuNhapDTO.PhieuNhapId,
               SoLuong = ChiTietPhieuNhapDTO.SoLuong,
               DonGia = ChiTietPhieuNhapDTO.DonGia,
            
            };
        }

        public static ChiTietPhieuNhapDTO MappingChiTietPhieuNhapDTO(this ChiTietPhieuNhap ChiTietPhieuNhap)
        {
            return new ChiTietPhieuNhapDTO
            {
               HangHoaId = ChiTietPhieuNhap.HangHoaId,
               PhieuNhapId = ChiTietPhieuNhap.PhieuNhapId,
               SoLuong = ChiTietPhieuNhap.SoLuong,
               DonGia = ChiTietPhieuNhap.DonGia,
            
            };
        }

         public static IEnumerable<ChiTietPhieuNhapDTO> MappingChiTietPhieuNhapDTO1(this IEnumerable<ChiTietPhieuNhap> ChiTietPhieuNhaps)
        {
            List<ChiTietPhieuNhapDTO> listreturn = new List<ChiTietPhieuNhapDTO>(); 
            foreach (var ChiTietPhieuNhap in ChiTietPhieuNhaps)
            {
                var obnow = ChiTietPhieuNhap.MappingChiTietPhieuNhapDTO();
                listreturn.Add(obnow);
            }
            return listreturn;
        }
    }
}