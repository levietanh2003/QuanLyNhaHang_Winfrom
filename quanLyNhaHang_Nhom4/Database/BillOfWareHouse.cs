//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace quanLyNhaHang_Nhom4.Database
{
    using System;
    using System.Collections.Generic;
    
    public partial class BillOfWareHouse
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public BillOfWareHouse()
        {
            this.BillInfoOfWareHouses = new HashSet<BillInfoOfWareHouse>();
            this.BillInfoOfWareHouses1 = new HashSet<BillInfoOfWareHouse>();
            this.BillInfoOfWareHouses2 = new HashSet<BillInfoOfWareHouse>();
        }
    
        public int idBillOfWareHouse { get; set; }
        public System.DateTime dateAdded { get; set; }
        public string supplier { get; set; }
        public string note { get; set; }
        public string userName { get; set; }
    
        public virtual Account Account { get; set; }
        public virtual Account Account1 { get; set; }
        public virtual Account Account2 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BillInfoOfWareHouse> BillInfoOfWareHouses { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BillInfoOfWareHouse> BillInfoOfWareHouses1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BillInfoOfWareHouse> BillInfoOfWareHouses2 { get; set; }
    }
}