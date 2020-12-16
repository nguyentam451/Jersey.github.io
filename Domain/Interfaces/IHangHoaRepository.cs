using System.Collections.Generic;
using Domain.Entities;

namespace Domain.Interfaces
{
    public interface IHangHoaRepository
    {
         IEnumerable<HangHoa> getAll();
         void ThemHangHoa(HangHoa HangHoa);
         void SuaHangHoa(HangHoa HangHoa);
         void XoaHangHoa(HangHoa HangHoa);
         void XoaHangHoa(int id);
         HangHoa GetHangHoa(int HangHoaId);
    }
}