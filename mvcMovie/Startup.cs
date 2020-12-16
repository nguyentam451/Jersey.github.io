using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;
using Infrastructure.Persistence;
using Domain.Interfaces;
using Application.Interfaces;
using Application.Services;

namespace mvcMovie
{
    public class Startup
    {

         public Startup(IConfiguration configuration, IWebHostEnvironment env)
        {
             Environment = env;
             Configuration = configuration;
        }
         public IConfiguration Configuration { get; }
        public IWebHostEnvironment Environment { get; }
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews();
         //   services.AddSingleton<IMovieRepository, MovieRepository>();

           // services.AddDbContext<ShopLinhKienDbContext>(options => options.UseSqlServer(Configuration.GetConnectionString("ShopLinhKienDbConnectionString")));

            services.AddDbContext<ShopLinhKienDbContext>(options =>
             {
                var connectionString = Configuration.GetConnectionString("ShopLinhKienDbConnectionString");
                options.UseSqlite(connectionString);
                //Bỏ thằng dưới nha
                //  if (Environment.IsDevelopment())
                //     {
                //         options.UseSqlite(connectionString);
                //     }
                // else
                //     {
                //         options.UseSqlServer(connectionString);
                //     }
            });

          //  services.AddScoped<ISanPhamRepository, SanPhamRepository>();
          services.AddScoped<ITaiKhoanRepository, TaiKhoanRepository>();
          services.AddScoped<ITaiKhoanServices, TaiKhoanServices>();

        // HoaDon
          services.AddScoped<IHoaDonRepository, HoaDonRepository>();
          services.AddScoped<IHoaDonServices,HoaDonServices>();

           // PhieuNhap
          services.AddScoped<IPhieuNhapRepository, PhieuNhapRepository>();
          services.AddScoped<IPhieuNhapServices,PhieuNhapServices>();

        // HangHoa
          services.AddScoped<IHangHoaRepository, HangHoaRepository>();
          services.AddScoped<IHangHoaServices,HangHoaServices>();

          // LoaiHangHoa
          services.AddScoped<ILoaiHangHoaRepository, LoaiHangHoaRepository>();
          services.AddScoped<ILoaiHangHoaServices,LoaiHangHoaServices>();

          // NhaCungCap
          services.AddScoped<INhaCungCapRepository, NhaCungCapRepository>();
          services.AddScoped<INhaCungCapServices, NhaCungCapServices>();

          // KhachHang
          services.AddScoped<IKhachHangRepository, KhachHangRepository>();
          services.AddScoped<IKhachHangServices, KhachHangServices>();

            // ChiTietHoaDon
          services.AddScoped<IChiTietHoaDonRepository, ChiTietHoaDonRepository>();
          services.AddScoped<IChiTietHoaDonServices, ChiTietHoaDonServices>();
            
            // ChiTietPhieuNhap
          services.AddScoped<IChiTietPhieuNhapRepository, ChiTietPhieuNhapRepository>();
          services.AddScoped<IChiTietPhieuNhapServices, ChiTietPhieuNhapServices>();

        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseStaticFiles();
            app.UseRouting();
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: default,
                    pattern: "{controller=Login}/{action=Index}/{id?}"
                );
            });
        }

    }
}