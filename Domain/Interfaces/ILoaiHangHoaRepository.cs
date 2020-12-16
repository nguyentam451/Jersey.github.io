using System.Collections.Generic;
using Domain.Entities;

namespace Domain.Interfaces
{
    public interface ILoaiHangHoaRepository
    {
         IEnumerable<LoaiHangHoa> getAll();
         void ThemLoaiHangHoa(LoaiHangHoa LoaiHangHoa);
         void SuaLoaiHangHoa(LoaiHangHoa LoaiHangHoa);
         void XoaLoaiHangHoa(LoaiHangHoa LoaiHangHoa);
         void XoaLoaiHangHoa(int id);
         LoaiHangHoa GetLoaiHangHoa(int LoaiHangHoaId);
    }
}