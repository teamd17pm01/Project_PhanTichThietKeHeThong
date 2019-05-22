using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hung
{
    public class BUS_DSDKMH
    {
        DAL_DSDKMH dalDSDKMH = new DAL_DSDKMH();
        public DataTable getDSDKMH(string MaSV)
        {
            return dalDSDKMH.getDSDKMH(MaSV);
        }
        public bool insertDSDKMH(DTO_DSDKMH ds)
        {
            return dalDSDKMH.insertDSDKMH(ds);
        }
        public bool updateDSDKMH(DTO_DSDKMH ds)
        {
            return dalDSDKMH.updateDSDKMH(ds);
        }
        public bool checkDK(string MaMH, string MaSV)
        {
            return dalDSDKMH.checkDK(MaMH,MaSV);
        }
        public bool delDSDKMH(int id)
        {
            return dalDSDKMH.delDSDKMH(id);
        }
    }
}
