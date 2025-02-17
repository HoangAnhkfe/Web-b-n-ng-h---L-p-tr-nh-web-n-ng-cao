﻿namespace WebBanDongHo.Models.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("HinhThucThanhToan")]
    public partial class HinhThucThanhToan
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public HinhThucThanhToan()
        {
            DoiTacThanhToans = new HashSet<DoiTacThanhToan>();
            DonDatHangs = new HashSet<DonDatHang>();
        }

        [Key]
        [DisplayName("Mã hình thức thanh toán")]
        public int MaHTTT { get; set; }

        [StringLength(255)]
        [DisplayName("Tên hình thức thanh toán")]
        public string TenHTTT { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DoiTacThanhToan> DoiTacThanhToans { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DonDatHang> DonDatHangs { get; set; }
    }
}
