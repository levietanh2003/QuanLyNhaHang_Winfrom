using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quanLyNhaHang_Nhom4.Database
{
    public partial class BillInfo
    {
        public int idBillInfo { get; set; }
        public int idBill { get; set; }
        public int idFood { get; set; }
        public int countFood { get; set; }

        public virtual Bill Bill { get; set; }

    }
}
