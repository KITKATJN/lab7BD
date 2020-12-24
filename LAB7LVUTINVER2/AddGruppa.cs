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
    public partial class AddGruppa : Form
    {

        public static string connectString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=F:\\bd\\lab7bd.accdb";
        private OleDbConnection myConnection;
        public AddGruppa()
        {
            InitializeComponent();
            myConnection = new OleDbConnection(connectString);
            myConnection.Open();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int tabnum = Convert.ToInt32(textBox1.Text);
            string familia = Convert.ToString(textBox2.Text);
            int name = Convert.ToInt32(textBox3.Text);
            string query = "INSERT INTO Группа ([Номер группы],[Факультет],[Количество студентов]) VALUES(" + tabnum + ",'" + familia + "'," + name +  ")";
            OleDbCommand command = new OleDbCommand(query, myConnection);
            command.ExecuteNonQuery();
            MessageBox.Show("Группа добавлена!");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
