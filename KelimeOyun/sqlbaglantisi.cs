using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KelimeOyun
{
    internal class sqlbaglantisi
    {
        public SqlConnection baglanti()
        {
            SqlConnection baglan = new SqlConnection("Data Source=DESKTOP-3LIF7PH\\SQLEXPRESS;Initial Catalog=KelimeOyunu;Integrated Security=True");
            return baglan;
        }
    }
}
