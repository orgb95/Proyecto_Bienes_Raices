using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DataAcces
{
    public abstract class ConnectionToSQL
    {
        private readonly string connectionString;
        public ConnectionToSQL()
        {
            connectionString = "Server=LAPTOP-28U9EDEA;DataBase = Bienes_Raices; integrated security = true";
        }
        protected SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }

    }
}
