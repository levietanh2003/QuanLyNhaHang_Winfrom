using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quanLyNhaHang_Nhom4.Database
{

    public partial class Food
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Food()
        {
            this.BillInfoes = new HashSet<BillInfo>();
        }

        public int idFood { get; set; }
        public string nameFood { get; set; }
        public int idFC { get; set; }
        public double price { get; set; }
        public string imageFood { get; set; }
        public string statusFood { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BillInfo> BillInfoes { get; set; }
        public virtual FoodCategory FoodCategory { get; set; }
    }
}
