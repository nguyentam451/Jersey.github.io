using System.Collections.Generic;
using Application.DTOs;

namespace Application.Interfaces
{
    public interface ILoaiHangHoaServices
    {
        IEnumerable<LoaiHangHoaDTO> getAll();
        LoaiHangHoaDTO GetLoaiHangHoa(int LoaiHangHoaId);
        IEnumerable<string> GetGenres();
        void ThemLoaiHangHoa(LoaiHangHoaDTO LoaiHangHoa);
        void SuaLoaiHangHoa(LoaiHangHoaDTO LoaiHangHoa);
        void XoaLoaiHangHoa(LoaiHangHoaDTO taiKhoan);
        void XoaLoaiHangHoa(int id);

    }
}