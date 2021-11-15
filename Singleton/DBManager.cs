using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    class DBManager
    {
        private static DBManager instance_ = new DBManager();
        private string connection_string = "Server=27.96.130.41;Database=s5584534;Uid=s5584534;Pwd=s5584534;Charset=utf8";

        private DBManager()
        {
            //initialization
        }

        public static DBManager GetInstance()
        {
            return instance_;
        }

        public void insert(string query)
        {
            using (MySqlConnection conn = new MySqlConnection(connection_string))
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.ExecuteNonQuery();
            }
        }

        public void update(string query)
        {
            using (MySqlConnection conn = new MySqlConnection(connection_string))
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.ExecuteNonQuery();
            }
        }

        public MySqlDataReader select(string query)
        {
            using (MySqlConnection conn = new MySqlConnection(connection_string))
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(query, conn);
                return cmd.ExecuteReader();
            }
        }
    }
}
