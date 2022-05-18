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
using System.Net.Mail;
using System.Net;

namespace eXamSystem
{
    public partial class SifremiUnuttum : Form
    {
        public SifremiUnuttum()
        {
            InitializeComponent();
        }

        private void SifremiUnuttum_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            sqlBaglanti baglan = new sqlBaglanti();
            SqlCommand cmd = new SqlCommand("Select * from Users where kulladi='" + kullaniciAdi.Text.ToString() +
                    "' and eMail ='" + ePosta.Text.ToString() + "'", baglan.baglanti());
            SqlDataReader oku = cmd.ExecuteReader();
            while (oku.Read())
            {
                try
                {
                    if (baglan.baglanti().State == ConnectionState.Closed)
                    {
                        baglan.baglanti().Open();
                    }
                    SmtpClient smtpserver = new SmtpClient();
                    MailMessage mail = new MailMessage();
                    String tarih = DateTime.Now.ToShortDateString();
                    String mailadresi = ("melankofranko@gmail.com"); // maili göndereceğimiz gmail hesabımızı giriyoruz
                    String sifre = "hako1234"; // maili göndereceğimiz gmail hesabının şifresini giriyoruz
                    String smtpsrvr = "smtp.gmail.com"; // gmail serverını kullanıyoruz
                    String kime = (oku["eMail"].ToString());
                    String konu = ("Şifre Hatırlatma Maili"); // mailin konusunu giriyoruz
                    String yaz = ("Sayın, " + oku["userName"].ToString() + " " + oku["userSurname"].ToString() + ", bizden " + tarih + " tarihinde şifre hatırlatma talebinde bulundunuz." // gidecek maili giriyoruz
                   + "\n" + " Parolanız: " + oku["password"].ToString());
                    smtpserver.Credentials = new NetworkCredential(mailadresi, sifre);
                    smtpserver.Port = 587; // 587 gmail server'ıdır
                    smtpserver.Host = smtpsrvr;
                    smtpserver.EnableSsl = true;
                    mail.From = new MailAddress(mailadresi);
                    mail.To.Add(kime); // mailin kime gönderileceği belirleniyor
                    mail.Subject = konu;
                    mail.Body = yaz;
                    smtpserver.Send(mail);
                    DialogResult bilgi = new DialogResult();
                    bilgi = MessageBox.Show("Girmiş olduğunuz bilgiler uyuşuyor. Şifreniz Mail Adresinize gönderildi."); // kullanıcının girdiği bilgiler doğruysa şifrenin gönderildiğini kullanıcıya bildiriyoruz
                    Form1 form1 = new Form1();  
                    form1.Show();
                    this.Hide();
                }
                catch (Exception hata)
                {
                    MessageBox.Show("Mail gönderme hatası!" + hata.Message); // mail gönderilmezse, gönderilmeme nedenyile birlikte kullanıcıya bilgi veriyoruz
                }
            }
        }
    }
}
