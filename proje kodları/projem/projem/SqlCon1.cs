using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace projem
{
    class SqlCon
    {
        public SqlConnection bgl()
        {
            SqlConnection sbgl = new SqlConnection("Data Source=EMREEYS;Initial Catalog=GetirDepo;Integrated Security=True");
            sbgl.Open();
            return sbgl;
        }
    }
}