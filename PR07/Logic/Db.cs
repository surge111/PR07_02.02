using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace PR07.Logic
{
    /// <summary>
    /// Static class for interaction with database
    /// </summary>
    public static class Db
    {
        static private string _connectionString = "";

        /// <summary>
        /// Makes connectinon string for MySqlConnection class
        /// </summary>
        /// <param name="host">Address of host Db</param>
        /// <param name="user">Access user</param>
        /// <param name="password">Access user pswd</param>
        /// <param name="dbName">Database name</param>
        /// <returns>Connection string</returns>
        public static string MakeConnectionString(string host, string user, string password, string dbName)
        {
            if (host.Trim() == "" || user.Trim() == "" || password.Trim() == "" || dbName.Trim() == "") return "";
            _connectionString = $"host={host};user={user};password={password};database={dbName}";
            return _connectionString;
        }

        /// <summary>
        /// Makes open MySql connection
        /// </summary>
        /// <returns></returns>
        public static MySqlConnection GetOpenConnection()
        {
            MySqlConnection con = new MySqlConnection(MakeConnectionString("127.0.0.1", "root", "root", "dbTest"));
            try
            {
                con.Open();
                return con; ;
            }
            catch (MySqlException)
            {
                return null;
            }
        }
    }
}
