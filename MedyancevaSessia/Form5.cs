using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace MedyancevaSessia
{
    public partial class Form5 : Form
    {
        string conn_string = @"Data Source=LAB206_5\SQLEXPRESS;Initial Catalog=Flowers01;Integrated Security=True";

        public Form5()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
            this.Hide();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "flowers01DataSet.Flowers". При необходимости она может быть перемещена или удалена.
            this.flowersTableAdapter.Fill(this.flowers01DataSet.Flowers);

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            SqlConnection sql_conn = new SqlConnection(conn_string);
            string sqlquery = "select * from [dbo].[Flowers] where name Like '" + textBox1.Text + "%'";
            sql_conn.Open(); // открыть соединение
            SqlCommand sqlcomm = new SqlCommand(sqlquery, sql_conn);
            SqlDataAdapter sdr = new SqlDataAdapter(sqlcomm);
            DataTable dt = new DataTable();
            sdr.Fill(dt);
            dataGridView1.DataSource = dt;
            sql_conn.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        
    }
}
