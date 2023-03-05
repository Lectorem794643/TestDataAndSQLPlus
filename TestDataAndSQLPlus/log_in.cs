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
using Microsoft.SqlServer.Server;

namespace TestDataAndSQLPlus
{
    public partial class log_in : Form
    {
        DataBase dataBase = new DataBase();




        public log_in()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen; // форма в центре экрана
        }

        private void log_in_Load(object sender, EventArgs e)
        {

        }

        private void textBox_password_TextChanged(object sender, EventArgs e) 
        {
            textBox_password.PasswordChar = '*';
            textBox_password.MaxLength = 50; // Огрпничение по длинне вводимых данных
        }
        private void textBox_login_TextChanged(object sender, EventArgs e) 
        {
            textBox_login.MaxLength = 50; // Огрпничение по длинне вводимых данных


        }
        private void button_enter_Click(object sender, EventArgs e) // кнопка входа
        {
            var lodinUser = textBox_login.Text;
            var passwordUser = textBox_password.Text;

            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();

            string querystring = $"select id_user, login_user, password_user from register where login_user = '{lodinUser}' and password_user = '{passwordUser}'";

            SqlCommand command = new SqlCommand(querystring, dataBase.getConnection());

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count == 1)
            {
                MessageBox.Show("Добро пожаловать!", "Вы вошли в аккаунт", MessageBoxButtons.OK, MessageBoxIcon.Information);
                // !!!
                TableAdmin form1 = new TableAdmin();
                this.Hide();
                form1.ShowDialog();
            }
            else
            {
                MessageBox.Show("Такого аккаунта не существует!", "Неверный логин или пароль, пользователь не найден", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }  
        }

        private void pictureBox_OpenPassword_Click(object sender, EventArgs e)
        {
            textBox_password.UseSystemPasswordChar = true;
            pictureBox_OpenPassword.Visible = false;
            pictureBox_ClousedPassword.Visible = true;
        }

        private void pictureBox_ClousedPassword_Click(object sender, EventArgs e)
        {
            textBox_password.UseSystemPasswordChar = false;
            pictureBox_ClousedPassword.Visible = false;
            pictureBox_OpenPassword.Visible = true;
        }

        private void pictureBox_Clear_Click(object sender, EventArgs e)
        {
            textBox_login.Text = "";
            textBox_password.Text = "";
        }

        private void linkLabel_to_avtorosation_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CreateNewAccount form_new_user = new CreateNewAccount();
            this.Hide();
            form_new_user.ShowDialog();
        }

        //private void label1_Click(object sender, EventArgs e)
        //{

        //}

        //private void label3_Click(object sender, EventArgs e)
        //{

        //}

        //private void label2_Click(object sender, EventArgs e)
        //{

        //}

        //private void textBox1_TextChanged(object sender, EventArgs e)
        //{

        //}

        //private void label1_Click(object sender, EventArgs e)
        //{

        //}

        //private void label1_Click_1(object sender, EventArgs e)
        //{

        //} 

        //private void pictureBox1_Click(object sender, EventArgs e) 
        //{

        //}

        //private void label2_Click(object sender, EventArgs e) 
        //{

        //}

        //private void label3_Click(object sender, EventArgs e)
        //{

        //} 


        //private void panel1_Paint(object sender, PaintEventArgs e)
        //{

        //} 

    }
}
