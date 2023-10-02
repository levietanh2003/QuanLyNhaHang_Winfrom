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
    
    public partial class Staff
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Staff()
        {
            this.Accounts = new HashSet<Account>();
            this.Accounts1 = new HashSet<Account>();
            this.Accounts2 = new HashSet<Account>();
            this.AttendanceLists = new HashSet<AttendanceList>();
            this.AttendanceLists1 = new HashSet<AttendanceList>();
            this.AttendanceLists2 = new HashSet<AttendanceList>();
        }
    
        public string idStaff { get; set; }
        public string nameStaff { get; set; }
        public string sex { get; set; }
        public int idPosition { get; set; }
        public System.DateTime dateOfBirth { get; set; }
        public string identityCard { get; set; }
        public string phoneNumber { get; set; }
        public string address { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Account> Accounts { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Account> Accounts1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Account> Accounts2 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AttendanceList> AttendanceLists { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AttendanceList> AttendanceLists1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AttendanceList> AttendanceLists2 { get; set; }
        public virtual Position Position { get; set; }
        public virtual Position Position1 { get; set; }
        public virtual Position Position2 { get; set; }
    }
}