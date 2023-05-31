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
    public partial class Form4 : Form
    {
        string conn_string = @"Data Source=LAB206_5\SQLEXPRESS;Initial Catalog=Flowers01;Integrated Security=True";
        string Login, Password;

        public Form4()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Login = textBox1.Text;
            Password = textBox2.Text;


            SqlConnection sql_conn = new SqlConnection(conn_string);
            string sqlquery = "select Role from [dbo].[Admin] where Login= '" + Login + "' AND Password = '" + Password + "'";
            SqlCommand sqlcomm = new SqlCommand(sqlquery, sql_conn);
            SqlDataAdapter sdr = new SqlDataAdapter(sqlcomm);
            DataTable dt = new DataTable();
            sdr.Fill(dt);

            if (dt.Rows.Count > 0)
            {

                if (dt.Rows[0].ItemArray[0].ToString() == "Администратор")
                {
                    Form7 f = new Form7();
                    f.Show();
                    this.Hide();
                }

            }

            else
            {
                MessageBox.Show("Неправильный логин либо пароль", "Ошибка");
                Form1 f = new Form1();
                f.Show();
                this.Hide();
            }
        }
    }
}
