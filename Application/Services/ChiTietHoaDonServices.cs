using System.Collections.Generic;
using Application.DTOs;
using Application.Interfaces;
using Application.Mappings;
using Domain.Interfaces;

namespace Application.Services
{
    public class ChiTietHoaDonServices : IChiTietHoaDonServices
    {
           public readonly IChiTietHoaDonRepository _ChiTietHoaDonRepository;
        public ChiTietHoaDonServices(IChiTietHoaDonRepository ChiTietHoaDonRepository )
        {
            _ChiTietHoaDonRepository = ChiTietHoaDonRepository;
        }
        public IEnumerable<ChiTietHoaDonDTO> getAll()
        {
            return _ChiTietHoaDonRepository.getAll().MappingChiTietHoaDonDTO1();
        }

        public IEnumerable<string> GetGenres()
        {
            throw new System.NotImplementedException();
        }

        public ChiTietHoaDonDTO GetChiTietHoaDon(int ChiTietHoaDonId)
        {
            throw new System.NotImplementedException();
        }

        public void SuaChiTietHoaDon(ChiTietHoaDonDTO ChiTietHoaDonDTO)
        {
            _ChiTietHoaDonRepository.SuaChiTietHoaDon(ChiTietHoaDonDTO.MappingChiTietHoaDon());
        }

        public void ThemChiTietHoaDon(ChiTietHoaDonDTO ChiTietHoaDonDTO)
        {
             _ChiTietHoaDonRepository.ThemChiTietHoaDon(ChiTietHoaDonDTO.MappingChiTietHoaDon());
        }

        public void XoaChiTietHoaDon(ChiTietHoaDonDTO ChiTietHoaDonDTO)
        {
              _ChiTietHoaDonRepository.XoaChiTietHoaDon(ChiTietHoaDonDTO.MappingChiTietHoaDon());
        }
          public void XoaChiTietHoaDon(int id)
        {
             _ChiTietHoaDonRepository.XoaChiTietHoaDon(id);
        }
    }
}