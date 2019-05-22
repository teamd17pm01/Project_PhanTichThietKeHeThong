using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace ProjectPTTKHT
{
    public partial class FrmCapNhat : DevExpress.XtraEditors.XtraForm
    {
        ConnectData cnt = new ConnectData();
        public FrmCapNhat()
        {
            InitializeComponent();
        }
        //create 
        string ider;
        public void getInfor(string id)
        {
            ider = id;
            MessageBox.Show("Hello" + ider);
        }
        //
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            InforSV infor = new InforSV()
            {
                Masv = ider,
                Tensv = txtHOTEN.Text,
                Ngaysinh = dtNgaysinh.Value.ToString("dd/MM/yy"),
                Quequan = txtQUEQUAN.Text,
                Dantoc = txtDANTOC.Text,
                Diachi = txtĐCTT.Text,
                Sdt = txtSĐT.Text,
                Email = txtEMAIL.Text,
                Hotencha = txtHOTENCHA.Text,
                Hotenme = txtHOTENME.Text,
                Sdtcha = txtSĐTCHA.Text,
                Sdtme = txtSĐTME.Text,
                Nghenghiepcha = txtNHGECHA.Text,
                Nghenghiepme = txtNGHEME.Text
            };
            //return infor;
            if (cnt.updateThongTin(infor))
            {
                MessageBox.Show("Update Is Success", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
            {
                MessageBox.Show("Update Is Fail", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}