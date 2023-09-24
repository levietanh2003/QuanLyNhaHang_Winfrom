using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quanLyNhaHang_Nhom4.Database
{
    public partial class BillInfoOfWareHouse
    {
        public int idBillInfoOfWareHouse { get; set; }
        public Nullable<int> idBillOfWareHouse { get; set; }
        public Nullable<int> idMaterial { get; set; }
        public Nullable<int> number { get; set; }
        public int price { get; set; }
        public int totalPrice { get; set; }

        public virtual BillOfWareHouse BillOfWareHouse { get; set; }
    }
}
