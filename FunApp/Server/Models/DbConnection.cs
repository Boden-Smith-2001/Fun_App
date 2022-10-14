using System;
using System.Data.SqlClient;

namespace FunApp.Server.Models
{
    // Used to connect and disconnect from database.
    public class DbConnection
    {
        private string connectionString_Local = "Server=(localdb)\\MSSQLLocalDB;Database=FunApp;User ID=Boden_Smith;Password=Boderm@nsmith2001;MultipleActiveResultSets=true";

        public readonly SqlConnection connected = new SqlConnection();

        public DbConnection()
        {
            connected.ConnectionString = connectionString_Local;
        }

        public void OpenConnection()
        {
            connected.ConnectionString = this.connectionString_Local;
            connected.Open();
        }

        public void CloseConnection()
        {
            connected.Close();
            connected.ConnectionString = "";
        }
    }
}
