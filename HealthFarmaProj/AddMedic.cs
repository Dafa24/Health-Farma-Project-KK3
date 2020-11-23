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
    public partial class AddMedic : Form
    {
        // Creating Connection With Database
        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\CRUDSHealth.accdb");
        public AddMedic()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            String printah = "INSERT INTO addcrud(Kode, Nama, Harga, Stok) values ('" + txtKode.Text + "', '" + txtNama.Text + "', '" + txtHarga.Text + "', '" + txtStok.Text + "')";
            OleDbCommand cmd = new OleDbCommand(printah, con);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Obat Berhasil Ditambahkan");
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Application.Exit();
        }

        private void txtKode_TextChanged(object sender, EventArgs e)
        {

        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            HomePage h2 = new HomePage();
            h2.Show();
            this.Hide();
        }
    }
}
