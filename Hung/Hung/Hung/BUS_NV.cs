using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hung
{
    public class BUS_NV
    {
        DAL_NV dalNV = new DAL_NV();
        public string getTenNV(string MaNV)
        {
            return dalNV.getTenNV(MaNV);
        }
    }
}
