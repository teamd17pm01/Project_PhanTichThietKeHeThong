using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars;
using Hung;

namespace ProjectPTTKHT
{
    public partial class FrmMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        //Delegates
        public delegate void FrmA(FrmMain a);
        public delegate void SendId(string a);

        FrmA frma;
        SendId send;

        //
        FrmTkbGV gv;
        FrmTkbSV sv;
        FrmCapNhat capnhat;
        FrmXemHcP hp;
        FrmDangNhap login;
        frmDangKyMonHoc dkmh;
        frmXemLichThi xemlich;
        //

        private string ider,permis,userName;

        public FrmMain()
        {
            InitializeComponent();
        }
        //Create
        public void getPer(string per)
        {
            permis = per;
        }
        public void gerId(string id)
        {
            ider = id;
        }
        private bool CheckExistForm(string nameform)
        {
            //bool check = false;
            foreach (var frm in this.MdiChildren)
            {
                if (frm.Name == nameform)
                {
                    frm.Activate();
                    return true;
                }
            }

            return false;
        }
        public void offLogin(bool dangnhap,bool dangxuat,bool xemtkb,bool xemhp,bool capnhat,bool dangky, bool xemlich)
        {
            btnDangNhap.Enabled = dangnhap;
            btnDangXuat.Enabled = dangxuat;
            btnXemTKB.Enabled = xemtkb;
            btnCapNhatThongTin.Enabled = capnhat;
            btnXemHP.Enabled = xemhp;
            btnXemLichThi.Enabled = xemlich;
            btnDKMH.Enabled = dangky;
        }
        //Create by System

        private void btnXemTKB_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (permis=="False")
            {
                if (!CheckExistForm("FrmtkbGV"))
                {
                    gv = new FrmTkbGV();
                    gv.MdiParent = this;
                    gv.Show();
                    gv.load_TKB(ider);
                }
            }
            else
            {
                if (!CheckExistForm("FrmtkbSV"))
                {
                    sv = new FrmTkbSV();
                    sv.MdiParent = this;
                    sv.Show();
                    sv.loadTkb(ider);
                }
            }
        }

        private void btnDangNhap_ItemClick(object sender, ItemClickEventArgs e)
        {
            login = new FrmDangNhap();
            frma = new FrmA(login.FrmA);
            frma(this);
            login.ShowDialog();
           
        }

        private void btnXemHP_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (!CheckExistForm("FrmXemHcP"))
            {
                hp = new FrmXemHcP();
                hp.MdiParent = this;
                hp.Show();
            }
        }

        private void btnCapNhatThongTin_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (!CheckExistForm("FrmCapNhat"))
            {
                capnhat = new FrmCapNhat();
                capnhat.MdiParent = this;
                capnhat.Show();
                send = new SendId(capnhat.getInfor);
                send(ider);
            }
        }

        private void btnDKMH_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (!CheckExistForm("frmDangKyMonHoc"))
            {
                dkmh = new frmDangKyMonHoc();
                dkmh.MdiParent = this;
                dkmh.Show();
                send = new SendId(dkmh.loadDSDK);
                send(ider);
            }
        }

        private void btnXemLichThi_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (!CheckExistForm("frmXemLichThi"))
            {
                xemlich = new frmXemLichThi();
                xemlich.MdiParent = this;
                xemlich.Show();
            }
        }

        private void btnDangXuat_ItemClick(object sender, ItemClickEventArgs e)
        {
            DialogResult re = MessageBox.Show("Bạn Muốn Đăng Xuất", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (re == DialogResult.Yes)
            {
                foreach (Form mdiform in this.MdiChildren)
                {
                    mdiform.Close();
                }
                this.offLogin(true, false, false,false,false,false,false);
            }
        }
    }
}