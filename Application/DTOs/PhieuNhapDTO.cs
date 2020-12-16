using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Application.DTOs
{
    public class PhieuNhapDTO
    {
        public int Id {get; set;}
        [StringLength(20)]
        public string Ten {get; set;}

        [DataType(DataType.Date)]
        public DateTime NgayNhap {get; set;} = DateTime.Now;
        public int NhaCungCapId {get; set;}
        public NhaCungCapDTO NhaCungCap {get; set;}
        public IList<ChiTietPhieuNhapDTO> ChiTietPhieuNhapDTOs {get;set;} = new List<ChiTietPhieuNhapDTO>();
        
    }
}