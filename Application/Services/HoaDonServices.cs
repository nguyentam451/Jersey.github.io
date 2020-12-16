using System.Collections.Generic;
using System.Linq;
using Application.DTOs;
using Application.Interfaces;
using Application.Mappings;
using Domain.Interfaces;

namespace Application.Services
{
    public class HoaDonServices : IHoaDonServices
    {
        public readonly IHoaDonRepository _hoaDonRepository;
        public HoaDonServices(IHoaDonRepository hoaDonRepository )
        {
            _hoaDonRepository = hoaDonRepository;
        }

          public IEnumerable<HoaDonDTO> getAll()//gọi hàm bên mapping để chuyển dữ liệu mấy hàm kia y chang, khó hiểu nhưng dễ viết
        {
           return _hoaDonRepository.getAll().MappingHoaDonDTO1();
        }


        public void CreateHoaDon(HoaDonDTO hoaDon)
        {
            throw new System.NotImplementedException();
        }

        public void DeleteHoaDon(int hoaDonId)
        {
            throw new System.NotImplementedException();
        }


        public IEnumerable<string> GetGenres()
        {
            throw new System.NotImplementedException();
        }

        public HoaDonDTO GetHoaDon(int HoaDonId)
        {
             return  _hoaDonRepository.GetHoaDon(HoaDonId).MappingHoaDonDTO();
        }

        public void UpdateHoaDon(HoaDonDTO hoaDon)
        {
            throw new System.NotImplementedException();
        }


        public void ThemHoaDon(HoaDonDTO HoaDonDTO)
        {
            _hoaDonRepository.ThemHoaDon(HoaDonDTO.MappingHoaDon());
        }

        public void SuaHoaDon(HoaDonDTO HoaDonDTO)
        {
              _hoaDonRepository.SuaHoaDon(HoaDonDTO.MappingHoaDon());
        }

        public void XoaHoaDon(HoaDonDTO HoaDonDTO)
        {
              _hoaDonRepository.XoaHoaDon(HoaDonDTO.MappingHoaDon());
        }
          public void XoaHoaDon(int id)
        {
             _hoaDonRepository.XoaHoaDon(id);
        }
    }
}