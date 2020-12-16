using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Application.DTOs
{
    public class NhaCungCapDTO
    {
        public int Id {get; set;}
        [StringLength(50)]
        public string Ten {get; set;}
        [StringLength(50)]
        public string DiaChi {get; set;}
        [StringLength(10)]
        public string DienThoai {get; set;}
        public IList<PhieuNhapDTO> PhieuNhaps {get;set;} = new List<PhieuNhapDTO>();
    }
}