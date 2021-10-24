using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.Ef
{
    public class DatabaseConnection
    {
        public DatabaseConnection()
        {
        }
        public static string SetConnectionString(string connectionString)
        {
            return RevitSampleProjectDBContext.ConnectionString = connectionString;
        }
    }
}
