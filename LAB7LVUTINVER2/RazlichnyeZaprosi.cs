﻿using System;
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
    }
}
