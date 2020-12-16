using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Application.DTOs
{
    public class HoaDonDTO
    {
        public int Id {get;set;}

        [DataType(DataType.Date)]
        public DateTime NgayLap {get;set;} = DateTime.Now; // Ngay hien tai, luc them moi hoa don tu tao
        //Setup 1-n HoaDon-ChiTietHoaDon
        public IList<ChiTietHoaDonDTO> ChiTietHoaDons {get;set;} = new List<ChiTietHoaDonDTO>();
        public int KhachHangId {get; set;}
        public KhachHangDTO KhachHang {get; set;}
    }
}