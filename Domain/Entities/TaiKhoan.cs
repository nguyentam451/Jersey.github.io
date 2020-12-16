using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities
{
    //Em nhớ thêm public int Id vô để tạo khóa nha

    // em để khóa là uusername luôn a
    // cái đó k cần đâu em, để khóa là th đó phải config lại nữa

    //System.InvalidOperationException: The entity type 'TaiKhoan' requires a primary key to be defined. 
    //If you intended to use a keyless entity type, call 'HasNoKey

    //nhớ cái lỗi này là k có khóa chính 
    // cái seed data có cần thêm id vô k a
    //[Table("TaiKhoan")]
    public class TaiKhoan
    {
        // em de nv tuc la kach hang tai khoan 1-1 nha d
        public int Id {get;set;}
        public string Username {get; set;}
        public string Password {get; set;}
        public string Quyen {get; set;}
        public int KhachHangId {get; set;}
        public KhachHang KhachHang {get; set;}
    }
}