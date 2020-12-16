using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Application.DTOs
{
    public class KhachHangDTO
    {
        public int Id {get; set;}
        [StringLength(50)]
        public string Ten {get; set;}
         [StringLength(50)]
        public string DiaChi {get; set;}
         [StringLength(10)]
        public string DienThoai {get; set;}
        public IList<HoaDonDTO> HoaDons {get;set;} = new List<HoaDonDTO>();
    }
}