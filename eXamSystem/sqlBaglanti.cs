using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace eXamSystem
{
    //@"Data Source=NATKAH;Initial Catalog = sınavSistemi; Integrated Security = True; Connect Timeout = 30; Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

    class sqlBaglanti
    {
        public SqlConnection baglanti()
        {
            SqlConnection sqlconn = new SqlConnection("Data Source=NATKAH;Initial Catalog = sınavSistemi; Integrated Security = True; Connect Timeout = 30; Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            sqlconn.Open();
            return sqlconn;
        }

    }
}
