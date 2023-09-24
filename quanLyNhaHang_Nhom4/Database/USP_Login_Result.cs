using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quanLyNhaHang_Nhom4.Database
{
    using System;

    public partial class USP_Login_Result
    {
        public string userName { get; set; }
        public string passWord { get; set; }
        public string displayName { get; set; }
        public int typeAccount { get; set; }
        public string idStaff { get; set; }
    }
}
