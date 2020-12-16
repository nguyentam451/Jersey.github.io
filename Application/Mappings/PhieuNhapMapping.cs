using System.Collections.Generic;
using Application.DTOs;
using Domain.Entities;

namespace Application.Mappings
{
    public static class PhieuNhapMapping
    {
          public static PhieuNhap MappingPhieuNhap(this PhieuNhapDTO phieuNhapDTO)
        {
            return new PhieuNhap
            {
                Id = phieuNhapDTO.Id,
                Ten = phieuNhapDTO.Ten,
                NgayNhap = phieuNhapDTO.NgayNhap,
                NhaCungCapId = phieuNhapDTO.NhaCungCapId,   
            };
        }
           public static PhieuNhapDTO MappingPhieuNhapDTO(this PhieuNhap phieuNhap)
        {
            return new PhieuNhapDTO
            {
                Id = phieuNhap.Id,
                Ten = phieuNhap.Ten,
                NgayNhap = phieuNhap.NgayNhap,
                NhaCungCapId = phieuNhap.NhaCungCapId, 
            
            };
        }

          public static IEnumerable<PhieuNhapDTO> MappingPhieuNhapDTO1(this IEnumerable<PhieuNhap> phieunhaps)
        {
            List<PhieuNhapDTO> listreturn = new List<PhieuNhapDTO>(); 
            foreach (var item in phieunhaps)
            {
                var obnow = item.MappingPhieuNhapDTO();
                listreturn.Add(obnow);
            }
            return listreturn;
        }
        
    }
}