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
    public partial class ShowData : Form
    {
        // Creating Connection With Database
        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\CRUDSHealth.accdb");
        public ShowData()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            string printah = "select * from addcrud ";
            OleDbDataAdapter da = new OleDbDataAdapter(printah, con);
            DataTable dt = new DataTable();
            //OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            da.Fill(dt);

            dataGridView1.DataSource = dt;

            con.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            HomePage h2 = new HomePage();
            h2.Show();
            this.Hide();
        }
    }
}
