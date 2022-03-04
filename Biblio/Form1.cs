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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string login;
        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConnection = new SqlConnection(@"Data Source=SBD\MSSQL;Initial Catalog=GroveStreat_Biblio;Integrated Security=True");
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("Select Count(*) from Users where Phone='" + logBox.Text + "' and Password='" + passBox.Text + "'", sqlConnection);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            if(logBox.Text!="" && passBox.Text!="")
            {
                if(dataTable.Rows[0][0].ToString()=="1")
                {
                    login = logBox.Text;
                    Form2 form2 = new Form2(login);
                    this.Hide();
                    form2.Show();
                }
                else
                {
                    MessageBox.Show("Учетная запись не найдена.");
                }
            }
            else
            {
                MessageBox.Show("Заполнены не все поля.");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Regester reg = new Regester();
            this.Hide();
            reg.Show();
        }
    }
}
