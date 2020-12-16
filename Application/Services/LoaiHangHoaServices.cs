using System.Collections.Generic;
using Application.DTOs;
using Application.Interfaces;
using Application.Mappings;
using Domain.Interfaces;

namespace Application.Services
{
    public class LoaiHangHoaServices : ILoaiHangHoaServices
    {
        
        public readonly ILoaiHangHoaRepository _loaiHangHoaRepository;
        public LoaiHangHoaServices(ILoaiHangHoaRepository loaiHangHoaRepository )
        {
            _loaiHangHoaRepository = loaiHangHoaRepository;
        }
        public IEnumerable<LoaiHangHoaDTO> getAll()
        {
            return _loaiHangHoaRepository.getAll().MappingLoaiHangHoaDTO1();
        }

        public IEnumerable<string> GetGenres()
        {
            throw new System.NotImplementedException();
        }

        public LoaiHangHoaDTO GetLoaiHangHoa(int LoaiHangHoaId)
        {
              return  _loaiHangHoaRepository.GetLoaiHangHoa(LoaiHangHoaId).MappingLoaiHangHoaDTO();
        }

        public void SuaLoaiHangHoa(LoaiHangHoaDTO LoaiHangHoaDTO)
        {
              _loaiHangHoaRepository.SuaLoaiHangHoa(LoaiHangHoaDTO.MappingLoaiHangHoa());
        }

        public void ThemLoaiHangHoa(LoaiHangHoaDTO LoaiHangHoaDTO)
        {
            _loaiHangHoaRepository.ThemLoaiHangHoa(LoaiHangHoaDTO.MappingLoaiHangHoa());
        }

        public void XoaLoaiHangHoa(LoaiHangHoaDTO LoaiHangHoaDTO)
        {
             _loaiHangHoaRepository.XoaLoaiHangHoa(LoaiHangHoaDTO.MappingLoaiHangHoa());
        }
          public void XoaLoaiHangHoa(int id)
        {
             _loaiHangHoaRepository.XoaLoaiHangHoa(id);
        }
    }
}