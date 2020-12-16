using System.Collections.Generic;
using Application.DTOs;

namespace Application.Interfaces
{
    public interface INhaCungCapServices
    {
        IEnumerable<NhaCungCapDTO> getAll();
        NhaCungCapDTO GetNhaCungCap(int NhaCungCapId);
        IEnumerable<string> GetGenres();
        void ThemNhaCungCap(NhaCungCapDTO NhaCungCap);
        void SuaNhaCungCap(NhaCungCapDTO NhaCungCap);
        void XoaNhaCungCap(NhaCungCapDTO NhaCungCap);
        void XoaNhaCungCap(int id);
    }
}