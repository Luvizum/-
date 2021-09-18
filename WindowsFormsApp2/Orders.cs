using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Linq;
using System.Data.Linq.Mapping;


namespace WindowsFormsApp2
{
    [Table(Name = "Orders")]
    class Orders
    {
        [Column(IsPrimaryKey = true, IsDbGenerated = true, Name = "OrderID")]
        public int id { get; set; }
        [Column(Name = "OrderDate")]
        public DateTime OrderDate { get; set; }
        [Column(Name = "EmployeeID")]
        public int EmployeeID { get; set; }
    }
}
