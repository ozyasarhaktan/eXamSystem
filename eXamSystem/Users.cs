using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eXamSystem
{
    internal class Users
    {
        public string Isim { get; set; }
        public string Soyisim { get; set; }
        public string Email { get; set; }
        public string kullAdi { get; set; }
        public string password { get; set; }
        public int userType { get; set; }

        private string connStr = @"Data Source=NATKAH;Initial Catalog = sınavSistemi; Integrated Security = True; Connect Timeout = 30; Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        public void PersonelKayıtEt()
        {

            SqlConnection sqlcon = new SqlConnection(connStr);
            SqlCommand cmd = new SqlCommand("insert into Users (userName,userSurname,eMail,password,userTypeID,kullAdi) values (@userName,@userSurname,@eMail,@password,@userTypeID,@kullAdi )", sqlcon);
            sqlcon.Open();
            cmd.Parameters.AddWithValue("userName", Isim);
            cmd.Parameters.AddWithValue("userSurname", Soyisim);
            cmd.Parameters.AddWithValue("eMail", Email);
            cmd.Parameters.AddWithValue("password", password);
            cmd.Parameters.AddWithValue("kullAdi", kullAdi);
            cmd.Parameters.AddWithValue("userTypeID", userType);
            cmd.ExecuteNonQuery();
            sqlcon.Close();
        }
    }


}
