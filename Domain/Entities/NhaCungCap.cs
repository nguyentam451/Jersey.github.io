using System.Collections.Generic;

namespace Domain.Entities
{
    public class NhaCungCap
    {
        public int Id {get; set;}
        public string Ten {get; set;}
        public string DiaChi {get; set;}
        public string DienThoai {get; set;}
        public IList<PhieuNhap> PhieuNhaps {get;set;} = new List<PhieuNhap>();
    }
}