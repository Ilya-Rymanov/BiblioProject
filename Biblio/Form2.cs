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

namespace Biblio
{
   
    public partial class Form2 : Form
    {
        private string log;
        public Form2(string login)
        {
            this.log = login;
            InitializeComponent();
            SqlConnection sqlConnection = new SqlConnection(@"Data Source=SBD\MSSQL;Initial Catalog=GroveStreat_Biblio;Integrated Security=True");
            SqlDataAdapter sqlDataAdapter1 = new SqlDataAdapter("Select Surname from Users where Phone='" + log + "'", sqlConnection);
            SqlDataAdapter sqlDataAdapter2 = new SqlDataAdapter("Select Name from Users where Phone='" + log + "'", sqlConnection);
            DataTable dataTable1 = new DataTable();
            DataTable dataTable2 = new DataTable();
            sqlDataAdapter1.Fill(dataTable1);
            sqlDataAdapter2.Fill(dataTable2);
            string surname = dataTable1.Rows[0][0].ToString();
            string name = dataTable2.Rows[0][0].ToString();
            label1.Text = "Добро пожаловать, " + name + " " + surname;
        }

        private void label6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {
            Readers_frm form3 = new Readers_frm(log);
            this.Hide();
            form3.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Proizved_frm form1 = new Proizved_frm(log);
            this.Hide();
            form1.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Book_frm form2 = new Book_frm(log);
            this.Hide();
            form2.Show();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Works_frm form4 = new Works_frm(log);
            this.Hide();
            form4.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Proizved_frm form1 = new Proizved_frm(log);
            this.Hide();
            form1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Book_frm form2 = new Book_frm(log);
            this.Hide();
            form2.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Readers_frm form3 = new Readers_frm(log);
            this.Hide();
            form3.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Works_frm form4 = new Works_frm(log);
            this.Hide();
            form4.Show();
        }

        

        private void listBox1_Click(object sender, EventArgs e)
        {
            Proizved_frm form1 = new Proizved_frm(log);
            this.Hide();
            form1.Show();
        }
    }
}
