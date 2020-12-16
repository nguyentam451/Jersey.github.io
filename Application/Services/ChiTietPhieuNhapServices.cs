using System.Collections.Generic;
using Application.DTOs;
using Application.Interfaces;
using Application.Mappings;
using Domain.Interfaces;

namespace Application.Services
{
    public class ChiTietPhieuNhapServices : IChiTietPhieuNhapServices
    {
         public readonly IChiTietPhieuNhapRepository _ChiTietPhieuNhapRepository;
        public ChiTietPhieuNhapServices(IChiTietPhieuNhapRepository ChiTietPhieuNhapRepository )
        {
            _ChiTietPhieuNhapRepository = ChiTietPhieuNhapRepository;
        }
        public IEnumerable<ChiTietPhieuNhapDTO> getAll()
        {
            return _ChiTietPhieuNhapRepository.getAll().MappingChiTietPhieuNhapDTO1();
        }

        public IEnumerable<string> GetGenres()
        {
            throw new System.NotImplementedException();
        }

        public ChiTietPhieuNhapDTO GetChiTietPhieuNhap(int ChiTietPhieuNhapId)
        {
            throw new System.NotImplementedException();
        }

        public void SuaChiTietPhieuNhap(ChiTietPhieuNhapDTO ChiTietPhieuNhapDTO)
        {
           _ChiTietPhieuNhapRepository.SuaChiTietPhieuNhap(ChiTietPhieuNhapDTO.MappingChiTietPhieuNhap());
        }

        public void ThemChiTietPhieuNhap(ChiTietPhieuNhapDTO ChiTietPhieuNhapDTO)
        {
             _ChiTietPhieuNhapRepository.ThemChiTietPhieuNhap(ChiTietPhieuNhapDTO.MappingChiTietPhieuNhap());
        }

        public void XoaChiTietPhieuNhap(ChiTietPhieuNhapDTO ChiTietPhieuNhapDTO)
        {
              _ChiTietPhieuNhapRepository.XoaChiTietPhieuNhap(ChiTietPhieuNhapDTO.MappingChiTietPhieuNhap());
        }
          public void XoaChiTietPhieuNhap(int id)
        {
             _ChiTietPhieuNhapRepository.XoaChiTietPhieuNhap(id);
        }
    }
}