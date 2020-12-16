namespace Application.DTOs
{
    public class ChiTietHoaDonDTO
    {
        public int HangHoaId {get;set;}
        public HangHoaDTO HangHoa {get;set;}
        //1 chi tiet hoa don nam trong 1 hoa don
        public int HoaDonId {get;set;}
        public HoaDonDTO HoaDon {get;set;}
        public int SoLuong {get;set;}
        public int DonGia { get; set; }
    }
}