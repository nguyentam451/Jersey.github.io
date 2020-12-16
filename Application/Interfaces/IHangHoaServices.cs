using System.Collections.Generic;
using Application.DTOs;

namespace Application.Interfaces
{
    public interface IHangHoaServices
    {
        IEnumerable<HangHoaDTO> getAll();
        HangHoaDTO GetHangHoa(int HangHoaId);
        IEnumerable<string> GetGenres();
        void ThemHangHoa(HangHoaDTO HangHoa);
        void SuaHangHoa(HangHoaDTO HangHoa);
        void XoaHangHoa(HangHoaDTO HangHoa);
        void XoaHangHoa(int id);
    }
}