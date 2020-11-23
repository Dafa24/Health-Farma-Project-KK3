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
    public partial class JoinMember : Form
    {
        // Creating Connection With Database
        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\CRUDSHealth.accdb");
        public JoinMember()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            String perintah = "INSERT INTO member(Nama,Email,Telp,Alamat) values ('" + txtName.Text + "', '" + txtEmail.Text + "', '" + txtNumber.Text + "', '" + txtAddress.Text + "')";
            OleDbCommand cmd = new OleDbCommand(perintah, con);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Anda sudah menjadi member sekarang !");
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            HomePage h2 = new HomePage();
            h2.Show();
            this.Hide();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            HomePage h2 = new HomePage();
            h2.Show();
            this.Hide();    
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
