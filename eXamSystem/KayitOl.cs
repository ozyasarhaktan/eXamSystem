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
    public partial class KayitOl : Form
    {
        public KayitOl()
        {
            InitializeComponent();
        }
        private void btnKayitTamamla_Click(object sender, EventArgs e)
        {
            Users users = new Users();
            users.Isim = txtIsim.Text;
            users.Soyisim = txtSoyisim.Text;  
            users.Email = txtEmail.Text;
            users.password = txtPassword.Text;
            users.kullAdi = txtkullAdi.Text;
            users.userType = comboBox1.SelectedIndex;

            try
            {
                users.PersonelKayıtEt();
                MessageBox.Show("Kişi Eklendi.");
                Form1 form = new Form1();
                form.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show("İşlem Başarısız!");
                throw ex ;
            }
         
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
            this.Close();
        }
    }
}
