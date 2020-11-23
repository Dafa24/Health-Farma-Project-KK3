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
    public partial class RegisterForm : Form
    {
        // Creating Connection With Database
        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\CRUDSHealth.accdb");
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            OleDbCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into login values('" + txtName.Text + "','" + txtPass.Text + "','" + txtEmail.Text + "')";
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Successfulyy Create Account");
            Close();
        }
    }
}
