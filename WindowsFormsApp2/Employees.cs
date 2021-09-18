using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Linq;
using System.Data.Linq.Mapping;

namespace WindowsFormsApp2
{
    [Table(Name="Employees")]
    class Employees
    {
        [Column(IsPrimaryKey = true, IsDbGenerated = true, Name = "EmployeeID")]
        public int id { get; set; }
        [Column(Name = "_Name")]
        public string name { get; set; }
        [Column(Name = "Surname")]
        public string surname { get; set; }
    }
}
