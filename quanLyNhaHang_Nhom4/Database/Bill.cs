using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
namespace quanLyNhaHang_Nhom4.Database
{
    public partial class Bill
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public int idBill { get; set; }
        public System.DateTime dateCheckIn { get; set; }
        public Nullable<System.DateTime> dateCheckOut { get; set; }
        public int idTable { get; set; }
        public int statusBill { get; set; }
        public Nullable<int> discount { get; set; }
        public Nullable<double> totalPrice { get; set; }
        public string payerId { get; set; }

        public virtual Account Account { get; set; }
        //public virtual TableFood TableFood { get; set; }
        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<BillInfo> BillInfoes { get; set; }

    }
}
