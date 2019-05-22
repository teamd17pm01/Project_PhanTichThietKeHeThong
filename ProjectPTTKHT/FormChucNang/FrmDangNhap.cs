using System;
using System.Windows.Forms;

namespace ProjectPTTKHT
{
    public partial class FrmDangNhap : Telerik.WinControls.UI.RadForm
    {

        ConnectData connect = new ConnectData();
        FrmMain main = new FrmMain();
        FrmTkbSV sv = new FrmTkbSV();
        string user, pass;
        public FrmDangNhap()
        {
            InitializeComponent();
        }
        //Create 
        public void FrmA(FrmMain frm) {
            main = frm;
        }
        //Create By System
        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (connect.ktTonTai(txtUserName.Text, txtMK.Text)) {
                user = txtUserName.Text;
                pass = txtMK.Text;
                string id = connect.ktUser(txtUserName.Text, txtMK.Text);
                if (id!="")
                {
                    string per = connect.phanQuyen(id);
                    main.getPer(per);
                    main.gerId(id);
                    this.Hide();
                    if (per == "True")
                    {
                        main.offLogin(false, true, true, true,true,true,true);
                    }
                    else
                    {
                        main.offLogin(false, true, true, false,false,false,false);
                    }
                }
            }
            else
            {
                MessageBox.Show("Password or Username were wrong!!!", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
