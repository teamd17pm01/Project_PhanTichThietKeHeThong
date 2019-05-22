using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ProjectPTTKHT
{
    public class ConnectData
    {
        public  SqlConnection cn = new SqlConnection(@"Data Source=DESKTOP-16PLU27\SQLEXPRESS;Initial Catalog=QLHT;Integrated Security=True");


        //Thoi Khoa Bieu
        public DataTable getTKB(string id)
        {
            cn.Open();
            string sql = string.Format("select MAMH,TENMH,TENGV,PHONG, TENLOPHOC,TIETBD,SOLUONGTIET,TGBD from tbl_tkb tkb,tbl_giaovien gv where IDUSER='{0}' and tkb.MAGV=gv.MAGV", id);
            SqlCommand cmd = new SqlCommand(sql,cn);
            SqlDataAdapter adapt = new SqlDataAdapter(cmd);
            DataTable tbl = new DataTable();
            adapt.Fill(tbl);
            return tbl;
        }

        public DataTable getTkbGv(string id)
        {
            cn.Open();
            string sql = string.Format("select MAMH, TENMH, TIETBD, SOLUONGTIET, TGBD, PHONG from tbl_tkb where MAGV='{0}'", id);
            SqlDataAdapter adapter = new SqlDataAdapter(sql, cn);
            DataTable tbl = new DataTable();
            adapter.Fill(tbl);
            return tbl;
        }



        //User
        public string ktUser(string user,string pass)
        {
            string id = "";
            try
            {
                cn.Open();
                string sql = string.Format("select * from tbl_user where USERNAME='{0}' and PASSWORD='{1}'",user,pass);
                SqlCommand cmd = new SqlCommand(sql,cn);
                SqlDataAdapter adapt = new SqlDataAdapter(cmd);
                DataTable data = new DataTable();
                adapt.Fill(data);
                if (data != null)
                {
                    foreach(DataRow row in data.Rows)
                    {
                        id = row["ID"].ToString();
                    }
                }
              
            }
            catch(Exception ex)
            {
                MessageBox.Show("" + ex);
            }
            finally
            {
                cn.Close();
            }
            return id;
        }
        public bool ktTonTai(string username, string pass)
        {
            try
            {
                cn.Open();
                string sql = string.Format("select ID from tbl_user where USERNAME='{0}' and PASSWORD='{1}'", username, pass);
                SqlCommand cmd = new SqlCommand(sql, cn);
                SqlDataReader read = cmd.ExecuteReader();
                if (read.Read())
                {
                    return true;
                }
            }
            catch
            {

            }
            finally
            {
                cn.Close();
            }
            return false;
        }

        //Phan Quyen
        public string phanQuyen(string id)
        {
            string per="";
            try
            {
                cn.Open();
                string sql = string.Format("select * from tbl_user where ID='{0}'", id);
                SqlCommand cmd = new SqlCommand(sql, cn);
                SqlDataAdapter adapt = new SqlDataAdapter(cmd);
                DataTable data = new DataTable();
                adapt.Fill(data);
                if (data != null)
                {
                    foreach (DataRow row in data.Rows)
                    {
                        per = row["PERMISS"].ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }
            finally
            {
                cn.Close();
            }
            return per;
        }


        //Cap nhat thong tin sinh vien
        public bool updateThongTin(InforSV infor)
        {
            try
            {
                cn.Open();
                string sql = string.Format("UPDATE tbl_infor set TENSV='{0}',NGAYSINH='{1}',QUEQUAN='{2}',DANTOC='{3}'" +
                    ",DIACHI='{4}',SDT='{5}',EMAIL='{6}',HOTENCHA='{7}',HOTENME='{8}',SDTCHA='{9}',SDTME='{10}'" +
                    ",NGHENGHIEPCHA='{11}',NGHENGHIEPME='{12}' WHERE MASV='{13}'", infor.Tensv, infor.Ngaysinh, infor.Quequan
                    , infor.Dantoc, infor.Diachi, infor.Sdt, infor.Email, infor.Hotencha, infor.Hotenme, infor.Sdtcha, infor.Sdtme,
                    infor.Nghenghiepcha, infor.Nghenghiepme, infor.Masv);
                SqlCommand cmd = new SqlCommand(sql, cn);
                cmd.ExecuteNonQuery();
                return true;
            }
            catch(Exception ex)
            {
                MessageBox.Show("" + ex);
            }
            finally
            {
                cn.Close();
            }
            return false;
        }

        //Kiem Tra Hoc Ki
    }
    
}
