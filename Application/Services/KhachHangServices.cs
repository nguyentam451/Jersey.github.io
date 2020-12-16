using System.Collections.Generic;
using Application.DTOs;
using Application.Interfaces;
using Application.Mappings;
using Domain.Interfaces;

namespace Application.Services
{
    public class KhachHangServices : IKhachHangServices
    {
        
        public readonly IKhachHangRepository _khachHangRepository;
        public KhachHangServices(IKhachHangRepository khachHangRepository )
        {
            _khachHangRepository = khachHangRepository;
        }
        public IEnumerable<KhachHangDTO> getAll()
        {
            return _khachHangRepository.getAll().MappingKhachHangDTO1();
        }

        public IEnumerable<string> GetGenres()
        {
            throw new System.NotImplementedException();
        }

        public KhachHangDTO GetKhachHang(int KhachHangId)
        {
             return  _khachHangRepository.GetKhachHang(KhachHangId).MappingKhachHangDTO();
        }

        public void SuaKhachHang(KhachHangDTO KhachHangDTO)
        {
               _khachHangRepository.SuaKhachHang(KhachHangDTO.MappingKhachHang());
        }

        public void ThemKhachHang(KhachHangDTO KhachHangDTO)
        {
           _khachHangRepository.ThemKhachHang(KhachHangDTO.MappingKhachHang());
        }

        public void XoaKhachHang(KhachHangDTO KhachHangDTO)
        {
              _khachHangRepository.XoaKhachHang(KhachHangDTO.MappingKhachHang());
        }
          public void XoaKhachHang(int id)
        {
             _khachHangRepository.XoaKhachHang(id);
        }
    }
}