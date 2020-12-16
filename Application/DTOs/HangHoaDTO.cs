using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Application.DTOs
{
    public class HangHoaDTO
    {
        public int Id {get;set;}
        [StringLength(50)]
        public string Ten {get;set;}
        public int LoaiHangHoaId {get;set;}
        public LoaiHangHoaDTO LoaiHangHoa {get;set;}
        //Khoa ngoai
        public double DonGia{get;set;}
        public int SoLuong {get; set;}
        [StringLength(50)]
        public string TinhTrang {get; set;}
        public IList<ChiTietHoaDonDTO> ChiTietHoaDons {get;set;} = new List<ChiTietHoaDonDTO>();
        public IList<ChiTietPhieuNhapDTO> ChiTietPhieuNhaps {get;set;} = new List<ChiTietPhieuNhapDTO>();
    }
}