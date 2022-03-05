using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;

namespace Biblio
{
    public partial class Regester : Form
    {
        Users user = new Users();
        public Regester()
        {
            InitializeComponent();
        }

        private void Regester_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "groveStreat_BiblioDataSet.Gender". При необходимости она может быть перемещена или удалена.
            this.genderTableAdapter.Fill(this.groveStreat_BiblioDataSet.Gender);

            Genry_tbx.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Name_tbx.Text != "" && FirstName_txb.Text != "" && Genry_tbx.Text != "" && birst_txb.Text != "" && number_txb.Text != "" && password_txb.Text != "" && twoPassword_txb.Text != "")
            {
                if (password_txb.Text == twoPassword_txb.Text)
                {
                    user.Name = Name_tbx.Text;
                    user.Surname = FirstName_txb.Text;
                    user.Patronymic = LastName_txb.Text;
                    user.Gender = (int)Genry_tbx.SelectedValue;
                    user.Birthdate = birst_txb.Value;
                    user.Phone = number_txb.Text;
                    user.Password = password_txb.Text;
                    user.Role = 2;
                    using(GroveStreat_BiblioEntities db = new GroveStreat_BiblioEntities())
                    {
                        if(user.Id==0)
                        {
                            db.Users.Add(user);
                            db.SaveChanges();
                            MessageBox.Show("Вы успешно зарегистрированы!");
                            Form1 form1 = new Form1();
                            this.Hide();
                            form1.Show();
                        }
                        else
                        {
                            MessageBox.Show("Ошиб очка");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Пароли не совпадают.");
                }
            }
            else
            {
                MessageBox.Show("Заполните все поля.");
            }
        }


        private void label10_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label11_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            this.Hide();
            form1.Show();
        }
    }
}
