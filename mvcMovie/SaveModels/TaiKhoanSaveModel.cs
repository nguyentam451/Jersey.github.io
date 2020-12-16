using System.ComponentModel.DataAnnotations;

namespace mvcMovie.SaveModels
{
    public class TaiKhoanSaveModel
    {
        public string Username {get; set;}
        [StringLength(20)]
        [Required]
        public string Password {get; set;}
        public string Quyen {get; set;}
        public string Ten {get; set;}
        [StringLength(50)]
        public string DiaChi {get; set;}
         [StringLength(10)]
        public string DienThoai {get; set;}
    }
}