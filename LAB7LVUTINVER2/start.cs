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
    public partial class start : Form
    {
        public static string connectString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=F:\\bd\\lab7bd.accdb";
        private OleDbConnection myConnection;
        public start()
        {
            InitializeComponent();
            myConnection = new OleDbConnection(connectString);
            myConnection.Open();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            ChangeTablica f2 = new ChangeTablica();
            f2.Owner = this;
            f2.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MsysObject f3 = new MsysObject();
            f3.Owner = this;
            f3.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            RazlichnyeZaprosi f4 = new RazlichnyeZaprosi();
            f4.Owner = this;
            f4.Show();
        }
    }
}
