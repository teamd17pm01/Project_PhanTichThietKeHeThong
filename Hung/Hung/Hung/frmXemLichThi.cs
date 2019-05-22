using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hung
{
    public partial class frmXemLichThi : Form
    {
        BUS_DSDKMH busDSDKMH = new BUS_DSDKMH();
        BUS_DKMH busDKMH = new BUS_DKMH();
        BUS_MH busMH = new BUS_MH();
        public frmXemLichThi()
        {
            InitializeComponent();
        }
        private void loadLichThi(string masv)
        {
            dgvLT.Rows.Clear();
            DataTable dataDSDKMH = busDSDKMH.getDSDKMH(masv);
            for (int i = 0; i < dataDSDKMH.Rows.Count; i++)
            {
                string Id = dataDSDKMH.Rows[i][0].ToString();
                string MaDK = dataDSDKMH.Rows[i][1].ToString();
                string MaMH = dataDSDKMH.Rows[i][2].ToString();

                DataTable dataMH = busMH.searchByMaMH(MaMH);
                string TenMH = dataMH.Rows[0][2].ToString();
                string MaSV = dataDSDKMH.Rows[i][3].ToString();
                string date = "";
                string time = "7:00";
                string PhongThi = "";

                DataTable dataDKMH = busDKMH.searchByMaMH(MaMH);
                date = dataDKMH.Rows[0][8].ToString();
                PhongThi = dataDKMH.Rows[0][3].ToString();

                dgvLT.Rows.Add(Id, MaDK, MaMH, TenMH, MaSV, date, time, PhongThi);
            }
        }
        private void frmXemLichThi_Load(object sender, EventArgs e)
        {
            loadLichThi("SV001");
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            string MaSV = txtSearch.Text;
            loadLichThi(MaSV);
        }
    }
}
