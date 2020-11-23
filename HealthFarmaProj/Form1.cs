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

namespace HealthFarmaProj
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Creating Connection With Database
            OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\CRUDSHealth.accdb");

            // Create Data Adapter
            OleDbDataAdapter da = new OleDbDataAdapter("select count(*) from login where username= '" + txtusername.Text + "' and password = '" + txtpass.Text + "'  ", con);

            //Create Datatable
            DataTable dt = new DataTable();

            //fill database
            da.Fill(dt);
            if (dt.Rows[0][0].ToString() == "1")
            {
                //If Correct
                HomePage h2 = new HomePage();
                h2.Show();
                this.Hide();
            }
            else
            {
                //If Incorrect
                MessageBox.Show("invalid username or password, Please Try Again....");
            }
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Application.Exit();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RegisterForm r2 = new RegisterForm();
            r2.Show();
        }
    }
}
