using System.Collections.Generic;
using Application.DTOs;
using Application.Interfaces;
using Application.Mappings;
using Domain.Interfaces;

namespace Application.Services
{
    public class NhaCungCapServices : INhaCungCapServices
    {
        
        public readonly INhaCungCapRepository _nhaCungCapRepository;
        public NhaCungCapServices(INhaCungCapRepository nhaCungCapRepository )
        {
            _nhaCungCapRepository = nhaCungCapRepository;
        }
        public IEnumerable<NhaCungCapDTO> getAll()
        {
            return _nhaCungCapRepository.getAll().MappingNhaCungCapDTO1();
        }

        public IEnumerable<string> GetGenres()
        {
            throw new System.NotImplementedException();
        }

        public NhaCungCapDTO GetNhaCungCap(int NhaCungCapId)
        {
              return  _nhaCungCapRepository.GetNhaCungCap(NhaCungCapId).MappingNhaCungCapDTO();
        }

        public void SuaNhaCungCap(NhaCungCapDTO NhaCungCapDTO)
        {
              _nhaCungCapRepository.SuaNhaCungCap(NhaCungCapDTO.MappingNhaCungCap());
        }

        public void ThemNhaCungCap(NhaCungCapDTO NhaCungCapDTO)
        {
            _nhaCungCapRepository.ThemNhaCungCap(NhaCungCapDTO.MappingNhaCungCap());
        }

        public void XoaNhaCungCap(NhaCungCapDTO NhaCungCapDTO)
        {
              _nhaCungCapRepository.XoaNhaCungCap(NhaCungCapDTO.MappingNhaCungCap());
        }
          public void XoaNhaCungCap(int id)
        {
             _nhaCungCapRepository.XoaNhaCungCap(id);
        }
    }
}