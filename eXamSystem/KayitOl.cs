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
       private string connStr = @"Data Source=NATKAH;Initial Catalog=examSystem;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        private void btnKayitTamamla_Click(object sender, EventArgs e)
        {
            SqlConnection sqlcon = new SqlConnection(connStr);
            SqlCommand cmd = new SqlCommand("insert into Users (userName,userSurname,eMail,password,userTypeID,kullAdi");
            //cmd.Parameters.Add("userName", txtIsim);
            //cmd.Parameters.Add("userSurname", txtSoyisim);
            //cmd.Parameters.Add("eMail", txtEmail);
            //cmd.Parameters.Add("password", txtPassword);
            //cmd.Parameters.Add("kullAdi", txtkullAdi);

        }
    }
}
