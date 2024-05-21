namespace Project_63134214.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("NhanVien")]
    public partial class NhanVien
    {
        public long Id { get; set; }

        [Required]
        [StringLength(200)]
        [Display(Name ="Họ Tên")]
        public string HoTen { get; set; }
        [Display(Name = "Giới Tính")]
        public bool GioiTinh { get; set; }
        [Display(Name = "Email")]
        [StringLength(200)]
        public string Email { get; set; }

        [StringLength(20)]
        [Display(Name = "SĐT")]
        public string SoDienThoai { get; set; }

        [StringLength(200)]
        [Display(Name = "Căn Cước")]
        public string CCCD { get; set; }

        [StringLength(200)]
        [Display(Name = "Tài Khoản")]
        public string TenDangNhap { get; set; }

        [StringLength(200)]
        [Display(Name = "Mật Khẩu")]
        public string MatKhau { get; set; }
        [Display(Name = "Chức Vụ")]
        public long? IdChucVu { get; set; }
        [Display(Name = "Là Quản Trị Viên")]
        public bool QuanTri { get; set; }
        [Display(Name = "Là chuyên viên")]
        public bool ChuyenVien { get; set; }

        [Column("NhanVien")]
        public bool NhanVien1 { get; set; }

        public virtual ChucVu ChucVu { get; set; }
    }
}
public enum GioiTinhEnum
{
    Nam = 1,
    Nu = 0
}
