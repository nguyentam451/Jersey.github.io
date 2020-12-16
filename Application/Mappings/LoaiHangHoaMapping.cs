using System.Collections.Generic;
using Application.DTOs;
using Domain.Entities;

namespace Application.Mappings
{
    public static class LoaiHangHoaMapping
    {
         public static LoaiHangHoa MappingLoaiHangHoa(this LoaiHangHoaDTO loaiHangHoaDTO)
        {
            return new LoaiHangHoa
            {
               Id = loaiHangHoaDTO.Id,
               Ten = loaiHangHoaDTO.Ten,
            };
        }

           public static LoaiHangHoaDTO MappingLoaiHangHoaDTO(this LoaiHangHoa loaiHangHoa)
        {
            return new LoaiHangHoaDTO
            {
                Id = loaiHangHoa.Id,
                Ten = loaiHangHoa.Ten,
            
            };
        }

          public static IEnumerable<LoaiHangHoaDTO> MappingLoaiHangHoaDTO1(this IEnumerable<LoaiHangHoa> loaihanghoas)
        {
            List<LoaiHangHoaDTO> listreturn = new List<LoaiHangHoaDTO>(); 
            foreach (var item in loaihanghoas)
            {
                var obnow = item.MappingLoaiHangHoaDTO();
                listreturn.Add(obnow);
            }
            return listreturn;
        }
    }
}