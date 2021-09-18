using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Linq;
using System.Data.Linq.Mapping;


namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        static string connectionString = "Data Source=90.189.116.66;Initial Catalog=TEST; user= ZMYA; password = 12345_Zakhar";
        DataContext context = new DataContext(connectionString);
        public Form1()
        {
            InitializeComponent();
            dataGridView1.DataSource = context.GetTable<Orders>();
            dataGridView2.DataSource = context.GetTable<Employees>();
            dataGridView3.DataSource = context.GetTable<OrderCompos>();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Orders NewOrder = new Orders
            {
                OrderDate = Convert.ToDateTime(textBox2.Text), EmployeeID = Convert.ToInt32(textBox3.Text)
                
            };
            context.GetTable<Orders>().InsertOnSubmit(NewOrder);
            context.SubmitChanges();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Employees NewEmployees = new Employees
            {
                name = textBox1.Text,
                surname = textBox4.Text
            };
            context.GetTable<Employees>().InsertOnSubmit(NewEmployees);
            context.SubmitChanges();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OrderCompos NewOrderCompos = new OrderCompos
            {
                id = Convert.ToInt32(textBox5.Text),
                count = Convert.ToInt32(textBox6.Text)
            };
            context.GetTable<OrderCompos>().InsertOnSubmit(NewOrderCompos);
            context.SubmitChanges();
        }
    }
}
