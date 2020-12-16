using System.Collections.Generic;

namespace Domain.Entities
{
    public class LoaiHangHoa // 1 loaij hang
    {
        public int Id {get;set;}
        public string Ten{get;set;}
        // 1 Loai hang hoa co nhieu hang hoa
        // xafi collection chi thees a
        //Em xai IList cung dc
        // maf phai co cai iLIst nay moi duoc ha a
        //Dung roi aem 
        // 1 Loai hang hoa co nhieu hang hoa// 1 Loai hang hoa co nhieu hang hoa
        // 1 Loai hang hoa co nhieu hang hoa// 1 Loai hang hoa co nhieu hang hoa
        // Setup 1-n HangHoa-LoaiHangHoang
        /* nheiu hang */ public IList<HangHoa> HangHoas {get;set;} = new List<HangHoa>();
    }
}