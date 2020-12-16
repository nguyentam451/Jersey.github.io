using System;
using System.ComponentModel.DataAnnotations;

namespace Application.DTOs
{
    public class TaiKhoanDTO
    {
        public int Id {get;set;}
        [StringLength(20)]
        [Required]
        public string Username {get; set;}
        [StringLength(20)]
        [Required]
        public string Password {get; set;}
        public string Quyen {get; set;}
        public int KhachHangId {get; set;}
        public KhachHangDTO KhachHang {get; set;}
      
    }
}