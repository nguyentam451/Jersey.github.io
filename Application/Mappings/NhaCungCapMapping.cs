using System.Collections.Generic;
using Application.DTOs;
using Domain.Entities;

namespace Application.Mappings
{
    public static class NhaCungCapMapping
    {
         public static NhaCungCap MappingNhaCungCap(this NhaCungCapDTO nhaCungCapDTO)
        {
            return new NhaCungCap
            {
                Id = nhaCungCapDTO.Id,
                Ten = nhaCungCapDTO.Ten,
                DiaChi = nhaCungCapDTO.DiaChi,
                DienThoai = nhaCungCapDTO.DienThoai,
            };
        }

           public static NhaCungCapDTO MappingNhaCungCapDTO(this NhaCungCap nhaCungcap)
        {
            return new NhaCungCapDTO
            {
                Id = nhaCungcap.Id,
                Ten = nhaCungcap.Ten,
                DiaChi = nhaCungcap.DiaChi,
                DienThoai = nhaCungcap.DienThoai,
               
            
            };
        }

          public static IEnumerable<NhaCungCapDTO> MappingNhaCungCapDTO1(this IEnumerable<NhaCungCap> nhacungcaps)
        {
            List<NhaCungCapDTO> listreturn = new List<NhaCungCapDTO>(); 
            foreach (var item in nhacungcaps)
            {
                var obnow = item.MappingNhaCungCapDTO();
                listreturn.Add(obnow);
            }
            return listreturn;
        }
    }
}