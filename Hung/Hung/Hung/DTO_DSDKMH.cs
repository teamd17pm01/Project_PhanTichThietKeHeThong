using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hung
{
    public class DTO_DSDKMH
    {
        private int _Id;
        private int _MaDKMH;
        private string _MaMH;
        private string _MaSV;
        
        public string MaMH { get => _MaMH; set => _MaMH = value; }
        public string MaSV { get => _MaSV; set => _MaSV = value; }
        public int Id { get => _Id; set => _Id = value; }
        public int MaDKMH { get => _MaDKMH; set => _MaDKMH = value; }

        public DTO_DSDKMH() { }
        public DTO_DSDKMH(int id, int madkmh, string mamh, string masv)
        {
            Id = id;
            MaDKMH = madkmh;
            MaMH = mamh;
            MaSV = masv;
        }
    }
}
