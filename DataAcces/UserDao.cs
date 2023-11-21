using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Common.Cache;

namespace DataAcces
{
    public class UserDAO : ConnectionToSQL
    {
        public bool Login(string usuario, string contraseña)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "select * from Users us Inner Join Ubicacion u ON u.Id_Ubicacion = us.Id_Ubicacion where LoginName = @user and Password = @pass ";
                    command.Parameters.AddWithValue("@user", usuario);
                    command.Parameters.AddWithValue("@pass", contraseña);
                    command.CommandType = System.Data.CommandType.Text;
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            UserCache.Id_Usuario = reader.GetInt32(0);
                            UserCache.Nombre = reader.GetString(1);

                        }
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                }
            }
        }
    }
}
