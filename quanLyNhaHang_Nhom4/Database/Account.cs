using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quanLyNhaHang_Nhom4.Database
{
    using System;
    using System.Collections.Generic;
    public partial class Account
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Account()
        {
            this.Bills = new HashSet<Bill>();
            this.BillOfWareHouses = new HashSet<BillOfWareHouse>();
        }

        public string userName { get; set; }
        public string passWord { get; set; }
        public string displayName { get; set; }
        public int typeAccount { get; set; }
        public string idStaff { get; set; }

        public virtual Staff Staff { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Bill> Bills { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BillOfWareHouse> BillOfWareHouses { get; set; }
    }
}

