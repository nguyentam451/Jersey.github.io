using System.Collections.Generic;
using Application.DTOs;
using Application.Interfaces;
using Application.Mappings;
using Domain.Interfaces;

namespace Application.Services
{
    public class HangHoaServices : IHangHoaServices
    {
        
        public readonly IHangHoaRepository _hangHoaRepository;
        public HangHoaServices(IHangHoaRepository hangHoaRepository )
        {
            _hangHoaRepository = hangHoaRepository;
        }
        public IEnumerable<HangHoaDTO> getAll()
        {
            return _hangHoaRepository.getAll().MappingHangHoaDTO1();
        }

        public IEnumerable<string> GetGenres()
        {
            throw new System.NotImplementedException();
        }

        public HangHoaDTO GetHangHoa(int HangHoaId)
        {
             return  _hangHoaRepository.GetHangHoa(HangHoaId).MappingHangHoaDTO();
        }

        public void SuaHangHoa(HangHoaDTO HangHoaDTO)
        {
               _hangHoaRepository.SuaHangHoa(HangHoaDTO.MappingHangHoa());
        }

        public void ThemHangHoa(HangHoaDTO HangHoaDTO)
        {
             _hangHoaRepository.ThemHangHoa(HangHoaDTO.MappingHangHoa());
        }

        public void XoaHangHoa(HangHoaDTO HangHoaDTO)
        {
              _hangHoaRepository.XoaHangHoa(HangHoaDTO.MappingHangHoa());
        }
          public void XoaHangHoa(int id)
        {
             _hangHoaRepository.XoaHangHoa(id);
        }
    }
}