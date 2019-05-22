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
    public partial class FrmTkbGV : DevExpress.XtraEditors.XtraForm
    {
        ConnectData connect = new ConnectData();
        public FrmTkbGV()
        {
            InitializeComponent();
        }
        public void load_TKB(string id)
        {
            lstTKBGv.DataSource = connect.getTkbGv(id);
        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void groupControl2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}