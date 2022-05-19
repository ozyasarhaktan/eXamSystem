using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace eXamSystem
{
    public partial class SoruSilme : Form
    {
        public SoruSilme()
        {
            InitializeComponent();
        }

        void SorularıGetir()
        {
            DataTable tbl = new DataTable();
            SqlDataAdapter adtr = new SqlDataAdapter("Select * from Questions", baglanti);
            adtr.Fill(tbl);
            dataGridView1.DataSource = tbl;
        }

        SqlConnection baglanti = new SqlConnection(@"Data Source = NATKAH; Initial Catalog = sınavSistemi; Integrated Security = True; Connect Timeout = 30; Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            private void button1_Click(object sender, EventArgs e)
        {
            string sorgu = "Delete from Questions where soruID=@id";
            baglanti.Open();
            SqlCommand komut = new SqlCommand(sorgu, baglanti);
            komut.Parameters.AddWithValue("@id", dataGridView1.CurrentRow.Cells["soruID"].Value);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Soru kaldırıldı.");

            SorularıGetir();
        }
        
        private void SoruSilme_Load(object sender, EventArgs e)
        {
            SorularıGetir();
        }
    }
}
