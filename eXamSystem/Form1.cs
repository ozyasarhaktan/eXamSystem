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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox1.Checked==true)
            {
                txtSifre.PasswordChar = '\0';
                checkBox1.Text = "Şifre Gizle"; 
            }  
            else
            {
                txtSifre.PasswordChar = '*';
                checkBox1.Text = "Şifre Göster";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string kullAdi = txtUsername.Text;
            string kullSifre = txtSifre.Text;
            
            sqlBaglanti sqlBaglanti = new sqlBaglanti();
            sqlBaglanti.baglanti();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = sqlBaglanti.baglanti();

            cmd.CommandText = "select * from Users where kulladi= '" + txtUsername.Text +
                "' and password= '" + txtSifre.Text + "' and userTypeID ='" +comboBox1.SelectedIndex+"'";
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                if(comboBox1.SelectedIndex == 1)
                {
                    MessageBox.Show("Admin Ekranı");
                }
                
                else if (comboBox1.SelectedIndex == 2)
                {
                    MessageBox.Show("Öğrenci Ekranı");
                    Ogrenci ogrenci = new Ogrenci();
                    ogrenci.Show();
                    this.Hide();
                }
                    
                else if (comboBox1.SelectedIndex == 3)
                {
                    MessageBox.Show("Öğretmen Ekranı");
                    Ogretmen ogretmen = new Ogretmen();
                    ogretmen.Show();
                    this.Hide();
                }
                    
            }
            else
            {
                MessageBox.Show("Kullanıcı adı , şifre veya kullanıcı tipi hatalı olabilir !");
            }
            
        }

        private void lblSifreUnutma_Click(object sender, EventArgs e)
        {
            SifremiUnuttum sifremiUnuttum = new SifremiUnuttum(); 
            sifremiUnuttum.Show();
            this.Hide();
        }

        private void btnKayitOl_Click(object sender, EventArgs e)
        {
            KayitOl kayitOl = new KayitOl();
            kayitOl.Show();
            this.Hide();
        }
    }
}
