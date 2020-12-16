using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Application.DTOs
{
    public class LoaiHangHoaDTO
    {
        public int Id {get;set;}
        [StringLength(50)]
        public string Ten{get;set;}
        public IList<HangHoaDTO> HangHoas {get;set;} = new List<HangHoaDTO>();
    }
}