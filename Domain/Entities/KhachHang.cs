using System.Collections.Generic;

namespace Domain.Entities
{
    public class KhachHang
    {
        public int Id {get; set;}
        public string Ten {get; set;}
        public string DiaChi {get; set;}
        public string DienThoai {get; set;}
        public IList<HoaDon> HoaDons {get;set;} = new List<HoaDon>();
    }
}