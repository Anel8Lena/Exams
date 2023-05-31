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
    public partial class Form7 : Form
    {
        string conn_string = @"Data Source=LAB206_5\SQLEXPRESS;Initial Catalog=Flowers01;Integrated Security=True";

        public Form7()
        {
            InitializeComponent();
        }

        private void Form7_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "flowers01DataSet.Tovar". При необходимости она может быть перемещена или удалена.
            this.tovarTableAdapter.Fill(this.flowers01DataSet.Tovar);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
            this.Hide();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            SqlConnection sql_conn = new SqlConnection(conn_string);
            string sqlquery = "select * from [dbo].[Tovar] where name Like '" + textBox1.Text + "%'";
            sql_conn.Open(); // открыть соединение
            SqlCommand sqlcomm = new SqlCommand(sqlquery, sql_conn);
            SqlDataAdapter sdr = new SqlDataAdapter(sqlcomm);
            DataTable dt = new DataTable();
            sdr.Fill(dt);
            dataGridView1.DataSource = dt;
            sql_conn.Close();
        }
    }
}
