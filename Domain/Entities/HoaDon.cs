using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Domain.Entities
{
    public class HoaDon
    {
        public int Id {get;set;}

        [DataType(DataType.Date)]
        public DateTime NgayLap {get;set;} = DateTime.Now; // Ngay hien tai, luc them moi hoa don tu tao
        //Setup 1-n HoaDon-ChiTietHoaDon
        public IList<ChiTietHoaDon> ChiTietHoaDons {get;set;} = new List<ChiTietHoaDon>();
        public int KhachHangId {get; set;}
        public KhachHang KhachHang {get; set;}
    }
}