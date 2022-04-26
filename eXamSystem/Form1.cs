using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            Ogretmen ogretmen = new Ogretmen();
            ogretmen.Show();
            this.Hide();
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
            if(txtUsername.Text =="aa" && txtSifre.Text =="22" && comboBox1.SelectedIndex== 0)
            {
                Ogretmen ogretmen = new Ogretmen();
                ogretmen.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Tekrar Dene");
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

        }
    }
}
