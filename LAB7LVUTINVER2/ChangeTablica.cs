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
    public partial class ChangeTablica : Form
    {
        public static string connectString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=F:\\bd\\lab7bd.accdb";
        private OleDbConnection myConnection;
        public ChangeTablica()
        {
            InitializeComponent();

            myConnection = new OleDbConnection(connectString);
            myConnection.Open();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Prepodavatel f2 = new Prepodavatel();
            f2.Owner = this;
            f2.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Gruppa f2 = new Gruppa();
            f2.Owner = this;
            f2.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
