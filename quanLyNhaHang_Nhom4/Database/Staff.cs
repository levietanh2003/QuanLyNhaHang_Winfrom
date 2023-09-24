using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quanLyNhaHang_Nhom4.Database
{
    public partial class Staff
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Staff()
        {
            this.Accounts = new HashSet<Account>();
            this.AttendanceLists = new HashSet<AttendanceList>();
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
        public virtual ICollection<AttendanceList> AttendanceLists { get; set; }
        public virtual Position Position { get; set; }
    }
}
