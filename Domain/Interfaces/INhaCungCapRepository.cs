using System.Collections.Generic;
using Domain.Entities;

namespace Domain.Interfaces
{
    public interface INhaCungCapRepository
    {
         IEnumerable<NhaCungCap> getAll();
         void ThemNhaCungCap(NhaCungCap NhaCungCap);
         void SuaNhaCungCap(NhaCungCap NhaCungCap);
         void XoaNhaCungCap(NhaCungCap NhaCungCap);
         void XoaNhaCungCap(int id);
         NhaCungCap GetNhaCungCap(int NhaCungCapId);
    }
}