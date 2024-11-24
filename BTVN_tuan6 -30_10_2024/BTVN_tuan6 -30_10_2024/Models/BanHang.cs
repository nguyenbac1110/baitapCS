using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace BTVN_tuan6__30_10_2024.Models
{
    public class BanHang
    {
        [Key,Column(Order = 0)]
        [StringLength(4)]
        public string Manv { get; set; }
        [Key, Column(Order = 1)]
        [StringLength(5)]
        public string Masp { get; set; }
        public short Dinhmuc { get; set; }
        public short Slban { get; set; }
        [ForeignKey("Manv")]
        public virtual NhanVien NhanVien { get; set; }
        [ForeignKey("Masp")]
        public virtual SanPham SanPham { get; set; }
    }
}