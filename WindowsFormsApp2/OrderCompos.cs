using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Linq;
using System.Data.Linq.Mapping;

namespace WindowsFormsApp2
{
    [Table(Name = "OrderCompos")]
    class OrderCompos
    {
        [Column(IsPrimaryKey = true, Name = "OrderID")]
        public int id { get; set; }
        [Column(Name = "_Count")]
        public int count { get; set; }
    }
}
