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
using System.Data.SqlClient;

namespace LAB7LVUTINVER2
{
    public partial class Gruppa : Form
    {
        public static string connectString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=F:\\bd\\lab7bd.accdb";
        private OleDbConnection myConnection;
        public Gruppa()
        {
            InitializeComponent();
            myConnection = new OleDbConnection(connectString);
            myConnection.Open();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "lab7bdDataSet.Группа". При необходимости она может быть перемещена или удалена.
            this.группаTableAdapter.Fill(this.lab7bdDataSet.Группа);
        }
        private void show()
        {
            string query = "SELECT * FROM Группа";
            OleDbDataAdapter command = new OleDbDataAdapter(query, myConnection);
            DataTable dt = new DataTable();
            command.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            show();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            int kod = Convert.ToInt32(textBox2.Text);
            int kolvo = Convert.ToInt32(textBox3.Text);
            string query = "UPDATE Группа SET [Количество студентов] =" + kolvo + " WHERE [Номер группы] =" + kod;
            OleDbCommand command = new OleDbCommand(query, myConnection);
            command.ExecuteNonQuery();
            MessageBox.Show("Количестов студентов изменено!");

            show();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            int tabnumber = Convert.ToInt32(textBox1.Text);
            string query = "DELETE FROM Группа WHERE [Номер группы] = " + tabnumber;
            OleDbCommand command = new OleDbCommand(query, myConnection);
            command.ExecuteNonQuery();
            MessageBox.Show("Вся группа отчислена!");
            show();
        }

        private void button4_Click(object sender, EventArgs e)
        {

            AddGruppa f2 = new AddGruppa();
            f2.Owner = this;
            f2.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
