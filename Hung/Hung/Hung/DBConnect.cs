using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Hung
{
    public class DBConnect
    {
        protected SqlConnection Connection = new SqlConnection("Data Source=DESKTOP-16PLU27\\SQLEXPRESS;Initial Catalog=QLHT;Integrated Security=True");
    }
}
