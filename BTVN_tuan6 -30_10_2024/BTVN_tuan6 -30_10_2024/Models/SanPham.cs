using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BTVN_tuan6__30_10_2024.Models
{
    public class SanPham
    {
        [Key]
        [StringLength(5)]
        public string Masp { get; set; }
        [StringLength(20)]
        public string Tensp { get; set; }
        public virtual ICollection<BanHang> BanHangs { get; set; }
    }
}