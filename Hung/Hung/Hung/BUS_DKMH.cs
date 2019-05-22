using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hung
{
    public class BUS_DKMH
    {
        DAL_DKMH dalDKMH = new DAL_DKMH();
        public DataTable searchByMaMH(string MaMH)
        {
            return dalDKMH.searchByMaMH(MaMH);
        }
    }
}
