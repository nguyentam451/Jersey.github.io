using System.Collections.Generic;
using System.Linq;
using Application.DTOs;
using Application.Interfaces;
using Application.Mappings;
using Domain.Interfaces;

namespace Application.Services
{
    public class TaiKhoanServices : ITaiKhoanServices
    {
         public readonly ITaiKhoanRepository _taiKhoanRepository;

        public TaiKhoanServices(ITaiKhoanRepository taiKhoanRepository)
        {
            _taiKhoanRepository = taiKhoanRepository;
            //_httpContext = httpContextAccessor.HttpContext;
        }

         public IEnumerable<TaiKhoanDTO> getAll()//gọi hàm bên mapping để chuyển dữ liệu mấy hàm kia y chang, khó hiểu nhưng dễ viết
        {
           return _taiKhoanRepository.getAll().MappingTaiKhoanDTO1();
        }

        public void ThemTaiKhoan(TaiKhoanDTO taiKhoanDTO)
        {
           _taiKhoanRepository.ThemTaiKhoan(taiKhoanDTO.MappingTaiKhoan());
        }

        public void XoaTaiKhoan(TaiKhoanDTO TaiKhoanDTO)
        {
             _taiKhoanRepository.XoaTaiKhoan(TaiKhoanDTO.MappingTaiKhoan());
        }

        public void XoaTaiKhoan(int id)
        {
             _taiKhoanRepository.XoaTaiKhoan(id);
        }
        public IEnumerable<string> GetGenres()
        {
            throw new System.NotImplementedException();
        }

        public TaiKhoanDTO GetTaiKhoan(int taiKhoanId)
        {
           return  _taiKhoanRepository.GetTaiKhoan(taiKhoanId).MappingTaiKhoanDTO();

        }

        public void SuaTaiKhoan(TaiKhoanDTO taiKhoanDTO)
        {
             _taiKhoanRepository.SuaTaiKhoan(taiKhoanDTO.MappingTaiKhoan());
        }
    }
}