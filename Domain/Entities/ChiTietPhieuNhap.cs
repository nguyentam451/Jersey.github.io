namespace Domain.Entities
{
    public class ChiTietPhieuNhap
    {
       
        public int HangHoaId {get; set;}
        public HangHoa HangHoa{ get; set;}
        public int PhieuNhapId {get; set;}
        public PhieuNhap PhieuNhap {get; set;}
        public int SoLuong {get; set;}
        public double DonGia {get; set;}
    }
}// em muoosn show danh sach chi tiet phieu nhap ma bi 