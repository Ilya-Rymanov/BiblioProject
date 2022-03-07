using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Biblio
{
    public partial class Readers_frm : Form
    {
        private string log;
        public Readers_frm(string log)
        {
            this.log = log;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2(log);
            this.Hide();
            form2.Show();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                UsersInRoomsBindingSource.Filter = "Book= '" + comboBox1.Text + "'";
            }
            catch
            {
                MessageBox.Show("Ошибка!");
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                UsersInRoomsBindingSource.Filter = "Surname= '" + comboBox1.Text + "'";
            }
            catch
            {
                MessageBox.Show("Ошибка!");
            }
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                UsersInRoomsBindingSource.Filter = "Room= '" + comboBox1.Text + "'";
            }
            catch
            {
                MessageBox.Show("Ошибка!");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                UsersInRoomsBindingSource.Filter = "";
            }
            catch
            {
                MessageBox.Show("Ошибка!");
            }
        }
    }
}
