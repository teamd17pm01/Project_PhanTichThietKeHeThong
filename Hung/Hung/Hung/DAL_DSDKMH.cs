using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hung
{
    public class DAL_DSDKMH : DBConnect
    {
        public DataTable getDSDKMH(string MaSV)
        {
            string sql = string.Format("Select * from DSDKMH where MaSV = '{0}'", MaSV);
            SqlDataAdapter data = new SqlDataAdapter(sql,Connection);
            DataTable dataDSDKMH = new DataTable();
            data.Fill(dataDSDKMH);
            return dataDSDKMH;
        }
        public bool insertDSDKMH(DTO_DSDKMH ds)
        {
            try
            {
                Connection.Open();
                string SQL = string.Format("Insert into DSDKMH (MaDKMH, MaMH, MaSV) values ('{0}','{1}','{2}')",ds.MaDKMH, ds.MaMH, ds.MaSV);

                SqlCommand cmd = new SqlCommand(SQL, Connection);

                if (cmd.ExecuteNonQuery() > 0)
                    return true;
            }
            catch (Exception) { }
            finally {
                Connection.Close();
            }
            return false;
        }
        public bool updateDSDKMH(DTO_DSDKMH ds)
        {
            try
            {
                Connection.Open();
                string SQL = string.Format("Update DSDKMH set MaDKMH = '{0}', MaMH = '{1}', MaSV = '{2}' where MaMH = '{1}' and MaSV = '{2}'", ds.MaDKMH, ds.MaMH, ds.MaSV, ds.Id);

                SqlCommand cmd = new SqlCommand(SQL, Connection);
                if (cmd.ExecuteNonQuery() > 0)
                    return true;
            }
            catch (Exception) { }
            finally { Connection.Close(); }
            return false;
        }
        public bool checkDK(string MaMH, string MaSV)
        {
            try
            {
                Connection.Open();
                string SQL = string.Format("Select Id from DSDKMH where MaMH = '{0}' and MaSV = '{1}'", MaMH, MaSV);

                SqlCommand cmd = new SqlCommand(SQL, Connection);
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                    return true;
            }
            catch (Exception) { }
            finally
            {
                Connection.Close();
            }
            return false;
        }
        public bool delDSDKMH(int Id)
        {
            try
            {
                int a = 0;
                Connection.Open();
                string SQL = string.Format("Delete from DSDKMH where Id = '{0}'", Id);

                SqlCommand cmd = new SqlCommand(SQL, Connection);

                if (cmd.ExecuteNonQuery() > 0)
                    return true;
            }
            catch (Exception) { }
            finally
            {
                Connection.Close();
            }
            return false;
        }
    }
}
