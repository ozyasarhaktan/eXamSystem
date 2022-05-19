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
using System.IO;

namespace eXamSystem
{
    public partial class Sinav : Form
    {
        public Sinav()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source = NATKAH; Initial Catalog = sınavSistemi; Integrated Security = True; Connect Timeout = 30; Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
      void SoruGetir()
        {
            string getir = "Select top 10 Soru, soruID from Questions order by newid()";
            DataTable tbl = new DataTable();
            SqlDataAdapter adtr = new SqlDataAdapter(getir,baglanti);
            adtr.Fill(tbl);
            dataGridView1.DataSource = tbl;
                }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string sorgu = "select Top 10 Soru, soruID from Questions order by newid()";


            SqlCommand komut = new SqlCommand(sorgu,baglanti);
            baglanti.Open();
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                if (dr["Soru"] != null)
                {
                    byte[] resim = new byte[0];
                    resim = (byte[])dr["Soru"];
                    MemoryStream memoryStream = new MemoryStream(resim);
                    pictureBox1.Image = Image.FromStream(memoryStream);
                    dr.Close();
                    komut.Dispose();
                }

                baglanti.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SoruGetir();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string sorgu = "insert into Cevaplar(Cevap, soruID) values(@yanit, @id)";
            SqlCommand komut = new SqlCommand(sorgu, baglanti);
            baglanti.Open();
            string cevap; // öğrencinin verdiği cevabın tutullacağı değişkeni tanımlıyoruz 
            // öğrenci hangi şıkkı seçmiş onu belirliyoruz aşağıda
            if (radioButton1.Checked)
                cevap = radioButton1.Text;
            else if (radioButton2.Checked)
                cevap = radioButton2.Text;
            else if (radioButton2.Checked)
                cevap = radioButton3.Text;
            else
                cevap = radioButton4.Text;


            komut.Parameters.AddWithValue("@yanit", cevap); // öğrencinin verdiği cevap kaydedildi
            komut.Parameters.AddWithValue("@İD", Convert.ToInt32(dataGridView1.CurrentRow.Cells["soruID"].Value.ToString()));

            komut.ExecuteNonQuery();
            MessageBox.Show("Yanıtınız kaydedildi.");
            baglanti.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
