using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace AccessDataBaseDemo

{
    enum RowState
    {
        Elisted,
        New,
        Modified,
        ModifiedNew,
        Deleted
    }

    public partial class Form1 : Form
    {

        DataBase database = new DataBase();

        int selectedRow;

        public Form1()
        {
            InitializeComponent();
        }

        private void CreateColums()
        {
            dataGridView1.Columns.Add("IDClient", "Id");
            dataGridView1.Columns.Add("FirstName", "Имя");
            dataGridView1.Columns.Add("LastSurname", "Фамилия");
            dataGridView1.Columns.Add("MiddleName", "Отчество");
            dataGridView1.Columns.Add("PhoneNumber", "Номер телефона");
            dataGridView1.Columns.Add("Adds", "Адрес");
            dataGridView1.Columns.Add("IDPerson", "Вид");
            dataGridView1.Columns.Add("MounthlyIncome", "Доход");
            dataGridView1.Columns.Add("isNew", string.Empty);

            dataGridView2.Columns.Add("IDCredit", "Id");
            dataGridView2.Columns.Add("IDType", "Тип");
            dataGridView2.Columns.Add("IDClient", "Клиент");
            dataGridView2.Columns.Add("Summa", "Сумма кредита");
            dataGridView2.Columns.Add("Datelssue", "Дата получения");
            dataGridView2.Columns.Add("Extradition", "Выдан да/нет");

        }

        private void ClearFields()
        {
            textBox_IDClient.Text = "";
            textBox_F.Text = "";
            textBox_L.Text = "";
            textBox_M.Text = "";
            textBox_NumberT.Text = "";
            textBox_Adds.Text = "";
            textBox_IDPER.Text = "";
            textBox_Mounthly.Text = "";

            textBox_IDTC.Text = "";
            textBox_Summa.Text = "";
            textBox_Date.Text = "";
            textBox_IDClient1.Text = "";
            textBox_0.Text = "";

        }

        private void ReadSingleRow(DataGridView dgw, IDataRecord record)
        {
            dgw.Rows.Add(record.GetInt32(0), record.GetString(1), record.GetString(2), record.GetString(3), record.GetInt32(4), record.GetString(5), record.GetInt32(6), record.GetInt32(7), RowState.ModifiedNew);
        }

        private void ReadSingleRow1(DataGridView dgw, IDataRecord record)
        {
            dgw.Rows.Add(record.GetInt32(0), record.GetInt32(1), record.GetInt32(2), record.GetInt32(3), record.GetInt32(4), record.GetBoolean(5), RowState.ModifiedNew);
        }

        private void RefreshDataGrid(DataGridView dgw)
        {
            dgw.Rows.Clear();

            string queryString = $"select * from dbo.Client";

            SqlCommand command = new SqlCommand(queryString, database.GetConnection());

            database.openConnection();

            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                ReadSingleRow(dgw, reader);
            }
            reader.Close();
        }

        private void RefreshDataGrid1(DataGridView dgw)
        {
            dgw.Rows.Clear();

            string queryString = $"select * from dbo.Credit";

            SqlCommand command = new SqlCommand(queryString, database.GetConnection());

            database.openConnection();

            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                ReadSingleRow1(dgw, reader);
            }
            reader.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CreateColums();
            RefreshDataGrid(dataGridView1);
            RefreshDataGrid1(dataGridView2);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRow = e.RowIndex;

            if (e.RowIndex >=0)
            {
                DataGridViewRow row = dataGridView1.Rows[selectedRow];

                textBox_IDClient.Text = row.Cells[0].Value.ToString();
                textBox_F.Text = row.Cells[1].Value.ToString();
                textBox_L.Text = row.Cells[2].Value.ToString();
                textBox_M.Text = row.Cells[3].Value.ToString();
                textBox_NumberT.Text = row.Cells[4].Value.ToString();
                textBox_Adds.Text = row.Cells[5].Value.ToString();
                textBox_IDPER.Text = row.Cells[6].Value.ToString();
                textBox_Mounthly.Text = row.Cells[7].Value.ToString();
            }

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRow = e.RowIndex;

            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView2.Rows[selectedRow];

                textBox_IDTC.Text = row.Cells[0].Value.ToString();
                textBox_Summa.Text = row.Cells[1].Value.ToString();
                textBox_Date.Text = row.Cells[2].Value.ToString();
                textBox_IDClient1.Text = row.Cells[3].Value.ToString();
                textBox_0.Text = row.Cells[4].Value.ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            RefreshDataGrid(dataGridView1);
            RefreshDataGrid1(dataGridView2);
            ClearFields();
        }

        private void insertButton_Click(object sender, EventArgs e)
        {
            database.openConnection();

            var F = textBox_NewF.Text;
            var L = textBox_NewL.Text;
            var M = textBox_NewM.Text;
            var NumberT = textBox_NewNumberT.Text;
            var Adds = textBox_NewAdds.Text;
            var IDPER = textBox_NewIDPER.Text;
            var Mounthly = textBox_NewMounthly.Text;

            var addQuery = $"insert into dbo.Client (FirstName, LastSurname, MiddleName, PhoneNumber, Adds, IDPerson, MonthlyIncome) values ('{F}', '{L}', '{M}', '{NumberT}', '{Adds}', '{IDPER}', '{Mounthly}')";

            var command = new SqlCommand(addQuery, database.GetConnection());
            command.ExecuteNonQuery();

            database.closeConnection();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            var id = textBox_NewIDClient.Text;
            var idT = textBox_NewIDTC.Text;
            var Sum = textBox_NewSumma.Text;
            var Date = textBox_NewDate.Text;
            var Zero = textBox_New0.Text;

            var addQuery = $"insert into dbo.Credit (IDType, IDClient, Summa, DateIssue, Extradition) values ('{idT}', '{id}', '{Sum}', '{Date}', '{Zero}')";

            var command = new SqlCommand(addQuery, database.GetConnection());
            command.ExecuteNonQuery();

            database.closeConnection();
        }

        private void Search(DataGridView dgw)
        {
            dgw.Rows.Clear();

            string searchString = $"select * from dbo.Client where concat (FirstName, LastSurname, MiddleName, PhoneNumber, Adds, IDPerson, MonthlyIncome) like '%" + textBox_Search.Text + "%'";


            SqlCommand com = new SqlCommand(searchString, database.GetConnection());

            SqlDataReader read = com.ExecuteReader();

            while (read.Read())
            {
                ReadSingleRow(dgw, read);
            }
            read.Close();
        }

        private void Search1(DataGridView dgw)
        {
            dgw.Rows.Clear();

            string searchString = $"select * from dbo.Credit where concat (IDCredit, IDType, IDClient, Summa, DateIssue, Extradition) like '%" + textBox_Search1.Text + "%'";

            SqlCommand com = new SqlCommand(searchString, database.GetConnection());

            SqlDataReader read = com.ExecuteReader();

            while (read.Read())
            {
                ReadSingleRow1(dgw, read);
            }
            read.Close();
        }

        private void DeleteRow()
        {
            int index = dataGridView1.CurrentCell.RowIndex;

            dataGridView1.Rows[index].Visible = false;

            if (dataGridView1.Rows[index].Cells[0].Value.ToString() == string.Empty)
            {
                dataGridView1.Rows[index].Cells[8].Value = RowState.Deleted;
                return;
            }
            dataGridView1.Rows[index].Cells[8].Value = RowState.Deleted;
        }

        private void DeleteRow1()
        {
            int index = dataGridView2.CurrentCell.RowIndex;

            dataGridView2.Rows[index].Visible = false;

            if (dataGridView2.Rows[index].Cells[0].Value.ToString() == string.Empty)
            {
                dataGridView2.Rows[index].Cells[5].Value = RowState.Deleted;
                return;
            }
            dataGridView2.Rows[index].Cells[5].Value = RowState.Deleted;
        }

        private void Update()
        {
            database.openConnection();

            for (int index = 0; index < dataGridView1.Rows.Count; index++)
            {
                var rowState = (RowState)dataGridView1.Rows[index].Cells[8].Value;


                if(rowState == RowState.Deleted)
                {
                    var id = Convert.ToInt32(dataGridView1.Rows[index].Cells[0].Value);
                    var deleteQuerry = $"delete from dbo.Client where IDClient = {id}";

                    var command = new SqlCommand(deleteQuerry, database.GetConnection());
                    command.ExecuteNonQuery();
                }

                if (rowState == RowState.Modified)
                {
                    var id = dataGridView1.Rows[index].Cells[0].Value.ToString();
                    var F = dataGridView1.Rows[index].Cells[1].Value.ToString();
                    var L = dataGridView1.Rows[index].Cells[2].Value.ToString();
                    var M = dataGridView1.Rows[index].Cells[3].Value.ToString();
                    var NumberT = dataGridView1.Rows[index].Cells[4].Value.ToString();
                    var Adds = dataGridView1.Rows[index].Cells[5].Value.ToString();
                    var IDPER = dataGridView1.Rows[index].Cells[6].Value.ToString();
                    var Mounthly = dataGridView1.Rows[index].Cells[7].Value.ToString();

                    var changeQuery = $"update dbo.Client set FirstName = '{F}', LastSurname = '{L}', MiddleName = '{M}', PhoneNumber = '{NumberT}', Adds = '{Adds}', IDPerson = '{IDPER}', MonthlyIncome = '{Mounthly}' where IDClient = '{id}'";

                    var command = new SqlCommand(changeQuery, database.GetConnection());
                    command.ExecuteNonQuery();
                }
            }

            database.closeConnection();
        }

        private void Update1()
        {
            database.openConnection();

            for (int index = 0; index < dataGridView2.Rows.Count; index++)
            {
                var rowState = (RowState)dataGridView2.Rows[index].Cells[5].Value;


                if (rowState == RowState.Deleted)
                {
                    var id = Convert.ToInt32(dataGridView2.Rows[index].Cells[0].Value);
                    var deleteQuerry = $"delete from dbo.Credit where IDCredit = {id}";

                    var command = new SqlCommand(deleteQuerry, database.GetConnection());
                    command.ExecuteNonQuery();
                }

                if (rowState == RowState.Modified)
                {
                    var id = dataGridView2.Rows[index].Cells[0].Value.ToString();
                    var idT = dataGridView2.Rows[index].Cells[1].Value.ToString();
                    var Sum = dataGridView2.Rows[index].Cells[2].Value.ToString();
                    var Date = dataGridView2.Rows[index].Cells[3].Value.ToString();
                    var IDC = dataGridView2.Rows[index].Cells[4].Value.ToString();
                    var Zero = dataGridView2.Rows[index].Cells[5].Value.ToString();

                    var changeQuery = $"update dbo.Credit set IDType = '{idT}', IDClient = '{Sum}', Summa = '{Date}', DateIssue = '{IDC}',Extradition  = '{Zero}' where IDCredit = '{id}'";

                    var command = new SqlCommand(changeQuery, database.GetConnection());
                    command.ExecuteNonQuery();
                }
            }

            database.closeConnection();
        }

        private void Change()
        {
            var selectedRowIndex = dataGridView1.CurrentCell.RowIndex;

            var id = textBox_IDClient.Text;
            var F = textBox_F.Text;
            var L = textBox_L.Text;
            var M = textBox_M.Text;
            var NumberT = textBox_NumberT.Text;
            var Adds = textBox_Adds.Text;
            var IDPER = textBox_IDPER.Text;
            var Mounthly = textBox_Mounthly.Text;

            if (dataGridView1.Rows[selectedRowIndex].Cells[0].Value.ToString() != string.Empty)
            {
                dataGridView1.Rows[selectedRowIndex].SetValues(id, F, L, M, NumberT, Adds, IDPER, Mounthly);
                dataGridView1.Rows[selectedRowIndex].Cells[8].Value = RowState.Modified;
            }
        }

        private void Change1()
        {
            var selectedRowIndex = dataGridView2.CurrentCell.RowIndex;

            var id = textBox_NewIDClient.Text;
            var idT = textBox_NewIDTC.Text;
            var Sum = textBox_NewSumma.Text;
            var Date = textBox_NewDate.Text;
            var IDC = textBox_NewIDClient.Text;
            var Zero = textBox_New0.Text;

            if (dataGridView2.Rows[selectedRowIndex].Cells[0].Value.ToString() != string.Empty)
            {
                dataGridView2.Rows[selectedRowIndex].SetValues(id, idT, Sum, Date, IDC, Zero);
                dataGridView2.Rows[selectedRowIndex].Cells[6].Value = RowState.Modified;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Search(dataGridView1);
        }

        private void textBox_Search1_TextChanged(object sender, EventArgs e)
        {
            Search1(dataGridView2);
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            DeleteRow();
            ClearFields();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Update();
        }

        private void selectButton2_Click(object sender, EventArgs e)
        {
            Change();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ClearFields();
        }


        private void deleteButton1_Click(object sender, EventArgs e)
        {
            DeleteRow1();
            ClearFields();
        }

        private void selectButton1_Click(object sender, EventArgs e)
        {
            Change1();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Update1();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form2 Okno = new Form2();
            this.Hide();
            Okno.ShowDialog();
        }
    }
}
