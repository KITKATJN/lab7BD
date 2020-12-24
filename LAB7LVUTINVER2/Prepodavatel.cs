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
    public partial class Prepodavatel : Form
    {
        public static string connectString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=F:\\bd\\lab7bd.accdb";
        private OleDbConnection myConnection;
        public Prepodavatel()
        {
            InitializeComponent();
            myConnection = new OleDbConnection(connectString);
            myConnection.Open();
        }

        private void Form1_Load(object sender, EventArgs e) {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "lab7bdDataSet.Преподаватель". При необходимости она может быть перемещена или удалена.
            this.преподавательTableAdapter.Fill(this.lab7bdDataSet.Преподаватель);
        }
        private void show()
        {
            string query = "SELECT * FROM Преподаватель";
            OleDbDataAdapter command = new OleDbDataAdapter(query, myConnection);
            DataTable dt = new DataTable();
            command.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            myConnection.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int tabnumber = Convert.ToInt32(textBox1.Text);
            string query = "DELETE FROM Преподаватель WHERE [Табельный номер] = " + tabnumber;
            OleDbCommand command = new OleDbCommand(query, myConnection);
            command.ExecuteNonQuery();
            MessageBox.Show("Преподаватель отправлен на пенсию!\n(Таблица обновлена)");
            show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int kod = Convert.ToInt32(textBox2.Text);
            string familia = Convert.ToString(textBox3.Text);
            string query = "UPDATE Преподаватель SET [Фамилия преподавателя] ='" + familia + "' WHERE [Табельный номер ] = " + kod;
            OleDbCommand command = new OleDbCommand(query, myConnection);
            command.ExecuteNonQuery();
            MessageBox.Show("Преподаватель поменял фамилию!");

            show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AddPrepodavatel f2 = new AddPrepodavatel();
            f2.Owner = this;
            f2.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
