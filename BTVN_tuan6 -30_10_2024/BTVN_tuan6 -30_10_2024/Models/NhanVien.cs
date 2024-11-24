using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BTVN_tuan6__30_10_2024.Models
{
    public class NhanVien
    {
        [Key]
        [StringLength(4)]
        public string Manv { get; set; }
        [StringLength(10)]
        public string Tenquay { get; set; }
        [StringLength(30)]
        public string Hoten { get; set; }
        public virtual ICollection<BanHang> BanHangs { get; set; }
    }
}