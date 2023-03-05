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

namespace TestDataAndSQLPlus
{
    public partial class TableAdmin : Form
    {
        DataBase dataBase = new DataBase();
        int selectedRow;

        public TableAdmin()
        {
            InitializeComponent();
        }

        private void CreateColums()
        {
            dataGridView1.Columns.Add("id", "id");
            dataGridView1.Columns.Add("user_login", "Логин");
            dataGridView1.Columns.Add("username", "Имя пользователя");
            dataGridView1.Columns.Add("password_status", "Статус пароля");
            dataGridView1.Columns.Add("user_role", "Роль");
        }

        private void ReadSingleRow(DataGridView DVG, IDataRecord record)
        {
            DVG.Rows.Add(record.GetInt32(0), record.GetString(1), record.GetString(2), record.GetString(3), record.GetString(4));
        }

        private void RefreshDataGrid(DataGridView DGV)
        {
            DGV.Rows.Clear();

            string queryString = $"select * from test_table";
            SqlCommand command = new SqlCommand(queryString, dataBase.getConnection());
            dataBase.openConnection();

            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                ReadSingleRow(DGV, reader);
            }
            reader.Close();
        }

        private void TableAdmin_Load(object sender, EventArgs e)
        {
            // CreateColums();
            RefreshDataGrid(dataGridView1);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
