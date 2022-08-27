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

namespace AccessDataBaseDemo
{
    public partial class Form2 : Form
    {
        DataBase database = new DataBase();

        public Form2()
        {
            InitializeComponent();
        }

        private void CreateColums()
        {
            dataGridView1.Columns.Add("IDType", "Id");
            dataGridView1.Columns.Add("Title", "Название");
            dataGridView1.Columns.Add("Rate", "Рейтинг");
        }

        private void ReadSingleRow(DataGridView dgw, IDataRecord record)
        {
            dgw.Rows.Add(record.GetInt32(0), record.GetString(1), record.GetInt32(2));
        }

        private void RefreshDataGrid(DataGridView dgw)
        {
            dgw.Rows.Clear();

            string queryString = $"select * from dbo.TypeCredit";

            SqlCommand command = new SqlCommand(queryString, database.GetConnection());

            database.openConnection();

            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                ReadSingleRow(dgw, reader);
            }
            reader.Close();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            CreateColums();
            RefreshDataGrid(dataGridView1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 Okno = new Form1();
            this.Hide();
            Okno.ShowDialog();
        }
    }
}
