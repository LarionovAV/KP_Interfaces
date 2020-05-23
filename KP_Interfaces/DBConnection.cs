using System;
using Npgsql;
namespace Printers
{
    class DBConnection
    {
        private static NpgsqlConnection connection = null;

        private DBConnection(string user, string password) {
            try
            {
                string connectionString 
                    = "Server = " + Properties.Settings.Default.dbAddress 
                    + "; Port = " + Properties.Settings.Default.dbPort 
                    + "; Database = " + Properties.Settings.Default.dbName 
                    + "; User Id = " + user + "; Password = " + password + ";";
                connection = new NpgsqlConnection(connectionString);
                connection.Open();
            }
            catch (Exception e) {
                connection = null;
            }
        }

        public static NpgsqlConnection getConnection(string user = "PrintersAdmin", string passsword = "printersadmin") {
            if (connection == null) {
                new DBConnection(user, passsword);
            }

            return connection;
        }
    }
}
