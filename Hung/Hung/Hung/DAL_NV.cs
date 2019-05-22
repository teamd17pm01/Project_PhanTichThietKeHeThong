using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hung
{
    public class DAL_NV : DBConnect
    {
        public string getTenNV(string MaNV)
        {
            string Sql = string.Format("Select TenNV from NhanVien where MaNV = '{0}'", MaNV);
            SqlDataAdapter data = new SqlDataAdapter(Sql, Connection);
            DataTable dataDKMH = new DataTable();
            data.Fill(dataDKMH);
            return dataDKMH.Rows[0][0].ToString();
        }
    }
}
