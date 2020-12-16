using System.Collections.Generic;
using Application.DTOs;
using Application.Interfaces;
using Application.Mappings;
using Domain.Interfaces;

namespace Application.Services
{
    public class PhieuNhapServices : IPhieuNhapServices
    {

        public readonly IPhieuNhapRepository _phieuNhapRepository;
        public PhieuNhapServices(IPhieuNhapRepository phieuNhapRepository )
        {
            _phieuNhapRepository = phieuNhapRepository;
        }
        public IEnumerable<PhieuNhapDTO> getAll()
        {
            return _phieuNhapRepository.getAll().MappingPhieuNhapDTO1();
        }

        public IEnumerable<string> GetGenres()
        {
            throw new System.NotImplementedException();
        }

        public PhieuNhapDTO GetPhieuNhap(int PhieuNhapId)
        {
              return  _phieuNhapRepository.GetPhieuNhap(PhieuNhapId).MappingPhieuNhapDTO();
        }

        public void SuaPhieuNhap(PhieuNhapDTO phieuNhapDTO)
        {
           _phieuNhapRepository.SuaPhieuNhap(phieuNhapDTO.MappingPhieuNhap());
        }

        public void ThemPhieuNhap(PhieuNhapDTO PhieuNhapDTO)
        {
            _phieuNhapRepository.ThemPhieuNhap(PhieuNhapDTO.MappingPhieuNhap());
        }

        public void XoaPhieuNhap(PhieuNhapDTO PhieuNhapDTO)
        {
             _phieuNhapRepository.XoaPhieuNhap(PhieuNhapDTO.MappingPhieuNhap());
        }
         public void XoaPhieuNhap(int id)
        {
             _phieuNhapRepository.XoaPhieuNhap(id);
        }
    }
}