namespace Domain.Entities
{
    public class ChiTietHoaDon
    {
        //1 chi teit hoa don co 1 san pahm
        public int HangHoaId {get;set;}
        public HangHoa HangHoa {get;set;}
        //1 chi tiet hoa don nam trong 1 hoa don
        public int HoaDonId {get;set;}
        public HoaDon HoaDon {get;set;}
        public int SoLuong {get;set;}
        public int DonGia { get; set; }

    }
}