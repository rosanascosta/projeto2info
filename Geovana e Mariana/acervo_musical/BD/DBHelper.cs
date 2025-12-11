using MySql.Data.MySqlClient;
using System;

namespace AcervoMusical.BD
{
    public static class DBHelper
    {
        private static string connStr = "server=localhost;database=acervo;uid=root;pwd='';";

        public static MySqlConnection GetConnection()
        {
            var conn = new MySqlConnection(connStr);
            return conn;
        }
    }
}
