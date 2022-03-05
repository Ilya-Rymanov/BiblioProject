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
    }
}
