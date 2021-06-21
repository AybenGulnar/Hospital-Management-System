using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Linq;

namespace Proje_Hastane
{
    class SqlBaglantisi
    {
        public SqlConnection baglanti()
    {
            SqlConnection baglan = new SqlConnection("Data Source= DESKTOP-QE05UM2\\SQLEXPRESS;Initial Catalog=HastaneProje;Integrated Security=True");
            baglan.Open();
            return baglan;

        }


    }
}
