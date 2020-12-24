using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace LAB7LVUTINVER2
{
    public partial class RazlichnyeZaprosi : Form
    {

        public static string connectString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=F:\\bd\\lab7bd.accdb";
        private OleDbConnection myConnection;
        public RazlichnyeZaprosi()
        {
            InitializeComponent();

            myConnection = new OleDbConnection(connectString);
            myConnection.Open();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM [Предмет]";
            OleDbDataAdapter command = new OleDbDataAdapter(query, myConnection);
            DataTable dt = new DataTable();
            command.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        
        private void button3_Click(object sender, EventArgs e)
        {

            string query = "SELECT  AVG([Количество студентов])  AS [Среднее количестов людей в группах] FROM Группа ";
            OleDbDataAdapter command = new OleDbDataAdapter(query, myConnection);
            DataTable dt = new DataTable();
            command.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM Занятие WHERE [Время проведения]<#12:00:00#";
            OleDbDataAdapter command = new OleDbDataAdapter(query, myConnection);
            DataTable dt = new DataTable();
            command.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int number = Convert.ToInt32(textBox1.Text);
            string query = "SELECT [Номер], [Корпус], [Этаж], [Тип аудитории], [Вместимость] FROM Аудитория WHERE [Вместимость] >" + number +" ORDER BY[Вместимость]";
            OleDbDataAdapter command = new OleDbDataAdapter(query, myConnection);
            DataTable dt = new DataTable();
            command.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string query = "EXEC [5 Аудитория к корпусу]";
            OleDbDataAdapter command = new OleDbDataAdapter(query, myConnection);
            DataTable dt = new DataTable();
            command.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void button7_Click(object sender, EventArgs e)
        {

            int number = Convert.ToInt32(textBox2.Text);
            string query = "EXEC [5 Предмет шаблон] " + number + "";
            OleDbDataAdapter command = new OleDbDataAdapter(query, myConnection);
            DataTable dt = new DataTable();
            command.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            string number = textBox3.Text;
            string query = "EXEC [5 Занятие Отсорт] '" + number + "'";
            OleDbDataAdapter command = new OleDbDataAdapter(query, myConnection);
            DataTable dt = new DataTable();
            command.Fill(dt);
            dataGridView1.DataSource = dt;

        }

        private void button9_Click(object sender, EventArgs e)
        {
            string query = "EXEC [6 запрос на обновление студентов]";
            OleDbCommand command = new OleDbCommand(query, myConnection);
            command.ExecuteNonQuery();
            string query1 = "SELECT * FROM [Группа]";
            OleDbDataAdapter command1 = new OleDbDataAdapter(query1, myConnection);
            DataTable dt = new DataTable();
            command1.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void button10_Click(object sender, EventArgs e)
        {

            string query = "EXEC [6 добавление в группу]";
            OleDbCommand command = new OleDbCommand(query, myConnection);
            command.ExecuteNonQuery();
            string query1 = "SELECT * FROM [Группа]";
            OleDbDataAdapter command1 = new OleDbDataAdapter(query1, myConnection);
            DataTable dt = new DataTable();
            command1.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            string query = "EXEC [6 удаление строки со вложенным запросом]";
            OleDbCommand command = new OleDbCommand(query, myConnection);
            command.ExecuteNonQuery();
            string query1 = "SELECT * FROM [Кафедра]";
            OleDbDataAdapter command1 = new OleDbDataAdapter(query1, myConnection);
            DataTable dt = new DataTable();
            command1.Fill(dt);
            dataGridView1.DataSource = dt;
        }
    }
}
