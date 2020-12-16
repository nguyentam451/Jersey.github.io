using System.Reflection;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
namespace Infrastructure.Persistence
{
    public class ShopLinhKienDbContext : DbContext
    {
        public ShopLinhKienDbContext()
        {
        }

        public ShopLinhKienDbContext (DbContextOptions<ShopLinhKienDbContext> options)
            : base(options)
        {
        }

         public DbSet<TaiKhoan> TaiKhoans {get; set;}
         public DbSet<HangHoa> HangHoas {get;set;}
         public DbSet<LoaiHangHoa> LoaiHangHoas {get;set;}
         public DbSet<HoaDon> HoaDons { get; set; }
         public DbSet<ChiTietHoaDon> ChiTietHoaDons {get;set;}
         public DbSet<ChiTietPhieuNhap> ChiTietPhieuNhaps {get;set;}
         public DbSet<PhieuNhap> PhieuNhaps {get;set;}
         public DbSet<KhachHang> KhachHangs {get;set;}
         public DbSet<NhaCungCap> NhaCungCaps {get;set;}

        // moi lan co thay doi gi o day DbSet hoac cac thuoc tinh cua entity em xoa db chay lai
// cai phuong thuc o duoi co tac dung gi a
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            //Bo thang duoi day di em lam don gian thoi
            //em bat soruce clean cua Ong duoc len di
            //Trong Infras no co cac Configurations (Fluent API) ---> dieu chinh du lieu trc khi tao dataabase
            //HAm nay de goi toan bo cac Configurations do cho nhanh
            //Nhung em lam don gian thoi viet thang torng day lun
            // builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());/ c

            //Khoa chinh cua no se la cap khoa HoaDonId va HangHoaId
            builder.Entity<ChiTietHoaDon>().HasKey(cthd => new {cthd.HangHoaId, cthd.HoaDonId});
            builder.Entity<ChiTietPhieuNhap>().HasKey(ctpn => new {ctpn.HangHoaId, ctpn.PhieuNhapId});

            //Anh chay thu neu k co cai nay

            //Em thay k
            // cai ham o tren de lien ket 2 khoa dugn k a
            // dung roi lien 2khoa thanh 1 cap ok a
        }
    }
    
}