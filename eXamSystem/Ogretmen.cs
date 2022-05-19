using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eXamSystem
{
    public partial class Ogretmen : Form
    {
        public Ogretmen()
        {
            InitializeComponent();
            
        }
        
        private void button7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Ogretmen_Load(object sender, EventArgs e)
        {
            pnlSoruEkle.Visible = false;
            //panel3.Visible = false;

        }

        private void btnSoruEkle_Click(object sender, EventArgs e)
        {
            pnlSoruEkle.Visible = true;


        }

        private void btnCıkıs_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();

        }
        string imagepath;
        private void btnEkle_Click(object sender, EventArgs e)
        {

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox2.Image = Image.FromFile(openFileDialog1.FileName);
                imagepath = openFileDialog1.FileName;
            }

        }
        private string connStr = @"Data Source=NATKAH;Initial Catalog = sınavSistemi; Integrated Security = True; Connect Timeout = 30; Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        private void btnKaydet_Click(object sender, EventArgs e)
        {

            try
            {
                FileStream fileStream = new FileStream(imagepath, FileMode.Open, FileAccess.Read);
                BinaryReader binaryReader = new BinaryReader(fileStream);
                byte[] resim = binaryReader.ReadBytes((int)fileStream.Length);
                binaryReader.Close();
                fileStream.Close();


                SqlConnection sqlcon = new SqlConnection(connStr);
                SqlCommand cmd = new SqlCommand("insert into Questions (uniteNo,uniteAd,konuNo,konuAd,soruNo,dersAd,cevap,sınıfDuzey,soru) values (@uniteNo,@uniteAd,@konuNo,@konuAd,@soruNo,@dersAd,@cevap, @sınıfDuzey,@soru)", sqlcon);
                sqlcon.Open();
                cmd.Parameters.AddWithValue("uniteNo", Convert.ToInt32(txtunıteNo.Text));
                cmd.Parameters.AddWithValue("uniteAd", txtuniteAd.Text);
                cmd.Parameters.AddWithValue("konuNo", Convert.ToInt32(txtkonuNo.Text));
                cmd.Parameters.AddWithValue("soruNo", Convert.ToInt32(txtsoruNo.Text));
                cmd.Parameters.AddWithValue("sınıfDuzey", Convert.ToInt32(txtsinifDuzeyi.Text));
                cmd.Parameters.AddWithValue("dersAd", txtdersAd.Text);
                cmd.Parameters.AddWithValue("konuAd", txtkonuAd.Text);
                cmd.Parameters.AddWithValue("cevap", txtCevap.Text);
                cmd.Parameters.Add("@soru", SqlDbType.Image, resim.Length).Value = resim;

                cmd.ExecuteNonQuery();
                sqlcon.Close();
                MessageBox.Show("soru eklendi");
            }
            catch (Exception ex)
            {

                throw ex;
                MessageBox.Show("Tekrar Dene");
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Ogretmen ogretmen = new Ogretmen();
            ogretmen.Show();
            pnlSoruEkle.Visible = false;
            button1.Hide();
        }

        private void btnSoruSil_Click(object sender, EventArgs e)
        {
            SoruSilme soruSilme = new SoruSilme();
            soruSilme.Show();
            Ogretmen ogretmen = new Ogretmen();
            ogretmen.Hide();
            this.Hide();
        }
    }
    }

