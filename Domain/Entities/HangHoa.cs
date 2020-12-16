using System.Collections.Generic;

namespace Domain.Entities
{
    public class HangHoa // 1 hang
    {
        public int Id {get;set;}
        public string Ten {get;set;}
        //Mayas cais thuoc tinh kia em lam sau nha

        //1 hang chi nam trong 1 loai hang hoa ( 1-n )
        //em hieu k
        // co gi em comment lai sau nay de roi
        // Setup 1-n HangHoa-LoaiHangHoang
        //doan nay bi ki ki r
        //
        public int LoaiHangHoaId {get;set;}
        public LoaiHangHoa LoaiHangHoa {get;set;}
        //Khoa ngoai
        public double DonGia{get;set;}
        public int SoLuong {get; set;}
        public string TinhTrang {get; set;}
        //Setup 1-n HangHoa-ChiTietHoaDon
        public IList<ChiTietHoaDon> ChiTietHoaDons {get;set;} = new List<ChiTietHoaDon>();
        public IList<ChiTietPhieuNhap> ChiTietPhieuNhaps {get;set;} = new List<ChiTietPhieuNhap>();
    }
}