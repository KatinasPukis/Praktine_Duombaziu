using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praktine_Duombaziu.Data
{
    public class DatabaseRepository
    {
        private SqlConnection conn;
        public DatabaseRepository()
        {
            conn = new SqlConnection(@"Server=.;Database=duombaze;Trusted_Connection=true;");
        }

    }
}
