using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hung
{
    public class DAL_DKMH : DBConnect
    {
        public DataTable searchByMaMH(string MaMH)
        {
            string Sql = string.Format("Select * from DKMH where MaMH = '{0}'", MaMH);
            SqlDataAdapter data = new SqlDataAdapter(Sql, Connection);
            DataTable dataDKMH = new DataTable();
            data.Fill(dataDKMH);
            return dataDKMH;
        }
    }
}
