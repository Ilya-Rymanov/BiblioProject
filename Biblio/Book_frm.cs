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
    public partial class Book_frm : Form
    {
        private string log;
        public Book_frm(string log)
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
                ExtraBooksViewBindingSource.Filter = "Book= '" + comboBox1.Text + "'";
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
                ExtraBooksViewBindingSource.Filter = "Surname= '" + comboBox2.Text + "'";
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
                ExtraBooksViewBindingSource.Filter = "";
            }
            catch
            {
                MessageBox.Show("Ошибка!");
            }
        }
    }
}
