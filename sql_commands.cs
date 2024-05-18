using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMS
{
    internal class sql_commands
    {
       
        public SqlConnection getConnect()
        {
            SqlConnection cn = new SqlConnection();
            string conStr = @"Data Source=TIKEIIS_LAPTOP\TIKEIISERVER;Initial Catalog=ems_database;Integrated Security=True;TrustServerCertificate=True";
            cn.ConnectionString = conStr;
            return cn;
        }
        
    }
}
