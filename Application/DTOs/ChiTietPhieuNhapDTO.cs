namespace Application.DTOs
{
    public class ChiTietPhieuNhapDTO
    {
       
       
        public int HangHoaId {get; set;}
        public HangHoaDTO HangHoa{ get; set;}
        public int PhieuNhapId {get; set;}
        public PhieuNhapDTO PhieuNhap {get; set;}
        public int SoLuong {get; set;}
        public double DonGia {get; set;}
    }
}