﻿namespace WebBanDongHo.Models.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DoiTacThanhToan")]
    public partial class DoiTacThanhToan
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DoiTacThanhToan()
        {
            DonDatHangs = new HashSet<DonDatHang>();
        }

        [Key]
        [DisplayName("Mã đối tác thanh toán")]
        public int MaDTTT { get; set; }

        [StringLength(255)]
        [DisplayName("Tên đối tác thanh toán")]
        public string TenDTTT { get; set; }
        [DisplayName("Hình thức thanh toán")]
        public int? MaHTTT { get; set; }

        public virtual HinhThucThanhToan HinhThucThanhToan { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DonDatHang> DonDatHangs { get; set; }
    }
}
