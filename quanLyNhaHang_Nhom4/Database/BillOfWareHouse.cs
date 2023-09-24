using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace quanLyNhaHang_Nhom4.Database
{
    public partial class BillOfWareHouse
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public BillOfWareHouse()
        {
            this.BillInfoOfWareHouses = new HashSet<BillInfoOfWareHouse>();
        }

        public int idBillOfWareHouse { get; set; }
        public System.DateTime dateAdded { get; set; }
        public string supplier { get; set; }
        public string note { get; set; }
        public string userName { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BillInfoOfWareHouse> BillInfoOfWareHouses { get; set; }
        public virtual Account Account { get; set; }
    }
}
