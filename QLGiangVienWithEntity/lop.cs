//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace QLGiangVienWithEntity
{
    using System;
    using System.Collections.Generic;
    
    public partial class lop
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public lop()
        {
            this.sinhviens = new HashSet<sinhvien>();
        }
    
        public string Malop { get; set; }
        public string Tenlop { get; set; }
        public string NienKhoa { get; set; }
        public string magv { get; set; }
        public string makhoa { get; set; }
    
        public virtual GV GV { get; set; }
        public virtual Khoa Khoa { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<sinhvien> sinhviens { get; set; }
    }
}
