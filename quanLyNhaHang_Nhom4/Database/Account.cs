using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace quanLyNhaHang_Nhom4.Database
{
   
  public partial class Account
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public string userName { get; set; }
        public string passWord { get; set; }
        public string displayName { get; set; }
        public int typeAccount { get; set; }
        public int idStaff { get; set; }

    }
}
