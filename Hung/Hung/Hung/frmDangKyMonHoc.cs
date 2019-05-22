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
    public partial class frmDangKyMonHoc : Form
    {
        BUS_MH busMH = new BUS_MH();
        BUS_DKMH busDKMH = new BUS_DKMH();
        BUS_NV busNV = new BUS_NV();
        BUS_DSDKMH busDSDKMH = new BUS_DSDKMH();

        string id;

        public frmDangKyMonHoc()
        {
            InitializeComponent();
        }

        private void btnTimKiemMa_Click(object sender, EventArgs e)
        {
            string txtSearch = txtMaMH.Text;

            try
            {
                if (txtSearch != "")
                {
                    // Get Thông tin môn học
                    DataTable TTMH = busMH.searchByMaMH(txtSearch);

                    txtTenMH.Text = TTMH.Rows[0][2].ToString();
                    txtSoTinChi.Text = TTMH.Rows[0][3].ToString();

                    //Get danh sách lựa chọn đăng ký
                    dgvDKMH.DataSource = busDKMH.searchByMaMH(txtSearch);

                    // Get tên giảng viên
                    for (int i = 0; i < dgvDKMH.Rows.Count - 1; i++)
                    {
                        string MaNV = dgvDKMH.Rows[i].Cells[2].Value.ToString();
                        string TenNV = busNV.getTenNV(MaNV);

                        dgvDKMH.Rows[i].Cells[2].Value = TenNV;

                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập mã môn học!");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Không tìm thấy!");
            }
        }
        

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvDKMH.SelectedRows.Count > 0)
                {
                    DataGridViewRow row = dgvDKMH.SelectedRows[0];
                    int MaDKMH = int.Parse(row.Cells[0].Value.ToString());
                    string MaMH = row.Cells[1].Value.ToString();
                    var MaSV = id;
                    DTO_DSDKMH ds = new DTO_DSDKMH(0,MaDKMH, MaMH, MaSV);

                    if (busDSDKMH.checkDK(MaMH, MaSV))
                    {
                        
                        if (busDSDKMH.updateDSDKMH(ds)) {
                            loadDSDK(id);
                            MessageBox.Show("Cập nhật thành công!");
                        }
                        else
                        {
                            MessageBox.Show("Cập nhật không thành công!");
                        }
                        
                    }
                    else
                    {

                        if (busDSDKMH.insertDSDKMH(ds))
                        {
                            loadDSDK(id);
                            MessageBox.Show("Thêm thành công!");
                        }
                        else
                        {
                            MessageBox.Show("Thêm không thành công!");
                        }
                    }

                }
                else
                {
                    MessageBox.Show("Vui lòng chọn môn đăng ký!");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Cập nhật không thành công!");
            }
        }

        public void loadDSDK(string ii)
        {
            try
            {
                id = ii;
                DataTable dataDSDKMH = busDSDKMH.getDSDKMH(id);
              
                dgvDSDKMH.Rows.Clear();
                for (int i = 0; i < dataDSDKMH.Rows.Count; i++)
                {
                    string Id = dataDSDKMH.Rows[i][0].ToString();
                    string MaDKMH = dataDSDKMH.Rows[i][1].ToString();
                    string MaMH = dataDSDKMH.Rows[i][2].ToString();
                    string MaSV = dataDSDKMH.Rows[i][3].ToString();

                    DataTable dataMH = busMH.searchByMaMH(MaMH);
                    string TenMH = dataMH.Rows[0][2].ToString();
                    int SoTinChi = int.Parse(dataMH.Rows[0][3].ToString());
                    int HocPhi = SoTinChi * 200000;
                    dgvDSDKMH.Rows.Add(Id, MaDKMH, MaMH, MaSV, TenMH, SoTinChi, HocPhi);
                }
            }
            catch (Exception) { }
        }
        private void frmDangKyMonHoc_Load(object sender, EventArgs e)
        {
        }

        private void dgvDSDKMH_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvDSDKMH.SelectedRows.Count > 0)
                {
                    int Id = int.Parse(dgvDSDKMH.SelectedRows[0].Cells[0].Value.ToString());
                    dgvDSDKMH.Rows.RemoveAt(dgvDSDKMH.CurrentRow.Index);
                    busDSDKMH.delDSDKMH(Id);
                    MessageBox.Show("Xóa thành công!");
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn môn học cần xóa!");
                }
            }
            catch (Exception) { }
        }
    }
}
