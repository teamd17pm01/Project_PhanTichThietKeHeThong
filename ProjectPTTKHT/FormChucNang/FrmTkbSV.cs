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
    public partial class FrmTkbSV : DevExpress.XtraEditors.XtraForm
    {
        ConnectData func = new ConnectData();
        public FrmTkbSV()
        {
            InitializeComponent();
        }

        //Create method
        //Thoi khoa bieu chi tiet  Delegate tu
        public void loadTkb(string id)
        {
            lstTKBChitiet.DataSource = func.getTKB(id);
        }

        //Method create by 
    }
}