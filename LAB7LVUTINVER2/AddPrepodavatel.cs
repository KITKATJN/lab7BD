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
    public partial class AddPrepodavatel : Form
    {
        public static string connectString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=F:\\bd\\lab7bd.accdb";
        private OleDbConnection myConnection;
        public AddPrepodavatel()
        {
            InitializeComponent();
            myConnection = new OleDbConnection(connectString);
            myConnection.Open();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int tabnum = Convert.ToInt32(textBox1.Text);
            string familia = Convert.ToString(textBox2.Text);
            string name = Convert.ToString(textBox3.Text);
            string otchestvo = Convert.ToString(textBox4.Text);
            string dolznost = Convert.ToString(textBox5.Text);
            string stazh = Convert.ToString(textBox6.Text);
            int indkafedr = Convert.ToInt32(textBox7.Text);
            string query = "INSERT INTO Преподаватель ([Табельный номер],[Фамилия преподавателя],[Имя преподавателя],[Отчество преподавателя],[Должность преподавателя],[Стаж работы],[Идентификатор кафедры]) VALUES(" + tabnum + ",'" + familia + "','" + name + "','" + otchestvo + "','" + dolznost + "','" + stazh + "'," + indkafedr + ")";
            OleDbCommand command = new OleDbCommand(query, myConnection);
            command.ExecuteNonQuery();
            MessageBox.Show("Преподаватель добавлен!");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            myConnection.Close();
        }
    }
}
