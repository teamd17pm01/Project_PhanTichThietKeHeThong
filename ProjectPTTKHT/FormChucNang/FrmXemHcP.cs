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
    public partial class FrmXemHcP : DevExpress.XtraEditors.XtraForm
    {
        public FrmXemHcP()
        {
            InitializeComponent();
        }

        private void txtHOCPHI_KeyUp(object sender, KeyEventArgs e)
        {
            
        }

        private void cboMIENGIAM_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtPHAIDONG.Text = Convert.ToString(Convert.ToDouble(txtHOCPHI.Text) * (1 - (Convert.ToSingle(cboMIENGIAM.Text) / 100)));
        }
    }
    }