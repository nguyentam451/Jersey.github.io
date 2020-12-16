using System;
using System.Collections.Generic;
using System.Linq;
using Domain.Entities;

namespace Infrastructure.Persistence
{
    public class SeedData
    {
        public static void Initialize(ShopLinhKienDbContext context)
        {

            //Tạo db khỏi cần migrations
            context.Database.EnsureCreated();


            //context.(TenTable).Any() => co 1 thang thi no se la true 
            //=> !context.(TenTable).Any() => co 1 thang thi no se la false hay chua co thang nao thi true

            
                // khách hàng
              if(!context.KhachHangs.Any())
            {
                //Tuong tu tren
                context.KhachHangs.AddRange(new List<KhachHang>{
                    new KhachHang {
                        
                        Ten = "Tan Tai",  
                        DiaChi ="Vinh Loc",
                        DienThoai = "0103748888",
                                     
                    },
                    new KhachHang {
                        Ten = "Thien Tam",  
                        DiaChi ="HCM",
                        DienThoai = "0723332222",
                    },
                    new KhachHang {
                        Ten = "Hoang Long",  
                        DiaChi ="Vinh Loc",
                        DienThoai = "0133333222",
                    },
                      new KhachHang {
                        Ten = "Ngoc Thien",  
                        DiaChi ="Quan 5",
                        DienThoai = "0177778888",
                    },
                      new KhachHang {
                        Ten = "Thoai Lan",  
                        DiaChi ="Vinh Loc",
                        DienThoai = "0111110000",
                    },
                });
                //Nho SaveChange;
                context.SaveChanges();
            }

            if (!context.TaiKhoans.Any())
            {
                //Chi seed data khi ma table TaiKhoan chua co th nao
                context.TaiKhoans.AddRange(new List<TaiKhoan>{
                    new TaiKhoan {
                    Username = "admin",
                    Password = "123",
                    Quyen = "admin",
                    KhachHangId = 1,                  
                    },
                     new TaiKhoan {
                    Username = "user2",
                    Password = "123",
                    Quyen = "user",
                    KhachHangId = 2,                   
                    },
                     new TaiKhoan {
                    Username = "user3",
                    Password = "123",
                     Quyen = "user",
                    KhachHangId = 3,                   
                    },
                    new TaiKhoan {
                    Username = "user4",
                    Password = "123",
                     Quyen = "user",
                    KhachHangId = 4,    
                    },
                     new TaiKhoan {
                    Username = "user5",
                    Password = "123",
                    Quyen = "user",
                    KhachHangId = 5,    
                    },
                });
                context.SaveChanges();
            }
            //Thêm dữ liệu thì k cần phải thêm id, nó tự tăng cho mình
            //Seed data TaiKahon

            //SeedData LoaiHangHoa
            //(em seeed may th dung mot minh truoc de no co khoa ngoai cho may th sau)
            //ctrl + alt + f de format

            //dm sao k an :)
            //  tis e fotmat sau :v

            if(!context.LoaiHangHoas.Any())
            {
                //Tuong tu tren
                context.LoaiHangHoas.AddRange(new List<LoaiHangHoa>{
                    new LoaiHangHoa {
                        Ten = "LapTop"               
                    },
                    new LoaiHangHoa {
                        Ten = "CPU"
                    },
                    new LoaiHangHoa {
                        Ten = "Quạt"
                    },
                });
                //Nho SaveChange;
                context.SaveChanges();
            }
            // h them th HangHoa
            if(!context.HangHoas.Any())
            {
                //Tuong tu tren
                context.HangHoas.AddRange(new List<HangHoa>{
                    new HangHoa {

                        //Do k co th LoaiHAngHoaId = 3
                        LoaiHangHoaId=1,
                        Ten = " hang hoa 1",   
                        DonGia = 10000,
                        SoLuong = 100,      
                        TinhTrang = "Còn",     
                    },
                    new HangHoa {
                        LoaiHangHoaId=2,
                        Ten = " hang hoa 2",
                        DonGia = 3500000,
                        SoLuong = 10,
                        TinhTrang = "còn"
                    },
                    new HangHoa {
                        LoaiHangHoaId = 3,
                        Ten = "hàng hóa 3",
                        DonGia = 2500000,
                        SoLuong = 10,
                        TinhTrang = "còn",
                    }
                });
                //Nho SaveChange;
                //wtf
                // để e tạo hết rồi e làm theo video có gì kẹt e hỏi a sau
                // nãy giờ nhiều quá để e hấp hthu //ok em
                //Em phai them hang hoa co loai ha cáing hoa id thoa man nha
                context.SaveChanges();
            }// de e tu them a oi 
            // anh them thang nay do co dac biet ti

            // Hóa đơn
             if(!context.HoaDons.Any())
            {
                //Tuong tu tren
                context.HoaDons.AddRange(new List<HoaDon>{
                    new HoaDon {
                        KhachHangId = 1,
                        NgayLap = DateTime.Parse("2020-1-12"),
                 
                    },
                    new HoaDon {
                        KhachHangId = 2,
                        NgayLap = DateTime.Parse("2020-2-12"),

                        
                    },
                    new HoaDon {
                        KhachHangId = 3,
                        NgayLap = DateTime.Parse("2020-1-12"),

                    },
                });
                //Nho SaveChange;
                context.SaveChanges();
            }


            // Chi tiết giao hàng
            if(!context.ChiTietHoaDons.Any())
            {
                //Tuong tu tren
                context.ChiTietHoaDons.AddRange(new List<ChiTietHoaDon>{
                    new ChiTietHoaDon {
                        
                       HangHoaId = 1,
                       HoaDonId = 1,
                       SoLuong = 1,
                       DonGia = 250000,            
                                     
                    },
                    new ChiTietHoaDon {
                       HangHoaId = 2,
                       HoaDonId = 2,
                       SoLuong = 4,
                       DonGia = 100000,
                    },
                    new ChiTietHoaDon {
                       HangHoaId = 3,
                       HoaDonId = 3,
                       SoLuong = 10,
                       DonGia = 200000,
                    },
                });
                //Nho SaveChange;
                context.SaveChanges();
            }

                        // Nhà cung cấp
            if(!context.NhaCungCaps.Any())
            {
                
                context.NhaCungCaps.AddRange(new List<NhaCungCap>{
                    new NhaCungCap {
                        Ten = "Nhà cung cấp A",
                        DiaChi = "Quận 10",
                        DienThoai = "0929222922",          
                                     
                    },
                       new NhaCungCap {
                        Ten = "Nhà cung cấp B",
                        DiaChi = "Quận 5",
                        DienThoai = "0921122222",        
                                     
                    },
                       new NhaCungCap {
                        Ten = "Nhà cung cấp C",
                        DiaChi = "Quận 9",
                        DienThoai = "0111111000",          
                                     
                    },
                });
                //Nho SaveChange;
                context.SaveChanges();
            }

          
            
              // Phiếu nhập
             if(!context.PhieuNhaps.Any())
            {
                
                context.PhieuNhaps.AddRange(new List<PhieuNhap>{
                    new PhieuNhap {
                        Ten = "Phiếu nhập 1",
                        NgayNhap = DateTime.Parse("2019-1-12"),
                        NhaCungCapId = 1,        
                                     
                    },
                       
                        new PhieuNhap {
                        Ten = "Phiếu nhập 2",
                        NhaCungCapId = 2,
                        NgayNhap = DateTime.Parse("2019-1-12"),

                                     
                    },
                        new PhieuNhap {
                        Ten = "Phiếu nhập 3",
                        NhaCungCapId = 3, 
                        NgayNhap = DateTime.Parse("2019-1-12"),

                                     
                    },
                });
                //Nho SaveChange;
                context.SaveChanges();
            }

            // Chi tiết phiếu nhập
              if(!context.ChiTietPhieuNhaps.Any())
            {
                
                context.ChiTietPhieuNhaps.AddRange(new List<ChiTietPhieuNhap>{
                    new ChiTietPhieuNhap {
                       HangHoaId = 1,
                       PhieuNhapId = 1,
                       SoLuong = 10,
                       DonGia = 100000,       
                                     
                    },
                       
                    new ChiTietPhieuNhap {
                       HangHoaId = 2,
                       PhieuNhapId = 2,
                       SoLuong = 20,
                       DonGia = 200000,       
                                     
                    },
                        new ChiTietPhieuNhap {
                        HangHoaId = 3,
                        PhieuNhapId = 3,
                        SoLuong = 100,
                        DonGia = 3500000,       
                               
                                     
                    },
                });
                //Nho SaveChange;
                context.SaveChanges();
            }

            
        }
    }
}