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
    
    public partial class monday
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public monday()
        {
            this.diemsvs = new HashSet<diemsv>();
        }
    
        public string mamon { get; set; }
        public string magv { get; set; }
        public string tenmon { get; set; }
        public string trinhdo { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<diemsv> diemsvs { get; set; }
        public virtual GV GV { get; set; }
    }
}
