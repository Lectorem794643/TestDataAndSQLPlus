using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestDataAndSQLPlus
{
    public partial class CreateNewAccount : Form
    {
        DataBase dataBase = new DataBase();

        public CreateNewAccount()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }
        private void CreateNewAccount_Load(object sender, EventArgs e)
        {

        }
        private void button_enter_Click(object sender, EventArgs e) // кнопка добавления
        {
            var lodinUser = textBox_login.Text;
            var passwordUser = textBox_password.Text;

            string querystring = $"insert into register(login_user, password_user) values('{lodinUser}', '{passwordUser}')";
            SqlCommand command = new SqlCommand(querystring, dataBase.getConnection());

            dataBase.openConnection();

            if (command.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Аккаунт успешно создан!", "Войдите под своим аккаунтом", MessageBoxButtons.OK, MessageBoxIcon.Information);
                log_in form_log_in = new log_in();
                this.Hide();
                form_log_in.ShowDialog();
            }
            else
            {
                MessageBox.Show("Ошибка :(", "Аккаунт не был зарегистрирован", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            dataBase.closeConnection();
        }

        private Boolean checkUser()
        {
            var lodinUser = textBox_login.Text;
            var passwordUser = textBox_password.Text;

            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();

            string querystring = $"select id_user, login_user, password_user from register where login_user = '{lodinUser}' and password_user = '{passwordUser}'";

            SqlCommand command = new SqlCommand(querystring, dataBase.getConnection());

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                MessageBox.Show("Ошибка :(", "Такой аккаунт уже существует", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return true;
            }
            else
            {
                return false;
            }

        }

        private void pictureBox_Clear_Click(object sender, EventArgs e)
        {
            textBox_login.Text = "";
            textBox_password.Text = "";
        }

        private void textBox_textBox_password_TextChanged(object sender, EventArgs e)
        {
            textBox_password.PasswordChar = '*';
            textBox_password.MaxLength = 50; // Огрпничение по длинне вводимых данных
        }

        private void textBox_login_TextChanged(object sender, EventArgs e)
        {
            textBox_login.MaxLength = 50; // Огрпничение по длинне вводимых данных
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

        //private void pictureBox1_Click(object sender, EventArgs e)
        //{

        //}

        //private void label1_Click(object sender, EventArgs e)
        //{

        //} 

        //private void label1_Click(object sender, EventArgs e)
        //{

        //}

        //private void label1_Click(object sender, EventArgs e)
        //{

        //}
    }
}
