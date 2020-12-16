using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Domain.Entities
{
    public class PhieuNhap
    {
        public int Id {get; set;}
        public string Ten {get; set;}
        [DataType(DataType.Date)]
        public DateTime NgayNhap {get; set;} = DateTime.Now;
        public int NhaCungCapId {get; set;}
        public NhaCungCap NhaCungCap {get; set;}
         public IList<ChiTietPhieuNhap> ChiTietPhieuNhaps {get;set;} = new List<ChiTietPhieuNhap>();
        
    }
}