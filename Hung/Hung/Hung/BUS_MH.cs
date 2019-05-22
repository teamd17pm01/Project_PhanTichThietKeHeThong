using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hung
{
    public class BUS_MH
    {
        DAL_MH dalMH = new DAL_MH();
        public DataTable searchByMaMH(string MaMH)
        {
            return dalMH.searchByMaMH(MaMH);
        }
    }
}
